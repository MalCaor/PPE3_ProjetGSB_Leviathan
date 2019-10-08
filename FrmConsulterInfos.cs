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
    public partial class FrmConsulterInfos : Form
    {
        public FrmConsulterInfos()
        {
            InitializeComponent();
        }

        private void FrmConsulterInfos_Load(object sender, EventArgs e)
        {
            Visiteur lesInfos = ControleurMission1.LesInfosVisiteur();
            txtNom.Text = lesInfos.nom;
            txtPrenom.Text = lesInfos.prenom;
            txtRue.Text = lesInfos.rue;
            txtVille.Text = lesInfos.ville;
            txtCp.Text = lesInfos.cp;
            lblDateEmbaucheValeur.Text = lesInfos.dateEmbauche;
        }

        private void Restaurer_Click(object sender, EventArgs e)
        {
            Visiteur lesInfos = ControleurMission1.LesInfosVisiteur();
            txtNom.Text = lesInfos.nom;
            txtPrenom.Text = lesInfos.prenom;
            txtRue.Text = lesInfos.rue;
            txtVille.Text = lesInfos.ville;
            txtCp.Text = lesInfos.cp;
            lblDateEmbaucheValeur.Text = lesInfos.dateEmbauche;
        }

        private void Confirmer_Click(object sender, EventArgs e)
        {
            if(ControleurMission1.leVisiteur.nom != txtNom.Text.ToString())
            {
                ControleurMission1.leVisiteur.nom = txtNom.Text.ToString();
            }

        }
    }
}
