namespace PPE3_Leviathan
{
    partial class fAjoutLigneFF
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFF = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsFF = new System.Windows.Forms.BindingSource(this.components);
            this.tbMois = new System.Windows.Forms.NumericUpDown();
            this.lMoisAnnee = new System.Windows.Forms.Label();
            this.tiret = new System.Windows.Forms.Label();
            this.tbAnnee = new System.Windows.Forms.NumericUpDown();
            this.tbQuan = new System.Windows.Forms.NumericUpDown();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantite :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "FraisForfait :";
            // 
            // cbFF
            // 
            this.cbFF.FormattingEnabled = true;
            this.cbFF.Location = new System.Drawing.Point(356, 98);
            this.cbFF.Name = "cbFF";
            this.cbFF.Size = new System.Drawing.Size(121, 21);
            this.cbFF.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ajout Ligne Frais Forfait";
            // 
            // tbMois
            // 
            this.tbMois.Location = new System.Drawing.Point(97, 99);
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
            this.tbMois.TabIndex = 14;
            this.tbMois.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lMoisAnnee
            // 
            this.lMoisAnnee.AutoSize = true;
            this.lMoisAnnee.Location = new System.Drawing.Point(14, 101);
            this.lMoisAnnee.Name = "lMoisAnnee";
            this.lMoisAnnee.Size = new System.Drawing.Size(77, 13);
            this.lMoisAnnee.TabIndex = 15;
            this.lMoisAnnee.Text = "Mois / Année :";
            // 
            // tiret
            // 
            this.tiret.AutoSize = true;
            this.tiret.Location = new System.Drawing.Point(147, 101);
            this.tiret.Name = "tiret";
            this.tiret.Size = new System.Drawing.Size(10, 13);
            this.tiret.TabIndex = 18;
            this.tiret.Text = "-";
            // 
            // tbAnnee
            // 
            this.tbAnnee.Location = new System.Drawing.Point(163, 99);
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
            this.tbAnnee.TabIndex = 17;
            this.tbAnnee.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // tbQuan
            // 
            this.tbQuan.Location = new System.Drawing.Point(542, 99);
            this.tbQuan.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.tbQuan.Name = "tbQuan";
            this.tbQuan.Size = new System.Drawing.Size(44, 20);
            this.tbQuan.TabIndex = 19;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(17, 298);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 20;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // fAjoutLigneFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbQuan);
            this.Controls.Add(this.tiret);
            this.Controls.Add(this.tbAnnee);
            this.Controls.Add(this.lMoisAnnee);
            this.Controls.Add(this.tbMois);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFF);
            this.Controls.Add(this.label1);
            this.Name = "fAjoutLigneFF";
            this.Text = "fAjoutLigneFF";
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsFF;
        private System.Windows.Forms.NumericUpDown tbMois;
        private System.Windows.Forms.Label lMoisAnnee;
        private System.Windows.Forms.Label tiret;
        private System.Windows.Forms.NumericUpDown tbAnnee;
        private System.Windows.Forms.NumericUpDown tbQuan;
        private System.Windows.Forms.Button btnAjouter;
    }
}