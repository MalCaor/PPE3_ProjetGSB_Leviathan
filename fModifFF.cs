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
    public partial class fModifFF : Form
    {
        public fModifFF(LigneFraisForfait ffModif)
        {
            InitializeComponent();
            bsFF.DataSource = ffModif;
            LigneFraisForfait ff = ffModif;
            // Switch the name of the label
            lQuantite.Text = "Quantite :";
            //if ff != null
            if(ff != null)
            {
                tbMois.Text = ff.mois;
                tbQuantite.Text = ff.quantite.ToString();
            }
        }
        public fModifFF(LigneFraisHorsForfait ffModif)
        {
            InitializeComponent();
            bsFF.DataSource = ffModif;
            LigneFraisHorsForfait ff = ffModif;
            // Switch the name of the label
            lQuantite.Text = "Montant :";
            //if ff != null
            if (ff != null)
            {
                tbQuantite.Text = ff.montant.ToString();
                tbMois.Text = ff.mois;
            }
        }


        private void FModifFF_Load(object sender, EventArgs e)
        {
        }
    }
}
