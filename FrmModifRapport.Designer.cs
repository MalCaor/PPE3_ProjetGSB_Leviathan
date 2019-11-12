namespace PPE3_Leviathan
{
    partial class FrmModifRapport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMedecin = new System.Windows.Forms.RadioButton();
            this.btnRemplacent = new System.Windows.Forms.RadioButton();
            this.cboMedecin = new System.Windows.Forms.ComboBox();
            this.txtNomRemplacent = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblBilan = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnValid = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpEchantillons = new System.Windows.Forms.GroupBox();
            this.lblMédicament = new System.Windows.Forms.Label();
            this.lblNbMédicament = new System.Windows.Forms.Label();
            this.cboM1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.g = new System.Windows.Forms.NumericUpDown();
            this.cboM2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.cboM3 = new System.Windows.Forms.ComboBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.cboM4 = new System.Windows.Forms.ComboBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.cboM5 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.txtPrénomRemplacent = new System.Windows.Forms.TextBox();
            this.grpEchantillons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedecin
            // 
            this.btnMedecin.AutoSize = true;
            this.btnMedecin.Location = new System.Drawing.Point(35, 25);
            this.btnMedecin.Name = "btnMedecin";
            this.btnMedecin.Size = new System.Drawing.Size(82, 17);
            this.btnMedecin.TabIndex = 0;
            this.btnMedecin.TabStop = true;
            this.btnMedecin.Text = "BtnMedecin";
            this.btnMedecin.UseVisualStyleBackColor = true;
            // 
            // btnRemplacent
            // 
            this.btnRemplacent.AutoSize = true;
            this.btnRemplacent.Location = new System.Drawing.Point(35, 60);
            this.btnRemplacent.Name = "btnRemplacent";
            this.btnRemplacent.Size = new System.Drawing.Size(98, 17);
            this.btnRemplacent.TabIndex = 1;
            this.btnRemplacent.TabStop = true;
            this.btnRemplacent.Text = "BtnRemplacent";
            this.btnRemplacent.UseVisualStyleBackColor = true;
            // 
            // cboMedecin
            // 
            this.cboMedecin.FormattingEnabled = true;
            this.cboMedecin.Location = new System.Drawing.Point(160, 24);
            this.cboMedecin.Name = "cboMedecin";
            this.cboMedecin.Size = new System.Drawing.Size(180, 21);
            this.cboMedecin.TabIndex = 2;
            // 
            // txtNomRemplacent
            // 
            this.txtNomRemplacent.Location = new System.Drawing.Point(160, 59);
            this.txtNomRemplacent.Name = "txtNomRemplacent";
            this.txtNomRemplacent.Size = new System.Drawing.Size(180, 20);
            this.txtNomRemplacent.TabIndex = 3;
            this.txtNomRemplacent.Text = "Nom Remplacent";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(35, 130);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date :";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(35, 165);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "Motif :";
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Location = new System.Drawing.Point(35, 200);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(36, 13);
            this.lblBilan.TabIndex = 6;
            this.lblBilan.Text = "Bilan :";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(160, 162);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(180, 20);
            this.txtMotif.TabIndex = 8;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(90, 197);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(250, 70);
            this.txtBilan.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(160, 127);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 20);
            this.dtpDate.TabIndex = 10;
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(12, 324);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(375, 25);
            this.btnValid.TabIndex = 11;
            this.btnValid.Text = "Valider";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.BtnValid_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(397, 324);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(375, 25);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // grpEchantillons
            // 
            this.grpEchantillons.Controls.Add(this.checkBox5);
            this.grpEchantillons.Controls.Add(this.checkBox4);
            this.grpEchantillons.Controls.Add(this.checkBox3);
            this.grpEchantillons.Controls.Add(this.checkBox2);
            this.grpEchantillons.Controls.Add(this.checkBox1);
            this.grpEchantillons.Controls.Add(this.numericUpDown5);
            this.grpEchantillons.Controls.Add(this.cboM5);
            this.grpEchantillons.Controls.Add(this.numericUpDown4);
            this.grpEchantillons.Controls.Add(this.cboM4);
            this.grpEchantillons.Controls.Add(this.numericUpDown3);
            this.grpEchantillons.Controls.Add(this.cboM3);
            this.grpEchantillons.Controls.Add(this.g);
            this.grpEchantillons.Controls.Add(this.cboM2);
            this.grpEchantillons.Controls.Add(this.numericUpDown1);
            this.grpEchantillons.Controls.Add(this.cboM1);
            this.grpEchantillons.Controls.Add(this.lblNbMédicament);
            this.grpEchantillons.Controls.Add(this.lblMédicament);
            this.grpEchantillons.Location = new System.Drawing.Point(397, 12);
            this.grpEchantillons.Name = "grpEchantillons";
            this.grpEchantillons.Size = new System.Drawing.Size(375, 306);
            this.grpEchantillons.TabIndex = 13;
            this.grpEchantillons.TabStop = false;
            this.grpEchantillons.Text = "groupBox1";
            // 
            // lblMédicament
            // 
            this.lblMédicament.AutoSize = true;
            this.lblMédicament.Location = new System.Drawing.Point(101, 20);
            this.lblMédicament.Name = "lblMédicament";
            this.lblMédicament.Size = new System.Drawing.Size(65, 13);
            this.lblMédicament.TabIndex = 0;
            this.lblMédicament.Text = "Médicament";
            // 
            // lblNbMédicament
            // 
            this.lblNbMédicament.AutoSize = true;
            this.lblNbMédicament.Location = new System.Drawing.Point(230, 20);
            this.lblNbMédicament.Name = "lblNbMédicament";
            this.lblNbMédicament.Size = new System.Drawing.Size(111, 13);
            this.lblNbMédicament.TabIndex = 1;
            this.lblNbMédicament.Text = "Nombre d\'échantillons";
            // 
            // cboM1
            // 
            this.cboM1.FormattingEnabled = true;
            this.cboM1.Location = new System.Drawing.Point(60, 47);
            this.cboM1.Name = "cboM1";
            this.cboM1.Size = new System.Drawing.Size(140, 21);
            this.cboM1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(215, 48);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // g
            // 
            this.g.Location = new System.Drawing.Point(215, 82);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(140, 20);
            this.g.TabIndex = 5;
            // 
            // cboM2
            // 
            this.cboM2.FormattingEnabled = true;
            this.cboM2.Location = new System.Drawing.Point(60, 82);
            this.cboM2.Name = "cboM2";
            this.cboM2.Size = new System.Drawing.Size(140, 21);
            this.cboM2.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(215, 117);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown3.TabIndex = 7;
            // 
            // cboM3
            // 
            this.cboM3.FormattingEnabled = true;
            this.cboM3.Location = new System.Drawing.Point(60, 117);
            this.cboM3.Name = "cboM3";
            this.cboM3.Size = new System.Drawing.Size(140, 21);
            this.cboM3.TabIndex = 6;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(215, 152);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown4.TabIndex = 9;
            // 
            // cboM4
            // 
            this.cboM4.FormattingEnabled = true;
            this.cboM4.Location = new System.Drawing.Point(60, 152);
            this.cboM4.Name = "cboM4";
            this.cboM4.Size = new System.Drawing.Size(140, 21);
            this.cboM4.TabIndex = 8;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(215, 190);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown5.TabIndex = 11;
            // 
            // cboM5
            // 
            this.cboM5.FormattingEnabled = true;
            this.cboM5.Location = new System.Drawing.Point(60, 190);
            this.cboM5.Name = "cboM5";
            this.cboM5.Size = new System.Drawing.Size(140, 21);
            this.cboM5.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 83);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(23, 119);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(23, 153);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(23, 191);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // txtPrénomRemplacent
            // 
            this.txtPrénomRemplacent.Location = new System.Drawing.Point(160, 92);
            this.txtPrénomRemplacent.Name = "txtPrénomRemplacent";
            this.txtPrénomRemplacent.Size = new System.Drawing.Size(180, 20);
            this.txtPrénomRemplacent.TabIndex = 14;
            this.txtPrénomRemplacent.Text = "Prénom Remplacent";
            // 
            // FrmModifRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.txtPrénomRemplacent);
            this.Controls.Add(this.grpEchantillons);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.lblBilan);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtNomRemplacent);
            this.Controls.Add(this.cboMedecin);
            this.Controls.Add(this.btnRemplacent);
            this.Controls.Add(this.btnMedecin);
            this.Name = "FrmModifRapport";
            this.Text = "FrmModifRapport";
            this.Load += new System.EventHandler(this.FrmModifRapport_Load);
            this.grpEchantillons.ResumeLayout(false);
            this.grpEchantillons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnMedecin;
        private System.Windows.Forms.RadioButton btnRemplacent;
        private System.Windows.Forms.ComboBox cboMedecin;
        private System.Windows.Forms.TextBox txtNomRemplacent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox grpEchantillons;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.ComboBox cboM5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.ComboBox cboM4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ComboBox cboM3;
        private System.Windows.Forms.NumericUpDown g;
        private System.Windows.Forms.ComboBox cboM2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cboM1;
        private System.Windows.Forms.Label lblNbMédicament;
        private System.Windows.Forms.Label lblMédicament;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtPrénomRemplacent;
    }
}