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
            if (txtTagName.Text.Trim().INOE()) { return (false, "The tag name is empty."); }
            foreach (DataGridViewRow row in _dgvGlobalTags.Rows)
            {
                if (row.Cells["TagName"].Value.ToStringSafely().Equals(txtTagName.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                { return (false, "This tag name is already used."); }
            }

            // globals - polysprops

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
            MessageBox.Show(this, $"The format is {{X}} where X is the dynamic value name. They are case-insensitive and their names are predetermined. Select one of them to insert it as a tag value. {Environment.NewLine.Repeat()}The 'custom integers' is a special one because you can specify the min and max integers, the format is {{{{rnd:X-Y}}}} where X is the min integer and Y is the max integer, eg.: {{{{rnd:10-100}}}}", "Dynamic values info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
