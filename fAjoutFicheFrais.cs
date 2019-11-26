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
    public partial class fAjoutFicheFrais : Form
    {
        static Visiteur v;
        static bool moisCor;
        public fAjoutFicheFrais(Visiteur V)
        {
            InitializeComponent();
            calandar.Format = DateTimePickerFormat.Custom;
            calandar.CustomFormat = "MM-yyyy";
            v = V;
            moisCor = false;
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            string Annee = (calandar.Value.Year.ToString());
            string mois = (calandar.Value.Month.ToString());
            if(mois.Length == 1)
            {
                mois = "0" + mois;
            }
            string date = mois + Annee;
            List<fichefrais> listff = controleurMission3.listeFicheFraisparID(v.idVisiteur);
            foreach (fichefrais ff in listff)
            {
                if (ff.mois == mois)
                {
                    moisCor = true;
                    MessageBox.Show("Mois déjà pris");
                }
                else
                {
                    moisCor = false;
                }
            }
            if (!moisCor)
            {
                fichefrais fichefrais = new fichefrais();
                fichefrais.Visiteur = v;
                fichefrais.idVisiteur = v.idVisiteur;
                fichefrais.idEtat = "VA";
                fichefrais.mois = date;
                controleurMission3.addFichefrais(fichefrais);
            }
        }

        private void Calandar_ValueChanged(object sender, EventArgs e)
        {
            string Annee = (calandar.Value.Year.ToString());
            string mois = (calandar.Value.Month.ToString());
            if (mois.Length == 1)
            {
                mois = "0" + mois;
            }
            string date = mois + Annee;
            List<fichefrais> listff = controleurMission3.listeFicheFraisparID(v.idVisiteur);
            foreach (fichefrais ff in listff)
            {
                if (ff.mois == mois)
                {
                    moisCor = true;
                    MessageBox.Show("Mois déjà pris");
                }
                else
                {
                    moisCor = false;
                }
            }
        }
    }
}
