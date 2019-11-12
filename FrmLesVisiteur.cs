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
            if (ControleurMission1.getVerifAdmin())
            {
                btnGestionLabo.Visible = true;
            }
            if(ControleurMission1.verifGestionSecteur())
            {
                btnGestionSecteur.Visible = true;
            }
            if(ControleurMission1.verifGestionRegion())
            {
                btnGestionRegion.Visible = true;
            }
        }

        private void BsVisiteurs_CurrentChanged(object sender, EventArgs e)
        {
            string choix = (string)bsVisiteurs.Current;
            if(choix == "Global")
            {
                List<Laboratoire>LesLabos = ControleurMission1.listeLaboratoire();
                string messageGlobal = "";
                
                foreach(Laboratoire labo in LesLabos)
                {
                    if(labo.nomLabo == "Autres laboratoires ")
                    {
                        messageGlobal += "Membres des autres Laboratoires : ";
                    }
                    else
                    {
                        messageGlobal += "Membres du Laboratoire " + labo.nomLabo + " : ";
                    }
                    List<Visiteur> lesVisiteurs = labo.Visiteur.ToList();
                    foreach(Visiteur visiteur in lesVisiteurs)
                    {
                        messageGlobal += "\n\t-" + visiteur.nom + " " + visiteur.prenom;
                    }
                    messageGlobal += "\n\n";
                }

                rtbListeSelection.Text = messageGlobal;
            }

            if(choix == "Par Secteur")
            {
                List<Secteur>LesSecteurs = ControleurMission1.listeSecteur();
                string messageSecteur = "";
                
                foreach(Secteur secteur in LesSecteurs)
                {
                    messageSecteur += "Responsable du secteur " + secteur.libSecteur + " : " + secteur.Visiteur.nom + " " + secteur.Visiteur.prenom;
                    List<Region> lesRegions = secteur.Region.ToList();
                    foreach(Region region in lesRegions)
                    {
                        messageSecteur += "\n\tResponsable de la Région " + region.libRegion + " : " + region.Visiteur.nom + " " + region.Visiteur.prenom;
                        List<Visiteur> lesVisiteurs = region.Visiteur1.ToList();
                        foreach(Visiteur visiteur in lesVisiteurs)
                        {
                            if (visiteur.nom != region.Visiteur.nom && visiteur.prenom != region.Visiteur.prenom)
                            {
                                messageSecteur += "\n\t\t- " + visiteur.nom + " " + visiteur.prenom;
                            }
                        }
                    }
                    messageSecteur += "\n\n";
                }

                rtbListeSelection.Text = messageSecteur;
            }

            if(choix == "Par Région")
            {
                List<Region> LesRegions = ControleurMission1.listeRegion();
                string messageRegion = "";
                
                foreach(Region region in LesRegions)
                {
                    messageRegion += "Responsable de la Région " + region.libRegion + " : " + region.Visiteur.nom + " " + region.Visiteur.prenom;
                    List<Visiteur> lesVisiteursRegions = region.Visiteur1.ToList();
                    foreach (Visiteur visiteur in lesVisiteursRegions)
                    {
                        if (visiteur.nom != region.Visiteur.nom && visiteur.prenom != region.Visiteur.prenom)
                        {
                            messageRegion += "\n\t- " + visiteur.nom + " " + visiteur.prenom;
                        }
                    }
                    messageRegion += "\n\n";
                }

                rtbListeSelection.Text = messageRegion;
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGestionSecteur_Click(object sender, EventArgs e)
        {
            Form GestionSecteur = new FrmGestionSecteur();
            GestionSecteur.Show();
        }

        private void BtnGestionRegion_Click(object sender, EventArgs e)
        {
            Form GestionRegion = new FrmGestionRegion();
            GestionRegion.Show();
        }
    }
}
