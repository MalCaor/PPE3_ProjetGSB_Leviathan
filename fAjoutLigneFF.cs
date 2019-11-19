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
    public partial class fAjoutLigneFF : Form
    {
        public fAjoutLigneFF()
        {
            InitializeComponent();

            //ComboBox
            bsFF.DataSource = controleurMission3.libFF();
            cbFF.DataSource = bsFF.DataSource;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            string Mois = tbMois.ToString()+tbAnnee.ToString();

        }
    }
}
