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
        static fichefrais ff;
        static string idvis;
        public fAjoutLigneFF(string idvisit, fichefrais FF)
        {
            InitializeComponent();
            idvis = idvisit;
            ff = FF;
            //ComboBox
            bsFF.DataSource = controleurMission3.listFF();      
            cbFF.ValueMember = "id";
            cbFF.DisplayMember = "libelle";
            cbFF.DataSource = bsFF.DataSource;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            string idV = idvis;
            string mois = tbMois.Value.ToString() + tbAnnee.Value.ToString();
            string idFF = ((FraisForfait)bsFF.Current).id;
            int qte = Convert.ToInt32(Math.Round(tbQuan.Value, 0)); // Get the value of a NumUpDowb is just ridiculous
            // add new ff
            LigneFraisForfait lff = new LigneFraisForfait();
            lff.fichefrais = ff;
            lff.mois = mois;
            lff.idVisiteur = idV;
            lff.idFraisForfait = idFF;
            lff.quantite = qte;
            
            if(controleurMission3.addLFF(lff))
            {
                this.Close();
            }
        }
    }
}
