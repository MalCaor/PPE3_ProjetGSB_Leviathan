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
    public partial class FrmModifRapport : Form
    {
        public FrmModifRapport()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnValid_Click(object sender, EventArgs e)
        {
            //Vérification de la présence du médecin
            if (btnMedecin.Checked)
            {
                //Récupération du médecin sélectionner et Ajout à la requête

            }
            else
            {
                //Vérification de la présence d'un remplacent
                if(btnRemplacent.Checked)
                {
                    //Récupération du médecin sélectionner et Ajout à la requête
                                         /*MEDECIN M = cboMedecin.SelectedItem.*/
                    //Récupération des informations concernant le remplacent du médecin et Ajout à la requête
                    
                }
            }

            DateTime Date = dtpDate.Value;

            

        }

        private void FrmModifRapport_Load(object sender, EventArgs e)
        {

        }
    }
}
