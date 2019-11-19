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
        static Visiteur v;
        private bool change = false;
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
            change = false;
            v = (Visiteur)controleurMission3.visiteurIDSearch(CBVisiteur.Text);
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
            if (!close && !change)
            {
                fichefrais ff = (fichefrais)bindingSourceFicheFrais.Current;
                string moisAnne = ff.mois;
                tbMois.Text = string.Concat(moisAnne.Substring(0, 2), " / ", moisAnne.Substring(2, 4));
                tbNbJust.Text = ff.nbJustificatifs.ToString();
                tbMont.Text = ff.montantValide.ToString();
                tbDateModif.Text = ff.dateModif.ToString().Substring(0, 10);
                change = true;
                bindingSourceLigneHF.DataSource = ff.LigneFraisHorsForfait.ToList();
                bindingSourceLigneF.DataSource = ff.LigneFraisForfait.ToList();
                dgvLigneFor.DataSource = bindingSourceLigneF.DataSource;
                //hide object info
                dgvLigneFor.Columns[4].Visible = false;
                dgvLigneFor.Columns[5].Visible = false;
                dgvLigneHor.DataSource = bindingSourceLigneHF.DataSource;
                //hide object info
                dgvLigneHor.Columns[4].Visible = false;
                dgvLigneHor.Columns[5].Visible = false;
                dgvLigneHor.Columns[6].Visible = false;
                if (!(ff.idEtat == "CL"))
                {
                    bModifFF.Enabled = true;
                }
            }
        }

        private void FConsulterFichesFrais_Load(object sender, EventArgs e)
        {
            bModifFF.Enabled = false;
            close = false;
            change = true;
        }

        private void FConsulterFichesFrais_FormClosing(object sender, FormClosingEventArgs e)
        {
            close = true;
        }

        private void BModifFF_Click(object sender, EventArgs e)
        {
            controleurMission3.LFF = (LigneFraisForfait)bindingSourceLigneF.Current;
            controleurMission3.savechange();
            LigneFraisForfait F = (LigneFraisForfait)bindingSourceLigneF.Current;
            Form modifFF = new fModifFF(F);
            modifFF.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            controleurMission3.LFHF = (LigneFraisHorsForfait)bindingSourceLigneHF.Current;
            controleurMission3.savechange();
            LigneFraisHorsForfait HF = (LigneFraisHorsForfait)bindingSourceLigneHF.Current;
            Form modifFF = new fModifFF(HF);
            modifFF.ShowDialog();
        }

        private void DgvLigneFor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtAjFF_Click(object sender, EventArgs e)
        {
            Form AddFF = new fAjoutLigneFF(v.idVisiteur);
            AddFF.ShowDialog();
        }

        private void BtAjFHF_Click(object sender, EventArgs e)
        {
            Form AddFHF = new fAjoutLigneFHF(v.idVisiteur);
            AddFHF.ShowDialog();
        }
    }
}
