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


    }
}
