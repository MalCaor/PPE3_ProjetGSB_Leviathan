using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_Leviathan
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ControleurMission1.init();
            //controleurMission2.init();
            //controleurMission3.init();
            Application.Run(new FrmConnexion());
            //Application.Run(new testCo());
            //corig
        }
    }
}
