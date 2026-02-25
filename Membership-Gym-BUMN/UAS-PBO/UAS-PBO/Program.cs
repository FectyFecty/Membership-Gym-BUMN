using System;
using System.Windows.Forms;

namespace UAS_PBO
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Biar bisa buka visual styles winforms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Jalanin form main
            Application.SetHighDpiMode(HighDpiMode.SystemAware); //tambahin DPI Awareness
            Application.Run(new MainForm());
        }
    }
}
