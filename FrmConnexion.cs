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
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ControleurMission1.validConnexion(txtIdentifiant.Text, txtMotDePasse.Text));
        }
    }
}
