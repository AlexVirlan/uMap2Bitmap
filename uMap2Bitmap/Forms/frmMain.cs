using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using uMap2Bitmap.Controls;
using uMap2Bitmap.Entities;
using uMap2Bitmap.Utilities;

namespace uMap2Bitmap.Forms
{
    public partial class frmMain : Form
    {
        #region Variables
        private int _layersCount = 0;
        private int _polysCount = 0;
        private int _checkedPolygons = 0;
        private string _appTitle = "uMap2Bitmap";
        private string _outputPath = string.Empty;
        private string _currentFilePath = string.Empty;
        private string _templateFileData = string.Empty;
        private string _NL = Environment.NewLine;
        private bool _modifiedByCode = false;
        private UMapData? _uMapData = null;
        private UmapOptions? _selectedLayerOptions = null;
        private Feature? _selectedPolygon = null;
        private frmBrowser? _frmBrowser = null;
        private (bool isValid, string validationResult) _umapDataValidation = (true, string.Empty);
        public event EventHandler LoadComplete;

        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Templates");
            LoadTextEditors();
            LoadTemplates();
            fswTemplates.Path = "Templates";
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            _frmBrowser = new frmBrowser(this.Location, this.Size);
            _frmBrowser.BrowserInitializationCompleted += BrowserInitializationCompleted;
            _frmBrowser.Show();

        }

        public void BrowserInitializationCompleted(object? sender, EventArgs e)
        {
            _frmBrowser?.LoadDefault(hideWindow: false);
            LoadComplete.Invoke(this, EventArgs.Empty);
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Opacity = 0;
            base.OnLoad(e);
        }

        public void ShowWindow()
        {
            SetView(ViewType.DragDrop);
            ProcessArguments();

            Visible = true;
            ShowInTaskbar = true;
            Opacity = 1;
            this.Refresh();
            //_frmBrowser?.ShowWindow();
            this.Focus();
        }

        private void ProcessArguments()
        {
            if (Globals.Args is not null)
            {
                int argsCount = Globals.Args.Count;
                if (argsCount > 1)
                {
                    ShowMessage($"I received {argsCount} files, too many - I work with only one file at a time. " +
                        "Please send only one file next time.", MessageBoxIcon.Warning);
                }
                else if (argsCount == 1)
                {
                    FunctionResponse frLoad = LoadFile(Globals.Args[0]);
                    if (frLoad.Error)
                    {
                        if (_umapDataValidation.isValid)
                        {
                            ShowMessage("An error occurred while loading the file:" + _NL + frLoad.Message, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ShowMessage("The uMap file is invalid." + _NL +
                                "A notepad window will be opened containing the validation result.", MessageBoxIcon.Warning);
                            Helpers.ShowNotepadMessage(_umapDataValidation.validationResult, $"{_appTitle} validation result");
                        }
                    }
                    else
                    {
                        SetView(ViewType.Main);
                    }
                }
            }
        }

        private void SetView(ViewType viewType)
        {
            pnlDragDrop.Visible = pnlMain.Visible = pnlAppSettings.Visible = false;
            switch (viewType)
            {
                case ViewType.DragDrop:
                    pnlDragDrop.Visible = true;
                    break;

                case ViewType.Main:
                    pnlMain.Visible = true;
                    break;

                case ViewType.Settings:
                    pnlAppSettings.Visible = true;
                    break;
            }
        }

        private void LoadTextEditors()
        {
            List<TextEditor> textEditors = Helpers.GetTextEditors(onlyExisting: true);
            textEditors.ForEach(te => cmbTextEditors.Items.Add(new ComboboxItem(te.Name, te.Path.ToStringSafely())));
            if (cmbTextEditors.Items.Count > 0) { cmbTextEditors.SelectedIndex = 0; }
        }

        private void LoadTemplates()
        {
            cmbTemplates.Items.Clear();
            IEnumerable<string> files = Directory.EnumerateFiles("Templates", "*.*", SearchOption.TopDirectoryOnly)
                .Where(s => s.EndsWith(".html", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".txt", StringComparison.OrdinalIgnoreCase));
            foreach (string file in files)
            {
                cmbTemplates.Items.Add(Path.GetFileName(file));
            }
            lblTemplatesTitle.Text = $"Templates ({cmbTemplates.Items.Count}):";
            // reset/hide the map
            _frmBrowser?.LoadDefault();

        }

        private FunctionResponse LoadFile(string filePath)
        {
            try
            {
                #region Preparations
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                _umapDataValidation = (isValid: true, validationResult: string.Empty);
                _frmBrowser?.Hide();
                #endregion

                #region Path validations
                if (filePath.INOE())
                { return new FunctionResponse(error: true, message: "The file path is empty."); }

                if (Path.Exists(filePath) && Helpers.GetPathType(filePath) == PathType.Directory)
                { return new FunctionResponse(error: true, message: "The provided path is a directory, not a file."); }

                if (!File.Exists(filePath))
                { return new FunctionResponse(error: true, message: "The following file is missing:" + _NL + filePath); }
                #endregion

                #region Load file data
                string fileData;
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    fileData = streamReader.ReadToEnd();
                }

                if (fileData.INOE())
                { return new FunctionResponse(error: true, message: "The file is empty."); }

                _uMapData = UMapData.FromJson(fileData);
                #endregion

                #region uMap data validations
                _layersCount = _uMapData.Layers.Count;
                if (_layersCount == 0)
                { return new FunctionResponse(error: true, message: "There are no layers in this uMap file."); }

                _uMapData.Layers.ForEach(layer => _polysCount += layer.Features.Count);
                if (_polysCount == 0)
                { return new FunctionResponse(error: true, message: "There are no polygons in this uMap file."); }

                string emptyNameLayersResult = "• ";
                int emptyNameLayersCount = _uMapData.Layers.Where(layer => string.IsNullOrEmpty(layer.UmapOptions.Name)).Count();
                if (emptyNameLayersCount > 0)
                {
                    emptyNameLayersResult += (emptyNameLayersCount > 1 ? $"There are {emptyNameLayersCount} layers with empty names." :
                        "There is one layer with no name.");
                }

                string dupLayerResult = "• ";
                Dictionary<string, int> dupLayers = _uMapData.Layers.GroupBy(layer => layer.UmapOptions.Name)
                    .Where(w => w.Count() > 1)
                    .ToDictionary(d => d.Key, d => d.Count());
                int dupLayersCount = dupLayers.Count;
                if (dupLayersCount > 0)
                {
                    dupLayerResult += (dupLayersCount > 1 ? $"There are {dupLayersCount} layers that have one or more duplicates:" :
                        "There is one layer that has one or more duplicates:") + _NL;
                    foreach (KeyValuePair<string, int> dup in dupLayers)
                    {
                        dupLayerResult += $"- {dup.Key} ({dup.Value} occurrences){_NL}";
                    }
                }

                int notNamedPolysTotal = 0;
                int dupPolysTotal = 0;
                string layersResults = "• Invalid polygons:" + _NL;
                foreach (Layer layer in _uMapData.Layers)
                {
                    if (layer.Features.Count == 0) { continue; }
                    int notNamedPolysForCurrentLayer = layer.Features.Where(feature => string.IsNullOrEmpty(feature.Properties.Get("name"))).Count();
                    Dictionary<string, int> dupPolysInLayer = layer.Features.GroupBy(feature => feature.Properties.Get("name"))
                        .Where(w => w.Count() > 1 && !string.IsNullOrEmpty(w.Key))
                        .ToDictionary(d => d.Key, d => d.Count());

                    if (notNamedPolysForCurrentLayer > 0 || dupPolysInLayer.Count > 0)
                    {
                        string currentLayerResult = $"- in layer: {layer.UmapOptions.Name}" + _NL;

                        if (notNamedPolysForCurrentLayer > 0)
                        {
                            notNamedPolysTotal += notNamedPolysForCurrentLayer;
                            currentLayerResult += $"Polygons without name: {notNamedPolysForCurrentLayer}" + _NL;
                        }

                        if (dupPolysInLayer.Count > 0)
                        {
                            dupPolysTotal += dupPolysInLayer.Count;
                            currentLayerResult += $"Duplicated polygons ({dupPolysInLayer.Count}): ";
                            foreach (KeyValuePair<string, int> dup in dupPolysInLayer)
                            {
                                currentLayerResult += $"{dup.Key} ({dup.Value} occurrences), ";
                            }
                            currentLayerResult = currentLayerResult.Substring(0, currentLayerResult.Length - 2) + _NL;
                        }

                        layersResults += _NL + currentLayerResult;
                    }
                }

                string valResultTmp = string.Empty;
                if (emptyNameLayersCount > 0 || dupLayersCount > 0 || notNamedPolysTotal > 0 || dupPolysTotal > 0)
                {
                    valResultTmp = $"{_appTitle} file validation result: " + _NL + filePath + _NL.Repeat();
                    if (emptyNameLayersCount > 0) { valResultTmp += emptyNameLayersResult + _NL.Repeat(); }
                    if (dupLayersCount > 0) { valResultTmp += dupLayerResult + _NL; }
                    if (notNamedPolysTotal > 0 || dupPolysTotal > 0) { valResultTmp += layersResults + _NL; }

                    _umapDataValidation = (isValid: false, validationResult: valResultTmp);
                    return new FunctionResponse(error: true, message: "The uMap data is invalid.");
                }
                #endregion

                #region Populate treeview
                foreach (Layer layer in _uMapData.Layers)
                {
                    layer.Features = layer.Features.OrderBy(o => o.Properties.Get("name"), new LogicalComparer()).ToList();
                    if (!treeView.Nodes.ContainsKey(layer.UmapOptions.Name))
                    { treeView.Nodes.Add(layer.UmapOptions.Name, $"{layer.UmapOptions.Name} ({layer.Features.Count} polygons)"); }
                    foreach (Feature future in layer.Features)
                    {

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        treeView.Nodes[layer.UmapOptions.Name].Nodes.Add(future.Properties.Get("name"), future.Properties.Get("name"));
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    }
                }
                #endregion

                #region Update map properties
                lblUMapName.Text = _uMapData.Properties.Name;
                lblUMapDescription.Text = _uMapData.Properties.Description;
                lblUMapTileLayerName.Text = _uMapData.Properties.Tilelayer.Name;
                lblUMapTileLayerUrl.Text = _uMapData.Properties.Tilelayer.UrlTemplate;
                lblUMapZoomMin.Text = _uMapData.Properties.Tilelayer.MinZoom.ToString();
                lblUMapZoomMax.Text = _uMapData.Properties.Tilelayer.MaxZoom.ToString();
                // $"Min: {_uMapData.Properties.Tilelayer.MinZoom}, Max: {_uMapData.Properties.Tilelayer.MaxZoom}";
                #endregion

                #region Finishing up
                treeView.Nodes.CheckTreeNodeCollection();
                UpdateStatistics();

                _currentFilePath = filePath;
                SetDefaultOutputDirectory();

                Thread threadPP = new Thread(LoadPolysProperties);
                threadPP.Start();

                _frmBrowser.ShowWindow();
                _frmBrowser.LoadDefault();
                stopwatch.Stop();
                #endregion

                #region Return
                double loadTime = Math.Round(stopwatch.Elapsed.TotalSeconds, 2, MidpointRounding.AwayFromZero);
                return new FunctionResponse(error: false, message: $"File loaded successfully in {loadTime} seconds.");
                #endregion
            }
            catch (Exception ex)
            {
                return new FunctionResponse(ex);
            }
        }

        private void LoadPolysProperties()
        {
            Globals.CustomPropsStats = new Dictionary<string, Dictionary<string, List<string>>>(StringComparer.OrdinalIgnoreCase);
            //Dictionary<string, Dictionary<string, List<string>>>
            ////         custom             layer        features
            ////         prop               name         names
            ////         name

            List<string> allProps = _uMapData.Layers.SelectMany(layer => layer.Features)
                .SelectMany(feature => feature.Properties.Properties().Select(jProperty => jProperty.Name))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            foreach (string prop in allProps)
            {
                Globals.CustomPropsStats.Add(prop, new Dictionary<string, List<string>>());
                foreach (Layer layer in _uMapData.Layers)
                {
                    List<string> featureNames = layer.Features.Where(feature => feature.Properties.Properties()
                        .Any(jProperty => jProperty.Name.Equals(prop, StringComparison.OrdinalIgnoreCase)))
                        .Select(feature => feature.Properties.Get("name"))
                        .ToList();

                    Globals.CustomPropsStats[prop].Add(layer.UmapOptions.Name, featureNames);
                }
            }

            string rawDebugData = JsonConvert.SerializeObject(Globals.CustomPropsStats); // for debugging only, will be removed later
        }

        private void UpdateStatistics()
        {
            int checkedLayers = treeView.Nodes.Cast<TreeNode>().Where(node => node.Checked).Count();
            _checkedPolygons = treeView.Descendants().Where(node => node.Checked && node.Parent != null).Count();
            lblStatistics.Text = $"Checked layers: {checkedLayers}/{_layersCount}  |  Checked polygons: {_checkedPolygons}/{_polysCount}";
            btnRUN.Enabled = checkedLayers > 0 && _checkedPolygons > 0;
        }

        private void ShowMessage(string message, MessageBoxIcon icon = MessageBoxIcon.Information, string title = "")
        {
            if (message.INOE()) { return; }
            if (title.INOE()) { title = _appTitle; }
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, icon);
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            treeView.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            treeView.CollapseAll();
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            treeView.Nodes.CheckTreeNodeCollection();
            UpdateStatistics();
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            treeView.Nodes.CheckTreeNodeCollection(isChecked: false);
            UpdateStatistics();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bool hasParent = e.Node?.Parent is not null;
            if (hasParent) { CleanAndShowProperties(PropertiesType.Polygons); }
            else { CleanAndShowProperties(PropertiesType.Layers); }

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string layerName = hasParent ? e.Node?.Parent.Name : e.Node?.Name;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            Layer? layer = _uMapData?.Layers.FirstOrDefault(layer => layer.UmapOptions.Name.Equals(layerName));
            _selectedLayerOptions = layer?.UmapOptions;

            if (_selectedLayerOptions is not null)
            {
                lblPolyColor.Text = _selectedLayerOptions.Color.ReplaceIfEmpty("-");
                lblPolyFill.Text = _selectedLayerOptions.Fill.ToStringSafely(valueIfNull: "-");
                lblPolyFillColor.Text = _selectedLayerOptions.FillColor.ReplaceIfEmpty("-");
                lblPolyFillOpacity.Text = _selectedLayerOptions.FillOpacity.ToStringSafely(valueIfNull: "-");
                txtPolyDescription.Text = _selectedLayerOptions.Description.ReplaceIfEmpty("");
#pragma warning disable CS8629 // Nullable value type may be null.
                lblPolyColor.HoverColor = (Color)Helpers.GetColor(lblPolyColor.Text, fallbackColor: Color.White);
                lblPolyFillColor.HoverColor = (Color)Helpers.GetColor(lblPolyFillColor.Text, fallbackColor: Color.White);
#pragma warning restore CS8629 // Nullable value type may be null.
            }

            _selectedPolygon = null;
            if (hasParent)
            {
                _selectedPolygon = layer?.Features.FirstOrDefault(feature => feature.Properties.Get("name").Equals(e.Node?.Name));
                if (_selectedPolygon is not null)
                {
                    foreach (JProperty property in _selectedPolygon.Properties.Properties().OrderBy(prop => prop.Name))
                    {
                        dgvProperties.Rows.Add(property.Name, property.Value);
                    }
                    CheckMapSizeCustomPropertyValue();
                }
            }

            if (cmbTemplates.SelectedIndex == -1)
            {
                _frmBrowser?.LoadDefault();
                return;
            }
            LoadMap();
            // load map
        }

        private void treeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node?.Nodes.Count > 0)
                {
                    treeView.BeginUpdate();
                    e.Node?.CheckAllChildNodes(e.Node.Checked);
                    treeView.EndUpdate();
                }
                e.Node?.ChecktParents(e.Node.Checked);
                UpdateStatistics();
            }
        }

        private void CleanAndShowProperties(PropertiesType propertiesType)
        {
            pnlLayerProperties.Visible = pnlPolygonProperties.Visible = false;

            dgvProperties.Rows.Clear();
            lblPolyColor.Text = lblPolyFill.Text = lblPolyFillColor.Text = lblPolyFillOpacity.Text = txtPolyDescription.Text = string.Empty;
            lblPropertiesNote.Text = string.Empty;

            if (propertiesType == PropertiesType.Layers)
            {
                lblPropertiesInfo.Text = "Layer properties:";
                lblPropertiesNote.Text = "(every property can be used as a tag)";
                pnlLayerProperties.Visible = true;
                //////////// arata html +render(si chk cu autorender ?)
            }
            else if (propertiesType == PropertiesType.Polygons)
            {
                lblPropertiesInfo.Text = "Polygon properties:";
                lblPropertiesNote.Text = "(double click on a row to copy the property name as a tag)";
                pnlPolygonProperties.Visible = true;
                /////////// ascunde html
            }
        }

        private void CopyCustomLabelHoverColor(object sender, EventArgs e)
        {
            CustomLabel lbl = (CustomLabel)sender;
            string strColor = ModifierKeys.HasFlag(Keys.Control) ? lbl.HoverColor.ToRGB() : lbl.HoverColor.ToHex();
            Clipboard.Clear();
            Clipboard.SetText(strColor);
        }

        private void btnOpenTemplate_Click(object sender, EventArgs e)
        {
            if (cmbTemplates.SelectedItem.ToStringSafely().INOE())
            {
                ShowMessage("Please select a template first.", MessageBoxIcon.Warning);
                return;
            }

            ComboboxItem? textEditor = cmbTextEditors.SelectedItem as ComboboxItem;
            if (textEditor is null) { return; }

            string fullPath = Path.Combine(Application.StartupPath, "Templates", cmbTemplates.SelectedItem.ToStringSafely());

            if (!File.Exists(fullPath))
            {
                ShowMessage("This file can't be found:" + _NL.Repeat() + fullPath, MessageBoxIcon.Warning);
                return;
            }
            Process.Start(textEditor.Value, $"\"{fullPath}\"");
        }

        private void lblOpenTemplatesDir_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Templates")) { Directory.CreateDirectory("Templates"); }
            Process.Start("explorer.exe", "Templates");
        }

        private void lblTemplatesInfo_Click(object sender, EventArgs e)
        {
            ShowMessage($"All the files with the .html or .txt extension within the 'Templates' directory will be shown here. They are called simply 'Templates'. {_NL.Repeat()}The drop-down list will be automatically updated every time you add/remove/edit a file within the 'Templates' directory. So no need to refresh/restart anything. Just be aware that with every modification in this directory, you will have to choose a file. {_NL.Repeat()}The 'Templates' directory must be in the same place as this app's executable (if it's missing, it will be created). Other subdirectories are not scanned.");
        }

        private void fswTemplates_CreatedChangedDeleted(object sender, FileSystemEventArgs e)
        {
            if (e.Name is null) { return; }

            if ((new string[] { ".html", ".txt" }).Contains(Path.GetExtension(e.Name).ToLower()))
            {
                LoadTemplates();
            }
        }

        private void fswTemplates_Renamed(object sender, RenamedEventArgs e)
        {
            if (e.Name is null) { return; }

            if ((new string[] { ".html", ".txt" }).Contains(Path.GetExtension(e.Name).ToLower()))
            {
                LoadTemplates();
            }
        }

        private void SetDefaultOutputDirectory()
        {
            _outputPath = Path.GetDirectoryName(_currentFilePath);
            lblOutput.Text = new DirectoryInfo(_outputPath).Name;
        }

        private void btnRUN_Click(object sender, EventArgs e)
        {
            #region Validations
            if (cmbTemplates.SelectedIndex < 0)
            {
                ShowMessage("Please select a template first.", MessageBoxIcon.Warning);
                return;
            }

            if (_templateFileData.INOE()) // dezactiveaza si btnStart sau verifica inca o data acolo la click
            {
                ShowMessage("The selected template is empty.", MessageBoxIcon.Warning);
                return;
            }
            #endregion

            // blocheaza panouri si btn UI + btn de pauza si stop/cancel
            backgroundWorker.RunWorkerAsync();
        }

        private void Sleep(int interval)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < interval)
            {
                Application.DoEvents();
            }
            stopwatch.Stop();
        }

        private FunctionResponse SaveBitmap()
        {
            try
            {
                if (_selectedPolygon is null) { return new FunctionResponse(error: true, message: "The selected polygon is null."); }

                PageCapture pageCaptureSettings = new PageCapture() // in the future take this from settings
                {
                    Format = PageCaptureType.Png,
                    Quality = 100,
                    FromSurface = true,
                    CaptureBeyondViewport = true,
                    OptimizeForSpeed = false
                };
                string pageCaptureStr = JsonConvert.SerializeObject(pageCaptureSettings, Formatting.None);

                string devData = "";

                var vvv = _frmBrowser.webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", pageCaptureStr).ConfigureAwait(false).GetAwaiter().GetResult();

                //var task = Task.Run(async () => await _frmBrowser.webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", pageCaptureStr));
                //var result = task.Result;

                //var vvv = _frmBrowser.webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", pageCaptureStr).GetAwaiter().GetResult();
                //var vvv = _frmBrowser.webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", pageCaptureStr);
                //var xxx = vvv.Result;

                //var task = Task.Run(() => _frmBrowser.webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", pageCaptureStr));
                //task.Wait();
                //var asd = task.Result;

                //var task = Task.Run(() =>
                //this.Invoke(new MethodInvoker(delegate () { _frmBrowser.webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", pageCaptureStr); }))
                //);
                //task.Wait();
                //var asd = task.Result;

                //var task = Task.Run(async () => { await _frmBrowser.webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", pageCaptureStr); });
                //task.Wait();

                //string devData = "";
                //this.Invoke(new MethodInvoker(delegate ()
                //{
                //    var task = Task.Run(async () => await _frmBrowser.webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", pageCaptureStr));
                //    var result = task.Result;
                //    devData = result;
                //}));

                //this.Invoke(new MethodInvoker(delegate ()
                //{
                //    var task = Task.Run(() => _frmBrowser.webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", pageCaptureStr));
                //    var result = task.Result;
                //    devData = result;
                //}));

                //_frmBrowser.Invoke(new MethodInvoker(delegate ()
                //{
                //    //var vvv = _frmBrowser.webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", pageCaptureStr).Result;
                //    var task = Task.Run(async () => await _frmBrowser.webView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", pageCaptureStr));
                //    var result = task.Result;
                //    devData = result;
                //}));

                // fa poza din FRM si ia-o pintr-o metoda aici
                //var vvv = _frmBrowser.GetCapture(pageCaptureStr);

                string imgData = JObject.Parse(devData)["data"].ToString();
                if (imgData.INOE()) { return new FunctionResponse(error: true, message: "The capture data is empty."); }

                using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(imgData)))
                {
                    string format = pageCaptureSettings.Format.ToString().ToLower();
                    string filePath = Path.Combine(_outputPath,
                        "uMap2Bitmap export", // in the future take this from settings
                        _selectedLayerOptions.Name.RemoveInvalidChars(),
                        _selectedPolygon.Properties.Get("name").RemoveInvalidChars() + $".{format}");
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                    if (File.Exists(filePath)) { } // do something, from settings... ??

                    Image image = Image.FromStream(memoryStream);
                    image.Save(filePath, Helpers.ParseImageFormat(format));
                }

                return new FunctionResponse();
            }
            catch (Exception ex)
            {
                return new FunctionResponse(ex);
            }
        }

        private void cmbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTemplates.SelectedIndex < 0)
            {
                _frmBrowser?.LoadDefault();
                return;
            }

            string filePath = Path.Combine(Application.StartupPath, "Templates", cmbTemplates.SelectedItem.ToStringSafely());
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                _templateFileData = streamReader.ReadToEnd();
            }

            if (_templateFileData.INOE()) // dezactiveaza si btnStart sau verifica inca o data acolo la click
            {
                ShowMessage("This template is empty:" + _NL.Repeat() + filePath, MessageBoxIcon.Warning);
                _frmBrowser?.LoadDefault();
                return;
            }

            // load map
            LoadMap();
        }

        private void dgvProperties_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProperties.Rows.Count == 0 || dgvProperties.SelectedRows[0].Cells["PropertyName"].Value.ToStringSafely().INOE()) { return; }
            Clipboard.Clear();
            Clipboard.SetText($"{{{{{dgvProperties.SelectedRows[0].Cells["PropertyName"].Value.ToStringSafely()}}}}}");
        }

        private void chkMapSizeCustomProperty_CheckedChanged(object sender, EventArgs e)
        {
            txtMapSizeCustomProperty.Enabled = chkMapSizeCustomPropertyIgnoreCase.Enabled = chkMapSizeCustomProperty.Checked;
            lblMapWinowSize.Text = chkMapSizeCustomProperty.Checked ? "Fallback size:" : "Size:";
            //txtMapSizeCustomProperty_TextChanged(sender, EventArgs.Empty);
            //if (!chkMapSizeCustomProperty.Checked) { txtMapSizeCustomProperty.BackColor = Color.FromArgb(17, 17, 17); }
            UpdateMapWindowsSize();
        }

        private void txtMapSizeCustomProperty_DoubleClick(object sender, EventArgs e)
        {
            if (txtMapSizeCustomProperty.Enabled)
            {
                string txt = Clipboard.GetText();
                if (!txt.INOE()) { txtMapSizeCustomProperty.Text = txt; }
            }
        }

        private void txtMapSizeCustomProperty_TextChanged(object sender, EventArgs e)
        {
            //if (txtMapSizeCustomProperty.Text.StartsWith("{{") &&
            //    txtMapSizeCustomProperty.Text.EndsWith("}}"))
            //{ txtMapSizeCustomProperty.BackColor = Color.FromArgb(17, 17, 17); }
            //else { txtMapSizeCustomProperty.BackColor = Color.FromArgb(64, 17, 17); }
            CheckMapSizeCustomPropertyValue();
            UpdateMapWindowsSize();
            // verifica iar valoarea te custom map size
        }

        private void UMapPropertiesLabelsCopyTag(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string text = ModifierKeys.HasFlag(Keys.Control) ? label.Text : label.Tag.ToStringSafely();
            Clipboard.Clear();
            Clipboard.SetText(text);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblTagsInfo_Click(object sender, EventArgs e)
        {
            ShowMessage($"Tags are properties of the map, layers, and polygons, that can be used as variables in your templates. {_NL.Repeat()}You can insert them anywhere in your templates, just make sure they are in the correct format (enclosed in double curly braces). {_NL.Repeat()}They will be automatically replaced with their corresponding value in the map window preview. {_NL.Repeat()}Besides the 16 built-in tags, you can use any of the custom properties of a polygon (visible in the properties panel when you select a polygon), that are manageable from the uMap platform*. {_NL.Repeat()}Don't worry if some of the polygons do not have certain properties. If a tag's value is missing/null/empty, an empty string will be inserted in that tag's place. {_NL.Repeat()}*Note: Duplicated polygon properties will be ignored. {_NL.Repeat()} To learn more about how to use the tags, select the 'Default' template.");
        }

        private void lblMapDefaultBackgroundColor_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DialogResult dialogResult = colorDialog.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        Color color = colorDialog.Color;
                        lblMapDefaultBackgroundColor.BackColor = color;
                        lblMapDefaultBackgroundColor.ForeColor = color.Invert();
                        lblMapDefaultBackgroundColor.Text = color.ToRGB();
                        _frmBrowser.webView.DefaultBackgroundColor = color;
                    }
                    break;

                case MouseButtons.Right:
                    string strColor = ModifierKeys.HasFlag(Keys.Control) ? lblMapDefaultBackgroundColor.BackColor.ToRGB() : lblMapDefaultBackgroundColor.BackColor.ToHex();
                    Clipboard.Clear();
                    Clipboard.SetText(strColor);
                    break;
            }
        }

        private void chkBorderlessMapWindow_CheckedChanged(object sender, EventArgs e)
        {
            _frmBrowser.FormBorderStyle = chkBorderlessMapWindow.Checked ? FormBorderStyle.None : FormBorderStyle.Sizable;
        }

        private void numMapWidthHeight_ValueChanged(object sender, EventArgs e)
        {
            if (_modifiedByCode) { return; }
            UpdateMapWindowsSize();
        }

        private Size UpdateMapWindowsSize()
        {
            int width = numMapWidth.Value.ToInt();
            int height = numMapHeight.Value.ToInt();
            bool ignoreCase = chkMapSizeCustomPropertyIgnoreCase.Checked;
            string mapSizeCustomPropValue = _selectedPolygon is null ? "" : _selectedPolygon.Properties.Get(txtMapSizeCustomProperty.Text.Trim(), ignoreCase);
            Size size = chkMapSizeCustomProperty.Checked ? Helpers.GetSize(mapSizeCustomPropValue, fallbackSize: new Size(width, height)) : new Size(width, height);
            _frmBrowser.Size = size;
            return size;
        }

        private FunctionResponse LoadMap()
        {
            try
            {
                //if (cmbTemplates.SelectedIndex < 0 ||
                //    cmbTemplates.SelectedItem.ToStringSafely().INOE())
                //{ return; }

                //string filePath = Path.Combine(Application.StartupPath, "Templates", cmbTemplates.SelectedItem.ToStringSafely());
                //if (!File.Exists(filePath))
                //{
                //    ShowMessage("This template can't be found:" + _NL.Repeat() + filePath, MessageBoxIcon.Warning);
                //    return;
                //}

                //FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                //using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
                //{
                //    _templateFileData = streamReader.ReadToEnd();
                //}

                //if (_templateFileData.INOE())
                //{
                //    ShowMessage("This template is empty:" + _NL.Repeat() + filePath, MessageBoxIcon.Warning);
                //    return;
                //}

                Size size = UpdateMapWindowsSize();
                string processedTemplate = ProcessTags(_templateFileData, chkIgnoreTagCase.Checked, chkRemoveUnusedTags.Checked);
                return _frmBrowser.LoadHTML(processedTemplate, size, lblMapDefaultBackgroundColor.BackColor);
            }
            catch (Exception ex)
            {
                return new FunctionResponse(ex);
            }
        }

        private string ProcessTags(string templateData, bool ignoreCase = false, bool removeOtherTags = false)
        {
            #region Layer properties
            string layerName, layerDescription, layerColor, layerFill, layerFillColor, layerFillOpacity;
            layerName = layerDescription = layerColor = layerFill = layerFillColor = layerFillOpacity = string.Empty;

            if (_selectedLayerOptions is not null)
            {
                layerName = _selectedLayerOptions.Name;
                layerDescription = _selectedLayerOptions.Description.ReplaceIfEmpty(replacement: "");
                layerColor = _selectedLayerOptions.Color.ReplaceIfEmpty(replacement: "");
                layerFill = _selectedLayerOptions.Fill.ToStringSafely(valueIfNull: "");
                layerFillColor = _selectedLayerOptions.FillColor.ReplaceIfEmpty(replacement: "");
                layerFillOpacity = _selectedLayerOptions.FillOpacity.ToStringSafely(valueIfNull: "");
            }
            #endregion

            #region Dictionary mapping
            Dictionary<string, string> map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "{{mapName}}", _uMapData.Properties.Name },
                { "{{mapDescription}}", _uMapData.Properties.Description },
                { "{{mapTileLayer}}", _uMapData.Properties.Tilelayer.Name },
                { "{{mapTileLayerUrl}}", _uMapData.Properties.Tilelayer.UrlTemplate },
                { "{{mapZoomMin}}", _uMapData.Properties.Tilelayer.MinZoom.ToString() },
                { "{{mapZoomMax}}", _uMapData.Properties.Tilelayer.MaxZoom.ToString() },
                { "{{mapLayersCount}}", _layersCount.ToString() },
                { "{{mapPolygonsCount}}", _polysCount.ToString() },
                { "{{layerName}}", layerName },
                { "{{layerDescription}}", layerDescription },
                { "{{layerColor}}", layerColor },
                { "{{layerFill}}", layerFill },
                { "{{layerFillColor}}", layerFillColor },
                { "{{layerFillOpacity}}", layerFillOpacity },
                { "{{polygonName}}", _selectedPolygon is null ? "" : _selectedPolygon.Properties.Get("name") },
                { "{{geometry}}", string.Empty }
            };
            #endregion

            #region Polygon properties
            if (_selectedPolygon is not null)
            {
                map["{{geometry}}"] = JsonConvert.SerializeObject(_selectedPolygon.Geometry);
                foreach (JProperty property in _selectedPolygon.Properties.Properties().OrderBy(prop => prop.Name))
                {
                    if (map.ContainsKey($"{{{{{property.Name}}}}}")) { continue; }
                    map.Add($"{{{{{property.Name}}}}}", property.Value.ToStringSafely(valueIfNull: ""));
                }
            }
            #endregion

            #region Global custom tags
            if (dgvGlobalTags.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvGlobalTags.Rows)
                {
                    string tagName = row.Cells["TagName"].Value.ToStringSafely();
                    string tagValue = row.Cells["TagValue"].Value.ToStringSafely();

                    tagName = $"{{{{{tagName}}}}}";
                    if (map.ContainsKey(tagName)) { continue; }

                    if (tagValue.StartsWith("{{") && tagValue.EndsWith("}}"))
                    {
                        tagValue = tagValue.Replace("{", string.Empty).Replace("}", string.Empty);
                        switch (tagValue.ToLower())
                        {
                            case "date":
                                tagValue = DateTime.Now.ToString("yyyy.MM.dd");
                                break;

                            case "time":
                                tagValue = DateTime.Now.ToString("HH:mm:ss");
                                break;

                            case "datetime":
                                tagValue = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
                                break;

                            case "guid":
                                tagValue = Guid.NewGuid().ToString();
                                break;

                            case string str when str.StartsWith("rnd:"):
                                tagValue = Helpers.GetRandomIntFromDynamicTagValue(tagValue).ToString();
                                break;
                        }
                    }

                    map.Add(tagName, tagValue);
                }
            }
            #endregion

            #region Regex replace & return
            Regex regex = new Regex(string.Join("|", map.Keys.Select(key => Regex.Escape(key))), (ignoreCase ? RegexOptions.IgnoreCase : RegexOptions.None));
            string processedTemplate = regex.Replace(templateData, match => map[match.Value]);
            if (removeOtherTags)
            {
                Regex regexCleanTags = new Regex("{{[a-zA-Z0-9]*}}", RegexOptions.IgnoreCase);
                processedTemplate = regexCleanTags.Replace(processedTemplate, string.Empty);
            }
            return processedTemplate;
            #endregion
        }

        private void TagsSettingsChanged(object sender, EventArgs e)
        {
            LoadMap();
        }

        private void lblGetCurrentMapWindowSize_Click(object sender, EventArgs e)
        {
            _modifiedByCode = true;
            numMapWidth.Value = _frmBrowser.Size.Width;
            numMapHeight.Value = _frmBrowser.Size.Height;
            _modifiedByCode = false;
        }

        private void CheckMapSizeCustomPropertyValue()
        {
            // cand se selecteaza layer/poly
            // verifica daca exista prop asta
            // si arata aici ce valoare are
            if (chkMapSizeCustomProperty.Checked)
            {
                string? propertyValue = _selectedPolygon?.Properties.Get(txtMapSizeCustomProperty.Text.Trim(), chkMapSizeCustomPropertyIgnoreCase.Checked);
                lblMapSizeCustomPropertyValue.Text = propertyValue.ToStringSafely(valueIfNull: string.Empty);
                if (propertyValue.INOE()) { txtMapSizeCustomProperty.BackColor = Color.FromArgb(17, 17, 17); }
                else { txtMapSizeCustomProperty.BackColor = Color.FromArgb(17, 64, 17); }

                // // verifica iar valoarea te custom map size >>> txtMapSizeCustomProperty_TextChanged

                /// altcumva sa arate bine
                /// 

                //if (!propertyValue.INOE())
                //{

                //}
                //else
                //{

                //}
            }
        }

        private void lblGlobalTagsInfo_Click(object sender, EventArgs e)
        {
            ShowMessage($"Global custom tags, are tags that will work with any layer and any polygon selected. {_NL}They are NOT taken from the uMap file; they are application-specific tags, you can define their name and value here and they will be available throughout the session. {_NL.Repeat()}Dynamic values - are like variables that can hold dynamic values that are set when the map is loaded. {_NL}Eg. date/time/datetime/random/etc. {_NL}Click the 'Add' button to see more info.");
        }

        private void btnAddGlobalTag_Click(object sender, EventArgs e)
        {
            using (frmAddTag frmAdd = new frmAddTag(ref dgvGlobalTags))
            {
                this.Opacity = 0.64;
                DialogResult dialogResult = frmAdd.ShowDialog(this);
                this.Opacity = 1;
                if (dialogResult == DialogResult.OK)
                {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    dgvGlobalTags.Rows.Add(frmAdd.Tag.Name, frmAdd.Tag.Value);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    LoadMap();
                }
            }
        }

        private void btnDeleteGlobalTag_Click(object sender, EventArgs e)
        {
            if (dgvGlobalTags.SelectedRows.Count == 0) { return; }
            dgvGlobalTags.Rows.RemoveAt(dgvGlobalTags.SelectedRows[0].Index);
            LoadMap();
        }

        private void btnDeleteAllGlobalTags_Click(object sender, EventArgs e)
        {
            if (dgvGlobalTags.Rows.Count == 0) { return; }
            dgvGlobalTags.Rows.Clear();
            LoadMap();
        }

        private void dgvGlobalTags_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGlobalTags.Rows.Count == 0 || dgvGlobalTags.SelectedRows[0].Cells["TagName"].Value.ToStringSafely().INOE()) { return; }
            Clipboard.Clear();
            Clipboard.SetText($"{{{{{dgvGlobalTags.SelectedRows[0].Cells["TagName"].Value.ToStringSafely()}}}}}");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                SetDefaultOutputDirectory();
            }
            else
            {
                if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
                {
                    _outputPath = folderBrowserDialog.SelectedPath;
                    lblOutput.Text = new DirectoryInfo(_outputPath).Name;
                }
            }
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                Clipboard.Clear();
                Clipboard.SetText(_outputPath);
            }
            else
            {
                if (Directory.Exists(_outputPath)) { Process.Start("explorer.exe", _outputPath); }
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int exportedPolygons = 0;
            Globals.ExportErrors = new Dictionary<string, List<(string polygonName, string error)>>(StringComparer.OrdinalIgnoreCase);

            foreach (TreeNode layerNode in treeView.Nodes)
            {
                if (!layerNode.Checked) { continue; }
                Layer? layer = _uMapData?.Layers.FirstOrDefault(layer => layer.UmapOptions.Name.Equals(layerNode.Name));
                _selectedLayerOptions = layer?.UmapOptions;

                foreach (TreeNode polyNode in layerNode.Nodes)
                {
                    if (!polyNode.Checked) { continue; }
                    _selectedPolygon = layer?.Features.FirstOrDefault(feature => feature.Properties.Get("name").Equals(polyNode.Name));

                    FunctionResponse frLoadMap = new FunctionResponse();
                    this.Invoke(new MethodInvoker(delegate () { frLoadMap = LoadMap(); }));

                    if (frLoadMap.Error)
                    {
                        AddExportLog(_selectedLayerOptions.Name, _selectedPolygon.Properties.Get("name"), frLoadMap.Message);
                        continue; // or stop ? (settings)
                    }

                    Sleep(1500);

                    FunctionResponse frSaveBitmap = new FunctionResponse();
                    this.Invoke(new MethodInvoker(delegate () { frSaveBitmap = SaveBitmap(); }));
                    //frSaveBitmap = SaveBitmap();

                    if (frSaveBitmap.Error)
                    {
                        AddExportLog(_selectedLayerOptions.Name, _selectedPolygon.Properties.Get("name"), frSaveBitmap.Message);
                        continue; // or stop ? (settings)
                    }

                    Sleep(500);

                    exportedPolygons++;
                    backgroundWorker.ReportProgress(exportedPolygons); // map % from current poly / total polys
                }
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int percentage = e.ProgressPercentage.Map(0, _checkedPolygons, 0, 100);
            lblStatus.Text = $"Exported {e.ProgressPercentage}/{_checkedPolygons} ({percentage}%)";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // deblocheaza UI si butoane, deschide folder destinatie. update lblStatus (dupa pune-l in idle)
            lblStatus.Text = "Done";
            if (Globals.ExportErrors.Count > 0)
            {
                // notifica si intreaba daca vrea detalii
            }
        }

        private void AddExportLog(string layer, string polygon, string error)
        {
            if (Globals.ExportErrors.ContainsKey(layer))
            {
                Globals.ExportErrors[layer].Add((polygon, error));
            }
            else
            {
                Globals.ExportErrors.Add(layer, new List<(string, string)>() { (polygon, error) });
            }
        }
    }
}
