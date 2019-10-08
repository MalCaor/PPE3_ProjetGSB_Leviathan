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
        public testCo()
        {
            InitializeComponent();

            bsV.DataSource = controleurMission2.listeVisiteurs();
            dgvV.DataSource = bsV.DataSource;
        }

        private void DgvV_SelectionChanged(object sender, EventArgs e)
        {
            Form leVisiteur = new Form2();
            leVisiteur.Show();
            //static Visiteur Visit = sender...;
        }
    }
}
