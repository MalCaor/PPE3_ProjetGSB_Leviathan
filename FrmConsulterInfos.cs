using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


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
            txtAncienMdp.Text = "";
            txtConfirmerMdp.Text = "";
            txtNouveauMdp.Text = "";
        }

        private void Confirmer_Click(object sender, EventArgs e)
        {
            int modification = 0;
            string message = "";
            if(ControleurMission1.leVisiteur.nom != txtNom.Text.ToString())
            {
                ControleurMission1.leVisiteur.nom = txtNom.Text.ToString();
                modification++;
            }
            if (ControleurMission1.leVisiteur.prenom != txtPrenom.Text.ToString())
            {
                ControleurMission1.leVisiteur.prenom = txtPrenom.Text.ToString();
                modification++;
            }
            if (ControleurMission1.leVisiteur.rue != txtRue.Text.ToString())
            {
                ControleurMission1.leVisiteur.rue = txtRue.Text.ToString();
                modification++;
            }
            if (ControleurMission1.leVisiteur.cp != txtCp.Text.ToString())
            {
                ControleurMission1.leVisiteur.cp = txtCp.Text.ToString();
                modification++;
            }
            if (ControleurMission1.leVisiteur.ville != txtVille.Text.ToString())
            {
                ControleurMission1.leVisiteur.ville = txtVille.Text.ToString();
                modification++;
            }

            //-----------MODIFICATION MDP----------------
            if(!string.IsNullOrEmpty(txtAncienMdp.Text) && !string.IsNullOrEmpty(txtNouveauMdp.Text) && !string.IsNullOrEmpty(txtConfirmerMdp.Text))
            {
                if(ControleurMission1.leVisiteur.password == GetMd5Hash(txtAncienMdp.Text.ToString()) && txtNouveauMdp.Text.ToString() == txtConfirmerMdp.Text.ToString())
                {
                    ControleurMission1.leVisiteur.password = GetMd5Hash(txtConfirmerMdp.Text.ToString());
                    message = message + "- Mot de passe modifié \n";
                }
                else
                {
                    message = message + "- Erreur, mot de passe incorrect \n";
                }
            }
            //-------------------------------------------

            if (modification != 0)
            {
                message = message + "- Modification enregistré \n";
                MessageBox.Show(message);
            }
            ControleurMission1.SaveChanges();
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static string GetMd5Hash(string PasswdSaisi) //Cryptage du mot de passe
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return ("0x" + sb.ToString().ToUpper());
        }



    }
}
