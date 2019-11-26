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
    public partial class FrmInscription : Form
    {
        public FrmInscription()
        {
            InitializeComponent();
        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {
            cboVisiteur.ValueMember = "idVisiteur";
            cboVisiteur.DisplayMember = "prenom" + "nom";

        }
    }
}
