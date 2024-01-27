using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uMap2Bitmap.Entities;
using uMap2Bitmap.Utilities;

namespace uMap2Bitmap.Forms
{
    public partial class frmBrowser : Form
    {
        #region Variables
        Point? _parentLocation = null;
        Size? _parentSize = null;
        public event EventHandler BrowserInitializationCompleted;

        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HTCAPTION = 0x2;
        #endregion

        #region DLL imports
        //[DllImport("User32.dll")]
        //public static extern bool ReleaseCapture();

        //[DllImport("User32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        public frmBrowser(Point? parentLocation = null, Size? parentSize = null)
        {
            InitializeComponent();
            _parentLocation = parentLocation;
            _parentSize = parentSize;
        }

        private async Task InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
        }

        private async void frmBrowser_Load(object sender, EventArgs e)
        {
            await InitializeAsync();
            SetWindowTitle();

            if (_parentLocation is not null && _parentSize is not null)
            {
                this.Location = (Point)_parentLocation + new Size(((Size)_parentSize).Width, 0);
            }
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
            Visible = true;
            ShowInTaskbar = true;
            Opacity = 1;
            this.Refresh();
        }

        public FunctionResponse LoadHTML(string htmlData, Size? windowSize = null, Color? defaultBackgroundColor = null)
        {
            try
            {
                if (windowSize is not null) { this.Size = (Size)windowSize; }
                if (defaultBackgroundColor is not null) { webView.DefaultBackgroundColor = (Color)defaultBackgroundColor; }
                SetWindowTitle();
                webView.NavigateToString(htmlData);
                this.Show();
                return new FunctionResponse();
            }
            catch (Exception ex)
            {
                return new FunctionResponse(ex);
            }
        }

        public void LoadDefault(bool hideWindow = false)
        {
            webView.Stop();
            webView.NavigateToString("<p style=\"color: #ffffff;\">To load the map, select a polygon, then a template.</p>");
            if (hideWindow) { this.Hide(); }
        }

        private void frmBrowser_Resize(object sender, EventArgs e)
        {
            SetWindowTitle();
        }

        private void SetWindowTitle()
        {
            this.Text = $"uMap2Bitmap - Map window (W: {this.Width}, H:{this.Height})";
        }

        private void frmBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) { e.Cancel = true; }
        }

        private void webView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            BrowserInitializationCompleted.Invoke(this, EventArgs.Empty);
        }

        private void frmBrowser_Shown(object sender, EventArgs e)
        {

        }

    }
}
