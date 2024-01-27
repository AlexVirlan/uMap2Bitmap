using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uMap2Bitmap.Controls
{
    class CustomLabel : Label
    {
        [Category("Appearance")]
        public Color HoverColor { get; set; }

        private Color OriginalForeColor { get; set; }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (HoverColor.IsEmpty) { HoverColor = this.ForeColor; }
            OriginalForeColor = this.ForeColor;
            this.ForeColor = HoverColor;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.ForeColor = OriginalForeColor;
            base.OnMouseLeave(e);
        }
    }
}
