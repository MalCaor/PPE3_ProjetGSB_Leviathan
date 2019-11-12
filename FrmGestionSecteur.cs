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
    public partial class FrmGestionSecteur : Form
    {
        public FrmGestionSecteur()
        {
            InitializeComponent();
        }

        private void FrmGestionSecteur_Load(object sender, EventArgs e)
        {
            cboGestionSecteur.ValueMember = "idSecteur";
            cboGestionSecteur.DisplayMember = "libSecteur";
            bsGestionSecteur.DataSource = ControleurMission1.leVisiteur.Secteur.ToList(); 
            cboGestionSecteur.DataSource = bsGestionSecteur;
        }

        private void BsGestionSecteur_CurrentChanged(object sender, EventArgs e)
        {
            Secteur s = (Secteur)bsGestionSecteur.Current;
            List<Region> LesRegionsSecteur = s.Region.ToList();
            List<Visiteur> vretour = new List<Visiteur>();
            vretour.Add(s.Visiteur);
            foreach(Region region in LesRegionsSecteur)
            {
                vretour.Add(region.Visiteur);
                List<Visiteur> lesVisiteursRegions = region.Visiteur1.ToList();
                foreach(Visiteur visiteur in lesVisiteursRegions)
                {
                    if(!vretour.Contains(visiteur))
                    {
                        vretour.Add(visiteur);
                    }
                }
            }
            dgvVisiteurGestion.DataSource = vretour;
            dgvVisiteurGestion.Columns[0].Visible = false;
            dgvVisiteurGestion.Columns[1].Visible = false;
            dgvVisiteurGestion.Columns[8].Visible = false;
            dgvVisiteurGestion.Columns[9].Visible = false;
            dgvVisiteurGestion.Columns[10].Visible = false;
            dgvVisiteurGestion.Columns[11].Visible = false;
            dgvVisiteurGestion.Columns[12].Visible = false;
            dgvVisiteurGestion.Columns[13].Visible = false;
            dgvVisiteurGestion.Columns[14].Visible = false;
            dgvVisiteurGestion.Columns[15].Visible = false;
        }


        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
