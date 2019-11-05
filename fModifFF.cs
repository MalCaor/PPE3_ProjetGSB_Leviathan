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
        }
        public fModifFF(LigneFraisHorsForfait ffModif)
        {
            InitializeComponent();
            bsFF.DataSource = ffModif;
        }


        private void FModifFF_Load(object sender, EventArgs e)
        {
            
        }
    }
}
