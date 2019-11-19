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
        static string idvis;
        public fAjoutLigneFF(string idvisit)
        {
            InitializeComponent();
            idvis = idvisit;
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
            LigneFraisForfait ff = new LigneFraisForfait();
            ff.mois = mois;
            ff.idVisiteur = idV;
            ff.idFraisForfait = idFF;
            ff.quantite = qte;
            
            if(controleurMission3.addLFF(ff))
            {
                this.Close();
            }
        }
    }
}
