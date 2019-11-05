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
                string messageGlobal = "";



                rtbListeSelection.Text = messageGlobal;
            }
            if(choix == "Par Secteur")
            {
                List<Secteur>LesSecteurs = ControleurMission1.listeSecteur();
                List<Visiteur> lesVisiteurSecteur = ControleurMission1.listeVisiteur();
                string messageSecteur = "";
                string responsableSecteur = "";
                string dernierAjout = "";
                foreach (Secteur secteur in LesSecteurs)
                {
                    foreach(Visiteur visiteur in lesVisiteurSecteur)
                    {
                        if(secteur.idVisiteur == visiteur.idVisiteur)
                        {
                            responsableSecteur = visiteur.idVisiteur;
                            messageSecteur += "Secteur "+secteur.libSecteur + "\n|--Responsable de Secteur : " + visiteur.nom + " " + visiteur.prenom + "\n|--Coordonnées : " + visiteur.rue + " " + visiteur.cp + " " + visiteur.ville;
                        }
                    }
                    foreach(Visiteur visiteur in lesVisiteurSecteur)
                    {
                        List<Region> LesRegionTravailSecteur = visiteur.Region1.ToList();
                        List<Region> LesRegion = ControleurMission1.listeRegion();
                        foreach(Region regionTravail in LesRegionTravailSecteur)
                        {
                            foreach(Region region in LesRegion)
                            {
                                if(region.idRegion == regionTravail.idRegion)
                                {
                                    if(regionTravail.idSecteur == secteur.idSecteur && visiteur.idVisiteur != responsableSecteur && visiteur.idVisiteur != dernierAjout)
                                    {
                                        messageSecteur += "\n|\n|----------" + visiteur.nom + " " + visiteur.prenom;
                                        dernierAjout = visiteur.idVisiteur;
                                    }
                                }
                            }
                        }
                    }
                    messageSecteur += "\n\n";
                }
                //lblTest1.Text = messageSecteur;
                rtbListeSelection.Text = messageSecteur;
            }
            if(choix == "Par Région")
            {
                List<Region> LesRegion= ControleurMission1.listeRegion();
                List<Visiteur> lesVisiteurs = ControleurMission1.listeVisiteur();
                string messageRegion = "";
                string responsableRegion = "";
                foreach(Region region in LesRegion)
                {
                    messageRegion += region.libRegion;
                    foreach(Visiteur visiteur in lesVisiteurs)
                    {
                        List<Region> LesRegionResponsable = visiteur.Region.ToList();
                        foreach(Region regionResponsable in LesRegionResponsable)
                        {
                            if(regionResponsable.libRegion == region.libRegion)
                            {
                                messageRegion += "\n|--Responsable de la Région : " + visiteur.nom + " " + visiteur.prenom + "\n|--Coordonnées : " + visiteur.rue + " " + visiteur.cp + " " + visiteur.ville;
                                responsableRegion = visiteur.idVisiteur;
                            }
                        }
                    }

                    foreach (Visiteur visiteur in lesVisiteurs)
                    {
                        List<Region> LesRegionTravail = visiteur.Region1.ToList();
                        foreach (Region regionlbl in LesRegionTravail)
                        {
                            if (regionlbl.libRegion == region.libRegion && visiteur.idVisiteur != responsableRegion)
                            {
                                messageRegion += "\n|\n|----------" + visiteur.nom + " " + visiteur.prenom;
                            }
                        }
                    }



                    messageRegion += "\n\n";
                }
                //lblTest1.Text = messageRegion;
                rtbListeSelection.Text = messageRegion;
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
