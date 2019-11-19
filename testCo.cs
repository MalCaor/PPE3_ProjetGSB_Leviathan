using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_Leviathan
{
    public partial class testCo : Form
    {
        private bool close;
        private static Visiteur v;
        public testCo()
        {
            InitializeComponent();

            bsV.DataSource = controleurMission2.listeVisiteurs();
            dgvV.DataSource = bsV.DataSource;
        }
        private void TestCo_Load(object sender, EventArgs e)
        {
            /*bsV.DataSource = controleurMission2.listeVisiteurs();
            dgvV.DataSource = bsV.DataSource;*/
        }

        private void TestCo_FormClosed(object sender, FormClosedEventArgs e)
        {
            close = true;
        }

        private void DgvV_SelectionChanged(object sender, EventArgs e)
        {
            /*Form leVisiteur = new Form2();
            leVisiteur.Show();
            Visiteur v = (Visiteur)dgvV.Sele;*/
        }


        /*private void BsV_CurrentChanged(object sender, EventArgs e)
        {
            if (close == true)
            {

            }
            else
            {
                Visiteur v = (Visiteur)bsV.Current;
                Form leVisiteur = new Form2();
                leVisiteur.Show();
            }
        }*/



        /*public static object<Visiteur> testVisiteur()
        {
            var lQuery = maConnexion.Visiteur.ToList()
                            .Where(x =>idNation == a13)
                            .Select(x => new { x. , x. ...})
                            .OrderBy(x => x.)
        }*/

        /*public static Object CompositeurParNationalite(int idNation)
        {
            var LQuery = maConnexion.COMPOSITEUR.ToList()
                           .Where(x => x.idNation == idNation)
                           .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque })
                           .OrderBy(x => x.nomCompositeur);
            return LQuery.ToList();

        }*/

    }
}
