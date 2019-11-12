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
            List<Secteur>LesSecteursVisiteurs = ControleurMission1.leVisiteur.Secteur.ToList();
            List<string> ContenuCBO = new List<string>();
            foreach(Secteur s in LesSecteursVisiteurs)
            {
                ContenuCBO.Add(s.libSecteur);
            }
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
                    vretour.Add(visiteur);
                }
            }
            dataGridView1.DataSource = vretour;
        }
    }
}
