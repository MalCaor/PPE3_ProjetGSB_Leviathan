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
        public fConsulterFichesFrais()
        {
            InitializeComponent();
            // insert listFicheFrais in bs
            bindingSourceFicheFrais.DataSource = controleurMission3.listeFicheFrais();
            bindingSourceVisiteur.DataSource = controleurMission3.listeVisiteur();
            bindingSourceNomVis.DataSource = controleurMission3.nomVisit();
            // dgv = bs
            dataGridViewFicheFrais.DataSource = bindingSourceFicheFrais;
            // Hide some grid (du to error or empty grid)
            dataGridViewFicheFrais.Columns[2].Visible = false;
            dataGridViewFicheFrais.Columns[3].Visible = false;
            dataGridViewFicheFrais.Columns[5].Visible = false;
            dataGridViewFicheFrais.Columns[6].Visible = false;
            dataGridViewFicheFrais.Columns[7].Visible = false;
            dataGridViewFicheFrais.Columns[8].Visible = false;
            dataGridViewFicheFrais.Columns[9].Visible = false;

            CBVisiteur.DataSource = bindingSourceNomVis.DataSource; 
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visiteur v = (Visiteur)controleurMission3.visiteurIDSearch(CBVisiteur.Text);
            dgvFiche.DataSource = controleurMission3.listFicheFraisVisiteur(v);
        }
    }
}
