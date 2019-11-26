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
    public partial class FrmGestionSecteur : Form
    {
        public FrmGestionSecteur()
        {
            InitializeComponent();
        }

        private void FrmGestionSecteur_Load(object sender, EventArgs e)
        {
            cboGestionSecteur.ValueMember = "idSecteur";
            cboGestionSecteur.DisplayMember = "libSecteur";
            bsGestionSecteur.DataSource = ControleurMission1.leVisiteur.Secteur.ToList(); 
            cboGestionSecteur.DataSource = bsGestionSecteur;
            Secteur s = (Secteur)bsGestionSecteur.Current;
            cboRegionPourResponsabilite.ValueMember = "idRegion";
            cboRegionPourResponsabilite.DisplayMember = "libRegion";
            cboRegionPourResponsabilite.DataSource = s.Region.ToList();

            //On verifie si la personne connecté est toujours responsable de 
            List<Secteur>lesSecteurDeLaCombo = ControleurMission1.leVisiteur.Secteur.ToList();
            int nbSecteur = lesSecteurDeLaCombo.Count();
            int nbTrue = 0;
            foreach(Secteur secteurCombo in lesSecteurDeLaCombo)
            {
                if(secteurCombo.Visiteur.idVisiteur != ControleurMission1.leVisiteur.idVisiteur)
                {
                    nbTrue += 1;
                }
            }
            if(nbTrue == nbSecteur)
            {
                this.Close();
            }
        }

        private void BsGestionSecteur_CurrentChanged(object sender, EventArgs e)
        {
            Secteur s = (Secteur)bsGestionSecteur.Current;
            List<Region> LesRegionsSecteur = s.Region.ToList();
            List<Visiteur> dgvValue = new List<Visiteur>();
            lblResponsableRegionsActuel.Text = "Resposable de Région :\n";
            dgvValue.Add(s.Visiteur);
            foreach(Region region in LesRegionsSecteur)
            {
                dgvValue.Add(region.Visiteur);
                List<Visiteur> lesVisiteursRegions = region.Visiteur1.ToList();
                foreach(Visiteur visiteur in lesVisiteursRegions)
                {
                    if(!dgvValue.Contains(visiteur))
                    {
                        dgvValue.Add(visiteur);
                    }
                }
                lblResponsableRegionsActuel.Text += "\t"+region.libRegion + " : " + region.Visiteur.nom + " " + region.Visiteur.prenom+"\n";
            }
            bsVisiteur.DataSource = dgvValue;
            dgvVisiteurGestion.DataSource = bsVisiteur;
            dgvVisiteurGestion.Columns[0].Visible = false;
            dgvVisiteurGestion.Columns[1].Visible = false;
            dgvVisiteurGestion.Columns[8].Visible = false;
            dgvVisiteurGestion.Columns[9].Visible = false;
            //dgvVisiteurGestion.Columns[10].Visible = false;
            //dgvVisiteurGestion.Columns[11].Visible = false;
            dgvVisiteurGestion.Columns[12].Visible = false;
            dgvVisiteurGestion.Columns[13].Visible = false;
            dgvVisiteurGestion.Columns[14].Visible = false;
            dgvVisiteurGestion.Columns[15].Visible = false;
            dgvVisiteurGestion.Columns[16].Visible = false;
            dgvVisiteurGestion.Columns[17].Visible = false;
            lblResponsable.Text = "Responsable du secteur " + s.libSecteur + " : " + s.Visiteur.nom + " " + s.Visiteur.prenom;
        }
        private void BsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            Visiteur v = (Visiteur)bsVisiteur.Current;
            try
            {
                lblResponsableRegion.Text = "Nommer " + v.nom.ToString() + " " + v.prenom + " responsable de la région :";
                lblCurrentVisiteur.Text = v.nom.ToString() + " " + v.prenom;
            }
            catch(Exception ex)
            {
                MessageBox.Show("erreur");
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //inutile, ne pas faire attention
        }

        private void BtnRendreInactif_Click(object sender, EventArgs e)
        {
            Visiteur v = (Visiteur)bsVisiteur.Current;
            if(v.actif != 0 && v.dateFinEmbauche == null)
            {
                v.actif = 0;
            }
            ControleurMission1.SaveChanges();
            FrmGestionSecteur_Load(sender, e);
        }

        private void BtnRendreActif_Click(object sender, EventArgs e)
        {
            Visiteur v = (Visiteur)bsVisiteur.Current;
            if (v.actif != 1 && v.dateFinEmbauche == null)
            {
                v.actif = 1;
            }
            ControleurMission1.SaveChanges();
            FrmGestionSecteur_Load(sender, e);
        }

        private void BtnValiderResponsable_Click(object sender, EventArgs e)
        {
            Visiteur v = (Visiteur)bsVisiteur.Current;
            Secteur s = (Secteur)bsGestionSecteur.Current;
            List<Region> lesRegions = s.Region.ToList();
            foreach(Region region in lesRegions)
            {
                if(region == cboRegionPourResponsabilite.SelectedItem && v.actif == 1 && v.dateFinEmbauche == null)
                {
                    region.Visiteur = v;
                }
            }
            ControleurMission1.SaveChanges();
            FrmGestionSecteur_Load(sender, e);
        }

        private void BtnMettreFinContrat_Click(object sender, EventArgs e)
        {
            if(rtbMotifFinContrat.Text == "")
            {
                MessageBox.Show("Erreur, saisir le motif");
            }
            else
            {
                //MessageBox.Show("ok");
                Visiteur v = (Visiteur)bsVisiteur.Current;
                Secteur s = (Secteur)bsGestionSecteur.Current;
                List<Region> LesRegionsSecteurs = s.Region.ToList();
                List<Region> lesRegions = v.Region1.ToList();
                foreach (Region region in lesRegions)
                {
                    foreach (Region regionSecteur in LesRegionsSecteurs)
                    {
                        if (region.idRegion == regionSecteur.idRegion)
                        {
                            v.Region1.Remove(region);
                        }
                    }
                }
                v.dateFinEmbauche = dtpDateFinContrat.Value;
                v.actif = 1;
                ControleurMission1.SaveChanges();
                FrmGestionSecteur_Load(sender, e);
            }
        }

        private void VerifResponsable()
        {
            List<Secteur> LesSecteursVisiteur = ControleurMission1.leVisiteur.Secteur.ToList();
            Secteur s = (Secteur)bsGestionSecteur.Current;
            foreach (Secteur secteurVisiteur in LesSecteursVisiteur)
            {
                if(secteurVisiteur.idSecteur != s.idSecteur)
                {
                    this.Close();
                }
            }
        }
    }
}
