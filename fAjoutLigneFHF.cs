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
    public partial class fAjoutLigneFHF : Form
    {
        static string idvis;
        public fAjoutLigneFHF(string idvisit)
        {
            InitializeComponent();
            idvis = idvisit;
            //ComboBox
            bsFF.DataSource = controleurMission3.libFF();
            cbFF.DataSource = bsFF.DataSource;
        }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnAj_Click(object sender, EventArgs e)
        {
            string idV = idvis;
            string mois = tbMois.ToString() + tbAnnee.ToString();
            string idFF = cbFF.Text;
            int qte = Convert.ToInt32(Math.Round(tbQuan.Value, 0)); // Get the value of a NumUpDowb is just ridiculous
        }
    }
}
