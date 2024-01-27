﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uMap2Bitmap.Controls
{
    class CustomTreeView : TreeView
    {
        protected override void WndProc(ref Message m)
        {
            // Filter WM_LBUTTONDBLCLK
            if (m.Msg != 0x203) base.WndProc(ref m);
        }
    }
}
