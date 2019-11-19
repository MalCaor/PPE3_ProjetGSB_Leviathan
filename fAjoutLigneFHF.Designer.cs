namespace PPE3_Leviathan
{
    partial class fAjoutLigneFHF
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFF = new System.Windows.Forms.ComboBox();
            this.lMoisAnnee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bsFF = new System.Windows.Forms.BindingSource(this.components);
            this.tbMois = new System.Windows.Forms.NumericUpDown();
            this.tbAnnee = new System.Windows.Forms.NumericUpDown();
            this.tiret = new System.Windows.Forms.Label();
            this.tbQuan = new System.Windows.Forms.NumericUpDown();
            this.btnAj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout Ligne Frais Forfait";
            // 
            // cbFF
            // 
            this.cbFF.FormattingEnabled = true;
            this.cbFF.Location = new System.Drawing.Point(340, 102);
            this.cbFF.Name = "cbFF";
            this.cbFF.Size = new System.Drawing.Size(121, 21);
            this.cbFF.TabIndex = 2;
            // 
            // lMoisAnnee
            // 
            this.lMoisAnnee.AutoSize = true;
            this.lMoisAnnee.Location = new System.Drawing.Point(15, 105);
            this.lMoisAnnee.Name = "lMoisAnnee";
            this.lMoisAnnee.Size = new System.Drawing.Size(77, 13);
            this.lMoisAnnee.TabIndex = 4;
            this.lMoisAnnee.Text = "Mois / Année :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "FraisForfait :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantite :";
            // 
            // tbMois
            // 
            this.tbMois.Location = new System.Drawing.Point(98, 103);
            this.tbMois.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.tbMois.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbMois.Name = "tbMois";
            this.tbMois.Size = new System.Drawing.Size(44, 20);
            this.tbMois.TabIndex = 9;
            this.tbMois.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbAnnee
            // 
            this.tbAnnee.Location = new System.Drawing.Point(164, 103);
            this.tbAnnee.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.tbAnnee.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.tbAnnee.Name = "tbAnnee";
            this.tbAnnee.Size = new System.Drawing.Size(100, 20);
            this.tbAnnee.TabIndex = 10;
            this.tbAnnee.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // tiret
            // 
            this.tiret.AutoSize = true;
            this.tiret.Location = new System.Drawing.Point(148, 105);
            this.tiret.Name = "tiret";
            this.tiret.Size = new System.Drawing.Size(10, 13);
            this.tiret.TabIndex = 11;
            this.tiret.Text = "-";
            // 
            // tbQuan
            // 
            this.tbQuan.Location = new System.Drawing.Point(526, 103);
            this.tbQuan.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.tbQuan.Name = "tbQuan";
            this.tbQuan.Size = new System.Drawing.Size(44, 20);
            this.tbQuan.TabIndex = 12;
            this.tbQuan.ValueChanged += new System.EventHandler(this.NumericUpDown3_ValueChanged);
            // 
            // btnAj
            // 
            this.btnAj.Location = new System.Drawing.Point(18, 321);
            this.btnAj.Name = "btnAj";
            this.btnAj.Size = new System.Drawing.Size(75, 23);
            this.btnAj.TabIndex = 13;
            this.btnAj.Text = "Ajouter";
            this.btnAj.UseVisualStyleBackColor = true;
            this.btnAj.Click += new System.EventHandler(this.BtnAj_Click);
            // 
            // fAjoutLigneFHF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAj);
            this.Controls.Add(this.tbQuan);
            this.Controls.Add(this.tiret);
            this.Controls.Add(this.tbAnnee);
            this.Controls.Add(this.tbMois);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lMoisAnnee);
            this.Controls.Add(this.cbFF);
            this.Controls.Add(this.label1);
            this.Name = "fAjoutLigneFHF";
            this.Text = "fAjoutLigneFHF";
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFF;
        private System.Windows.Forms.Label lMoisAnnee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsFF;
        private System.Windows.Forms.NumericUpDown tbMois;
        private System.Windows.Forms.NumericUpDown tbAnnee;
        private System.Windows.Forms.Label tiret;
        private System.Windows.Forms.NumericUpDown tbQuan;
        private System.Windows.Forms.Button btnAj;
    }
}