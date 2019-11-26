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
            cboVisiteur.DisplayMember = "nom";
            bsAjoutVisiteur.DataSource = ControleurMission1.listevisiteur();
            cboVisiteur.DataSource = bsAjoutVisiteur;

            cboLaboratoire.ValueMember = "idLabo";
            cboLaboratoire.DisplayMember = "nomLabo";
            bsLaboratoire.DataSource = ControleurMission1.listeLaboratoire();
            cboLaboratoire.DataSource = bsLaboratoire;

            cboRegion.ValueMember = "idRegion";
            cboRegion.DisplayMember = "libregion";
            bsRegion.DataSource = ControleurMission1.leVisiteur.Region.ToList();
            cboRegion.DataSource = bsRegion;
            
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAjouterVisiteur_Click(object sender, EventArgs e)
        {
            Visiteur v = (Visiteur)bsAjoutVisiteur.Current;
            Region r = (Region)bsRegion.Current;
            if (v.Region1.Contains(r))
            {
                MessageBox.Show("Erreur, ce visiteur Travaille déjà dans cette région");
            }
            else
            {
                v.Region1.Add(r);
            }
            ControleurMission1.SaveChanges();
            FrmInscription_Load(sender, e);
        }

        private void BtnCreer_Click(object sender, EventArgs e)
        {
            if(txtNomVisiteur.Text == "" || txtPrenomVisiteur.Text == "" || txtRueVisiteur.Text=="" || txtVilleVisiteur.Text == "" || txtCPVisiteur.Text == ""
                || txtIdentifiantVisiteur.Text == "" || txtMDPConfirmer.Text=="" || txtMDPVisiteur.Text=="")
            {
                MessageBox.Show("Erreur, information(s) manquante(s)");
            }
            else
            {
                if(txtMDPVisiteur.Text != txtMDPConfirmer.Text)
                {
                    MessageBox.Show("Erreur, confirmer MDP");
                }
                else
                {
                    if(ControleurMission1.AjoutVisiteur(cboLaboratoire.SelectedIndex, txtNomVisiteur.Text, txtPrenomVisiteur.Text, txtRueVisiteur.Text, txtCPVisiteur.Text, txtVilleVisiteur.Text, dtpDateEmbauche.Value.ToString(), txtIdentifiantVisiteur.Text, txtMDPVisiteur.Text.ToString()))
                    {
                        MessageBox.Show("Enregistrement effectué");
                    }
                    else
                    {
                        MessageBox.Show("Echec de l'enregistrement");
                    }
                }
            }
            ControleurMission1.SaveChanges();
            FrmInscription_Load(sender, e);
        }
    }
}
