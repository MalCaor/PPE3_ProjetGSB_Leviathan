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
        }
    }
}
