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
    public partial class FrmMission1 : Form
    {
        public FrmMission1()
        {
            InitializeComponent();
        }

        private void ConsulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ConsulterInfos = new FrmConsulterInfos();
            ConsulterInfos.Show();
        }
    }
}