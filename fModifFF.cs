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
    public partial class fModifFF : Form
    {
        public fModifFF(fichefrais ffModif)
        {
            InitializeComponent();
            bsFF.DataSource = ffModif;
        }
    }
}