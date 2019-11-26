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
        public fAjoutFicheFrais(Visiteur V)
        {
            InitializeComponent();
            calandar.Format = DateTimePickerFormat.Custom;
            calandar.CustomFormat = "MM-yyyy";
            v = V;
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
            fichefrais fichefrais = new fichefrais();
            fichefrais.Visiteur = v;
            fichefrais.idVisiteur = v.idVisiteur;
            fichefrais.idEtat = "VA";
            fichefrais.mois = date;
            controleurMission3.addFichefrais(fichefrais);
        }
    }
}
