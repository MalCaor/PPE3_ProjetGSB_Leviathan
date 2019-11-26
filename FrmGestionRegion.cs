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
    public partial class FrmGestionRegion : Form
    {
        public FrmGestionRegion()
        {
            InitializeComponent();
        }

        private void FrmGestionRegion_Load(object sender, EventArgs e)
        {
            cboGestionRegion.ValueMember = "idRegion";
            cboGestionRegion.DisplayMember = "libRegion";
            bsGestionRegion.DataSource = ControleurMission1.leVisiteur.Region1.ToList();
            cboGestionRegion.DataSource = bsGestionRegion;

            List<Region>lesRegionDeLaCombo = ControleurMission1.leVisiteur.Region1.ToList();
            int nbRegion = lesRegionDeLaCombo.Count();
            int nbTrue = 0;
            foreach (Region regionCombo in lesRegionDeLaCombo)
            {
                if (regionCombo.Visiteur.idVisiteur != ControleurMission1.leVisiteur.idVisiteur)
                {
                    nbTrue += 1;
                }
            }
            if (nbTrue == nbRegion)
            {
                this.Close();
            }
        }

        private void BsGestionRegion_CurrentChanged(object sender, EventArgs e)
        {
            Region r = (Region)bsGestionRegion.Current;
            List<Visiteur> dgvVisiteur = new List<Visiteur>();
            dgvVisiteur.Add(r.Visiteur);
        }
    }
}
