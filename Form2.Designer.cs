namespace PPE3_Leviathan
{
    partial class Form2
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
            this.lbNom = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.cboMedecin = new System.Windows.Forms.ComboBox();
            this.dgvRapports = new System.Windows.Forms.DataGridView();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.Label();
            this.txtPrénom = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.Label();
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(10, 15);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(35, 13);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom :";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(10, 35);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(49, 13);
            this.lbPrenom.TabIndex = 1;
            this.lbPrenom.Text = "Prénom :";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(10, 55);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(35, 13);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "Rôle :";
            // 
            // cboMedecin
            // 
            this.cboMedecin.FormattingEnabled = true;
            this.cboMedecin.Location = new System.Drawing.Point(10, 75);
            this.cboMedecin.Name = "cboMedecin";
            this.cboMedecin.Size = new System.Drawing.Size(126, 21);
            this.cboMedecin.TabIndex = 3;
            // 
            // dgvRapports
            // 
            this.dgvRapports.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvRapports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapports.Location = new System.Drawing.Point(153, 12);
            this.dgvRapports.Name = "dgvRapports";
            this.dgvRapports.Size = new System.Drawing.Size(635, 426);
            this.dgvRapports.TabIndex = 4;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(13, 385);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(123, 23);
            this.btnAjout.TabIndex = 5;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(12, 414);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(124, 23);
            this.btnModif.TabIndex = 6;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // txtNom
            // 
            this.txtNom.AutoSize = true;
            this.txtNom.Location = new System.Drawing.Point(65, 15);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(32, 13);
            this.txtNom.TabIndex = 7;
            this.txtNom.Text = "infoN";
            // 
            // txtPrénom
            // 
            this.txtPrénom.AutoSize = true;
            this.txtPrénom.Location = new System.Drawing.Point(65, 35);
            this.txtPrénom.Name = "txtPrénom";
            this.txtPrénom.Size = new System.Drawing.Size(31, 13);
            this.txtPrénom.TabIndex = 8;
            this.txtPrénom.Text = "infoP";
            // 
            // txtRole
            // 
            this.txtRole.AutoSize = true;
            this.txtRole.Location = new System.Drawing.Point(65, 55);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(32, 13);
            this.txtRole.TabIndex = 9;
            this.txtRole.Text = "infoR";
            // 
            // bsVisiteurs
            // 
            this.bsVisiteurs.CurrentChanged += new System.EventHandler(this.BsVisiteurs_CurrentChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtPrénom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.dgvRapports);
            this.Controls.Add(this.cboMedecin);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.lbNom);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.ComboBox cboMedecin;
        private System.Windows.Forms.DataGridView dgvRapports;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Label txtNom;
        private System.Windows.Forms.Label txtPrénom;
        private System.Windows.Forms.Label txtRole;
        private System.Windows.Forms.BindingSource bsVisiteurs;
        private System.Windows.Forms.BindingSource bsVisiteur;
    }
}