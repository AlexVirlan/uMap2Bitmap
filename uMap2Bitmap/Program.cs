using uMap2Bitmap.Forms;
using uMap2Bitmap.Utilities;

namespace uMap2Bitmap
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex mutex = new Mutex(true, "uMap2Bitmap", out bool newRun);
            if (!newRun) { return; }

            ApplicationConfiguration.Initialize();
            List<string> args = Environment.GetCommandLineArgs().Skip(1).ToList();
            Globals.Args = args?.Count == 0 ? null : args;

            frmStart frmStart = new frmStart();
            frmStart.Show();
            Application.Run();

            //Application.Run(new frmMain());
        }
    }
}