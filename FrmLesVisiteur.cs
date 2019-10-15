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
    public partial class FrmLesVisiteur : Form
    {
        public FrmLesVisiteur()
        {
            InitializeComponent();
        }

        private void FrmLesVisiteur_Load(object sender, EventArgs e)
        {
            bsVisiteurs.DataSource = ControleurMission1.ListeChoixVisualisation();
            cboChoixAffichage.DataSource = bsVisiteurs;
        }

        private void BsVisiteurs_CurrentChanged(object sender, EventArgs e)
        {
            Visiteur lesInfos = ControleurMission1.LesInfosVisiteur();
            string choix = (string)bsVisiteurs.Current;
            if(choix == "Global")
            {
                
            }
            if(choix == "Par secteur")
            {

            }
            if(choix == "Par Région")
            {
                List<Region> LesRegion= ControleurMission1.listeRegion();
                List<Visiteur> lesVisiteurs = ControleurMission1.listeVisiteur();
                string test = "";
                foreach(Region region in LesRegion)
                {
                    test += region.libRegion + "\n";
                    foreach(Visiteur visiteur in lesVisiteurs)
                    {
                        List<Region> LesRegionTravail = lesInfos.Region1.ToList();
                        foreach(Region regionlbl in LesRegionTravail)
                        {
                            if(regionlbl.libRegion == region.libRegion)
                            {
                                test += visiteur.nom + "\n";
                            }
                        }
                    }
                }
                lblTest1.Text = test;
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
