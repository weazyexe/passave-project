using System;
using System.Windows.Forms;

namespace Passave
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 1)
                Application.Run(new MainForm(args[0]));
            else Application.Run(new MainForm());
        }
    }
}
