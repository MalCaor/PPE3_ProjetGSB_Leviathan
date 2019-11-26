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
    public partial class InfoVisiteur : Form
    {
        private bool close;
        public InfoVisiteur()
        {
            InitializeComponent();
            //c'est la syncro
            //bsVisiteur.DataSource = controleurMission2.listeVisiteurs();
            //bsMedecins.DataSource = controleurMission2.listeVisiteurs();
            /*bsVisiteur.DataSource = ...;*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Chargement du visiteur connecté
            bsVisiteur.DataSource = controleurMission2.logInfoVisiteur();
            bsRapports.DataSource = controleurMission2.listeRapportV(controleurMission2.leVisiteur);

            //Chargement de la liste des medecins en charge
            cboMedecin.ValueMember = "idMedecin";
            cboMedecin.DisplayMember = "nom";
            bsMedecins.DataSource = controleurMission2.listeMedecinsSuivi(controleurMission2.leVisiteur);
            /*txtNom.Text = bsVisiteur.*/
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            close = true;
        }

        private void bsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            if (close == true)
            {

            }
            else
            {
                //Chargement des informations du Visiteur connecté
                Visiteur v = controleurMission2.leVisiteur;
                txtNom.Text = v.nom.ToString();
                txtPrénom.Text = v.prenom.ToString();
                //txtRole.Text = v.role.ToString(); pas de rôle en bdd pour l'instant
            }
        }

        private void BsMedecins_CurrentChanged(object sender, EventArgs e)
        {
            if (close == true)
            {

            }
            else
            {
                //Chargement des informations du Medecin sélectionner
                dgvRapports.DataSource = cboMedecin.SelectedValue;
            }

        }

        private void btnToutLesRapports_Click(object sender, EventArgs e)
        {
            //Chargement de tout les rapport du visiteur dans la DataGreedView
            dgvRapports.DataSource = bsRapports;
        }
    }
}
