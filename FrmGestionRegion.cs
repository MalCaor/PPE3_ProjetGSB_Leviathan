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
    public partial class FrmGestionRegion : Form
    {
        public FrmGestionRegion()
        {
            InitializeComponent();
        }

        private void FrmGestionRegion_Load(object sender, EventArgs e)
        {
            cboGestionRegion.ValueMember = "idRegion";
            cboGestionRegion.DisplayMember = "libRegion";
            bsGestionRegion.DataSource = ControleurMission1.leVisiteur.Region.ToList();
            cboGestionRegion.DataSource = bsGestionRegion;
            //lblResponsable.Text = ControleurMission1.leVisiteur.nom + " " + ControleurMission1.leVisiteur.prenom;

            //VerifResponsable();
        }

        private void BsGestionRegion_CurrentChanged(object sender, EventArgs e)
        {
            Region r = (Region)bsGestionRegion.Current;
            List<Visiteur> dgvVisiteur = new List<Visiteur>();
            dgvVisiteur.Add(r.Visiteur);
            List<Visiteur> LesVisiteurRegion = r.Visiteur1.ToList();
            foreach(Visiteur visiteur in LesVisiteurRegion)
            {
                if (!(dgvVisiteur.Contains(visiteur)))
                {
                    dgvVisiteur.Add(visiteur);
                }
            }
            bsVisiteur.DataSource = dgvVisiteur;
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
            lblResponsable.Text = "Responsable de la Region " + r.libRegion + " : " + r.Visiteur.prenom + " " + r.Visiteur.nom;
        }

        private void BsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            Visiteur v = (Visiteur)bsVisiteur.Current;
            try
            {
                lblCurrentVisiteur.Text = "Visiteur "+v.nom.ToString() + " " + v.prenom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur");
            }
        }

        private void BtnRendreActif_Click(object sender, EventArgs e)
        {
            Visiteur v = (Visiteur)bsVisiteur.Current;
            if (v.actif != 1 && v.dateFinEmbauche == null)
            {
                v.actif = 1;
            }
            ControleurMission1.SaveChanges();
            FrmGestionRegion_Load(sender, e);
        }

        private void BtnRendreInactif_Click(object sender, EventArgs e)
        {
            Visiteur v = (Visiteur)bsVisiteur.Current;
            if (v.actif != 0 && v.dateFinEmbauche == null)
            {
                v.actif = 0;
            }
            ControleurMission1.SaveChanges();
            FrmGestionRegion_Load(sender, e);
        }



        private void VerifResponsable()
        {
            List<Region> LesRegion = ControleurMission1.leVisiteur.Region.ToList();
            Region r = (Region)bsGestionRegion.Current;
            foreach (Region region in LesRegion)
            {
                if (region.idRegion != r.idRegion)
                {
                    this.Close();
                }
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMettreFinContrat_Click(object sender, EventArgs e)
        {
            if (rtbMotifFinContrat.Text == "")
            {
                MessageBox.Show("Erreur, saisir le motif");
            }
            else
            {
                //MessageBox.Show("ok");
                Visiteur v = (Visiteur)bsVisiteur.Current;
                Region r = (Region)bsGestionRegion.Current;
                List<Region> lesRegions = v.Region1.ToList();
                    foreach (Region region in lesRegions)
                    {
                        if (r.idRegion == region.idRegion)
                        {
                            v.Region1.Remove(r);
                        }
                    }
                
                v.dateFinEmbauche = dtpDateFinContrat.Value;
                v.actif = 1;
                ControleurMission1.SaveChanges();
                FrmGestionRegion_Load(sender, e);
            }
        }

        private void BtnAjouterVisiteurExistant_Click(object sender, EventArgs e)
        {
            Form Inscription = new FrmInscription();
            Inscription.Show();
        }
    }
}
