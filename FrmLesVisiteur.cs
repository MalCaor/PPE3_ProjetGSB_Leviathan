﻿using System;
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
    public partial class FrmLesVisiteur : Form
    {
        public FrmLesVisiteur()
        {
            InitializeComponent();
        }

        private void FrmLesVisiteur_Load(object sender, EventArgs e)
        {
            bsVisiteurs.DataSource = ControleurMission1.ListeChoixVisualisation();
            cboChoixAffichage.DataSource = bsVisiteurs;
        }

        private void BsVisiteurs_CurrentChanged(object sender, EventArgs e)
        {
            string choix = (string)bsVisiteurs.Current;
            if(choix == "Global")
            {
                
            }
            if(choix == "Par secteur")
            {

            }
            if(choix == "Par Région")
            {
                
            }
        }
    }
}
