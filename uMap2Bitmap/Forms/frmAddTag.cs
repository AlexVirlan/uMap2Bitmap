using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using uMap2Bitmap.Entities;
using uMap2Bitmap.Utilities;

namespace uMap2Bitmap.Forms
{
    public partial class frmAddTag : Form
    {
        #region Variables
        public Tag? Tag;
        private DataGridView _dgvGlobalTags;
        private string _NL = Environment.NewLine;
        #endregion

        public frmAddTag(ref DataGridView dataGridView)
        {
            InitializeComponent();
            _dgvGlobalTags = dataGridView;
        }

        private void frmAddTag_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (bool isValid, string validMessage) = IsValidTag();
            if (!isValid)
            {
                MessageBox.Show(this, validMessage, "Global tag is invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tagName = txtTagName.Text.Trim();
            tagName = tagName.Replace("{", string.Empty).Replace("}", string.Empty);

            Tag = new Tag(tagName, txtTagValue.Text.Trim());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private (bool, string) IsValidTag()
        {
            string tagName = txtTagName.Text.Trim();
            if (tagName.INOE()) { return (false, "The tag name is empty."); }
            foreach (DataGridViewRow row in _dgvGlobalTags.Rows)
            {
                if (row.Cells["TagName"].Value.ToStringSafely().Equals(tagName, StringComparison.OrdinalIgnoreCase))
                { return (false, "This tag name is already used."); }
            }

            if (Globals.CustomPropsStats.ContainsKey(tagName))
            {
                return (false, "There are some polygons that have properties with this name. Therefore, this tag name can't be used." + _NL +
                    "Press the 'Check in polygons' label to see where it's used.");
            }

            string tagValue = txtTagValue.Text.Trim();
            if (tagValue.INOE()) { return (false, "The tag value is empty."); }
            if (tagValue.Equals("{{rnd:X-Y}}")) { return (false, "Please replace the X and Y letters with integers!"); }
            if (tagValue.StartsWith("{{rnd:") && tagValue.EndsWith("}}"))
            {
                if (!new Regex(@"{{rnd:\d+-\d+}}").Match(tagValue).Success)
                {
                    return (false, "The format for a custom random integer is not valid.");
                }
            }

            return (true, string.Empty);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblAddDynamicValue_Click(object sender, EventArgs e)
        {
            cmsDynamicValues.Show(Cursor.Position);
        }

        private void moreInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, $"The format is {{X}} where X is the dynamic value name. They are case-insensitive and their names are predetermined. Select one of them to insert it as a tag value. {_NL.Repeat()}The 'custom integers' is a special one because you can specify the min and max integers, the format is {{{{rnd:X-Y}}}} where X is the min integer and Y is the max integer, eg.: {{{{rnd:10-100}}}}", "Dynamic values info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuAddDynamicValue(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            string value = menuItem.Tag.ToStringSafely();
            txtTagValue.Text = value;
            if (value.Equals("{{rnd:X-Y}}"))
            {
                MessageBox.Show(this, "Please don't forget to replace the X and Y letters with integers!",
                    "Custom integers info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblCheckTagName_Click(object sender, EventArgs e)
        {
            string tagName = txtTagName.Text.Trim();
            if (Globals.CustomPropsStats.ContainsKey(tagName))
            {
                int polysCount = 0;
                int layersCount = Globals.CustomPropsStats[tagName].Values.Where(w => w.Count > 0).Count();
                Globals.CustomPropsStats[tagName].Values.Select(s => s).ToList().ForEach(f => polysCount += f.Count);

                string polys = polysCount == 1 ? "one polygon" : $"{polysCount} polygons";
                string layers = layersCount == 1 ? "one layer" : $"{layersCount} layers";

                DialogResult drShowDetails = MessageBox.Show(this, $"This property name IS used in {polys}, from {layers}." + _NL +
                    "Do you want to see exactly where?" + _NL.Repeat() +
                    "Note: hold down CTRL while clicking yes to see the data in JSON format. Otherwise, it will be in a more friendly human-readable format.",
                    "Global tag name check", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (drShowDetails == DialogResult.Yes)
                {
                    Dictionary<string, List<string>> tagUsageDetails = Globals.CustomPropsStats[tagName].Where(w => w.Value.Count > 0).ToDictionary();
                    if (ModifierKeys.HasFlag(Keys.Control))
                    {
                        Helpers.ShowNotepadMessage(JsonConvert.SerializeObject(tagUsageDetails, Formatting.Indented), "Tag name usage");
                    }
                    else
                    {
                        string result = @$"The property ""{tagName}"" is used in:" + _NL.Repeat();
                        foreach (KeyValuePair<string, List<string>> kvpLP in tagUsageDetails)
                        {
                            result += $"• {kvpLP.Key}" + _NL + string.Join(_NL, kvpLP.Value) + _NL.Repeat();
                        }
                        Helpers.ShowNotepadMessage(result, "Tag name usage");
                    }
                }
            }
            else
            {
                MessageBox.Show(this, $"This name is NOT used in any polygon's properties. {_NL}You're free to use it.",
                    "Global tag name check", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
