using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADFGX_Cloud_Solver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!System.IO.File.Exists("ADFGX_Cloud_Solver.exe.config"))
            {
                System.IO.File.WriteAllText("ADFGX_Cloud_Solver.exe.config", Properties.Resources.ADFGX_Cloud_Solver_exe);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
