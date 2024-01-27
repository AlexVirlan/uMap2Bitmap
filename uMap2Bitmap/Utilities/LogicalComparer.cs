using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace uMap2Bitmap.Utilities
{
    public class LogicalComparer : IComparer<string>
    {
        #region DLL imports
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern int StrCmpLogicalW(string x, string y);
        #endregion

        public int Compare(string x, string y)
        {
            return StrCmpLogicalW(x, y);
        }
    }
}
