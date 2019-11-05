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
<<<<<<< HEAD
            //ControleurMission1.init();
            controleurMission2.init();
            //controleurMission3.init();

            Application.Run(new Form2());
            //Application.Run(new testCo());
            // test
=======
            ControleurMission1.init();
            //controleurMission3.init();
            Application.Run(new FrmConnexion());
>>>>>>> 1b26c6c1f73cd6acf92f8bde92620eef4b3700bf
        }
    }
}
