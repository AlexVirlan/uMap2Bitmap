using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uMap2Bitmap.Utilities;

namespace uMap2Bitmap.Forms
{
    public partial class frmStart : Form
    {
        #region Variables
        private int _loadIndex = 0;
        private bool _loadReverse = false;
        private frmMain? _frmMain = null;
        #endregion

        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            tmrLoading.Interval = 100;
            tmrLoading.Start();
        }

        private void frmStart_Shown(object sender, EventArgs e)
        {
            Sleep(2000);
            _frmMain = new frmMain();
            _frmMain.LoadComplete += LoadComplete;
            _frmMain.Show();
        }

        public void LoadComplete(object? sender, EventArgs e)
        {
            Sleep(2000);
            this.Hide();
            _frmMain?.ShowWindow();
            this.Close();
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

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            if (_loadReverse) { _loadIndex--; }
            else { _loadIndex++; }

            if (_loadIndex == 6) { _loadReverse = true; }
            if (_loadIndex == 0) { _loadReverse = false; }

            string dots = "• ".Repeat(_loadIndex);
            lblLoading.Text = dots + "  l o a d i n g   " + dots;
        }

    }
}
