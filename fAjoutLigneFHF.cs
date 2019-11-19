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
    public partial class fAjoutLigneFHF : Form
    {
        public fAjoutLigneFHF()
        {
            InitializeComponent();

            //ComboBox
            bsFF.DataSource = controleurMission3.libFF();
            cbFF.DataSource = bsFF.DataSource;
        }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
