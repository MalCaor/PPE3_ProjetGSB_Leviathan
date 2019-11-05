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
    public partial class Form2 : Form
    {
        private bool close;
        public Form2()
        {
            InitializeComponent();
            //c'est la syncro

            bsVisiteurs.DataSource = controleurMission2.listeVisiteurs();
            /*bsVisiteur.DataSource = ...;*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*txtNom.Text = bsVisiteur.*/
        }

        private void BsVisiteurs_CurrentChanged(object sender, EventArgs e)
        {
            if (close == true)
            {

            }
            else
            {
                Visiteur v = (Visiteur)bsVisiteurs.Current;
                txtNom.Text = v.nom.ToString();
                txtPrénom.Text = v.prenom.ToString();
                //txtRole.Text = v.role.ToString();
                cboMedecin.DataSource = controleurMission2.listeMedecinsSuivi(v);
                dgvRapports.DataSource = cboMedecin.SelectedValue;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            close = true;
        }
    }
}
