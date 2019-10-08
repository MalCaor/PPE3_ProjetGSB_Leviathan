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
    public partial class fConsulterFichesFrais : Form
    {
        private bool close = false;
        public fConsulterFichesFrais()
        {
            InitializeComponent();
            // insert listFicheFrais in bs
            //bindingSourceFicheFrais.DataSource = controleurMission3.listeFicheFrais();
            bindingSourceVisiteur.DataSource = controleurMission3.listeVisiteur();
            bindingSourceNomVis.DataSource = controleurMission3.nomVisit();
            bindingSourceRegion.DataSource = controleurMission3.listeRegion();
            CBVisiteur.DataSource = bindingSourceNomVis.DataSource; 
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visiteur v = (Visiteur)controleurMission3.visiteurIDSearch(CBVisiteur.Text);
            //dgvFiche.DataSource = controleurMission3.listFicheFraisVisiteur(v);
            //dgvFiche.Columns[1].Visible = false;
            //dgvFiche.Columns[2].Visible = false;
            //dgvFiche.Columns[3].Visible = false;
            //dgvFiche.Columns[5].Visible = false;
            //dgvFiche.Columns[6].Visible = false;
            //dgvFiche.Columns[7].Visible = false;
            //dgvFiche.Columns[8].Visible = false;
            //dgvFiche.Columns[9].Visible = false;
            bindingSourceFicheFrais.DataSource = controleurMission3.listFicheFraisVisiteur(v);
            cbFicheFrais.DataSource = bindingSourceFicheFrais;
            cbFicheFrais.ValueMember = "mois";
            cbFicheFrais.DisplayMember = "mois";
            
            labVisit.Text = v.identifiant;
            tbVille.Text = v.ville;
            tbDateEmb.Text = v.dateEmbauche;
            tbRue.Text = v.rue;
            tbCP.Text = v.cp;
            Laboratoire lab = v.Laboratoire;
            tbLab.Text = lab.nomLabo;
            fichefrais ff = (fichefrais)bindingSourceFicheFrais.Current;
        }

        private void CbFicheFrais_Format(object sender, ListControlConvertEventArgs e)
        {
            string moisAnne = ((fichefrais)e.ListItem).mois;
            string dys = string.Concat(moisAnne.Substring(0, 2)," / ", moisAnne.Substring(2, 4));
            e.Value = dys;
        }

        private void CbFicheFrais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!close)
            {
                fichefrais ff = (fichefrais)bindingSourceFicheFrais.Current;
                tbMois.Text = ff.mois;
            }
        }

        private void FConsulterFichesFrais_Load(object sender, EventArgs e)
        {
            close = false;
        }

        private void FConsulterFichesFrais_FormClosing(object sender, FormClosingEventArgs e)
        {
            close = true;
        }
    }
}
