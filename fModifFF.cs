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
    public partial class fModifFF : Form
    {
        public static bool enForfait;
        public fModifFF(LigneFraisForfait ffModif)
        {
            InitializeComponent();
            LigneFraisForfait ff = ffModif;
            bsFF.DataSource = ffModif;
            
            // Switch the name of the label
            lQuantite.Text = "Quantite :";
            //if ff != null
            if(ff != null)
            {
                tbMois.Text = ff.mois;
                bsMois.DataSource = ff.mois;
                tbQuantite.Text = ff.quantite.ToString();
                bsQuant.DataSource = ff.quantite;
            }
            enForfait = true;
        }
        public fModifFF(LigneFraisHorsForfait ffModif)
        {
            InitializeComponent();
            LigneFraisHorsForfait ff = ffModif;
            bsFF.DataSource = ffModif;
            bsMois.DataSource = ff;
            // Switch the name of the label
            lQuantite.Text = "Montant :";
            //if ff != null
            if (ff != null)
            {
                tbQuantite.Text = ff.montant.ToString();
                bsMont.DataSource = ff.montant;
                tbMois.Text = ff.mois;
                bsMois.DataSource = ff.mois;
            }
            enForfait = false;
        }


        private void FModifFF_Load(object sender, EventArgs e)
        {
        }

        private void BtValider_Click(object sender, EventArgs e)
        {
            if (enForfait)
            {
                if(controleurMission3.updateLFF((LigneFraisForfait)bsFF.DataSource, tbMois.Text, int.Parse(tbQuantite.Text)))
                {
                    controleurMission3.LFF.mois = tbMois.Text;
                    controleurMission3.LFF.quantite = int.Parse(tbQuantite.Text);
                    controleurMission3.savechange();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur !");
                }
            }
            else
            {
                if(controleurMission3.updateLFHF((LigneFraisHorsForfait)bsFF.DataSource, tbMois.Text, int.Parse(tbQuantite.Text)))
                {
                    controleurMission3.LFHF.mois = tbMois.Text;
                    controleurMission3.LFHF.montant = int.Parse(tbQuantite.Text);
                    controleurMission3.savechange();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur !");
                }
            }
        }
    }
}
