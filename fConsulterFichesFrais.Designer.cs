namespace PPE3_Leviathan
{
    partial class fConsulterFichesFrais
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
            this.bindingSourceFicheFrais = new System.Windows.Forms.BindingSource(this.components);
            this.CBVisiteur = new System.Windows.Forms.ComboBox();
            this.bindingSourceVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceNomVis = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFiche = new System.Windows.Forms.DataGridView();
            this.labVisit = new System.Windows.Forms.Label();
            this.labVille = new System.Windows.Forms.Label();
            this.bindingSourceRegion = new System.Windows.Forms.BindingSource(this.components);
            this.labDEmbau = new System.Windows.Forms.Label();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbDateEmb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFicheFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNomVis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // CBVisiteur
            // 
            this.CBVisiteur.FormattingEnabled = true;
            this.CBVisiteur.Location = new System.Drawing.Point(13, 13);
            this.CBVisiteur.Name = "CBVisiteur";
            this.CBVisiteur.Size = new System.Drawing.Size(184, 21);
            this.CBVisiteur.TabIndex = 1;
            this.CBVisiteur.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // dgvFiche
            // 
            this.dgvFiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiche.Location = new System.Drawing.Point(203, 355);
            this.dgvFiche.Name = "dgvFiche";
            this.dgvFiche.Size = new System.Drawing.Size(585, 83);
            this.dgvFiche.TabIndex = 2;
            // 
            // labVisit
            // 
            this.labVisit.AutoSize = true;
            this.labVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVisit.Location = new System.Drawing.Point(429, 20);
            this.labVisit.Name = "labVisit";
            this.labVisit.Size = new System.Drawing.Size(105, 31);
            this.labVisit.TabIndex = 3;
            this.labVisit.Text = "Visiteur";
            // 
            // labVille
            // 
            this.labVille.AutoSize = true;
            this.labVille.Location = new System.Drawing.Point(204, 90);
            this.labVille.Name = "labVille";
            this.labVille.Size = new System.Drawing.Size(32, 13);
            this.labVille.TabIndex = 4;
            this.labVille.Text = "Ville :";
            // 
            // labDEmbau
            // 
            this.labDEmbau.AutoSize = true;
            this.labDEmbau.Location = new System.Drawing.Point(204, 113);
            this.labDEmbau.Name = "labDEmbau";
            this.labDEmbau.Size = new System.Drawing.Size(90, 13);
            this.labDEmbau.TabIndex = 5;
            this.labDEmbau.Text = "Date Embauche :";
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(314, 87);
            this.tbVille.Name = "tbVille";
            this.tbVille.ReadOnly = true;
            this.tbVille.Size = new System.Drawing.Size(100, 20);
            this.tbVille.TabIndex = 6;
            // 
            // tbDateEmb
            // 
            this.tbDateEmb.Location = new System.Drawing.Point(314, 110);
            this.tbDateEmb.Name = "tbDateEmb";
            this.tbDateEmb.ReadOnly = true;
            this.tbDateEmb.Size = new System.Drawing.Size(100, 20);
            this.tbDateEmb.TabIndex = 7;
            // 
            // fConsulterFichesFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDateEmb);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.labDEmbau);
            this.Controls.Add(this.labVille);
            this.Controls.Add(this.labVisit);
            this.Controls.Add(this.dgvFiche);
            this.Controls.Add(this.CBVisiteur);
            this.Name = "fConsulterFichesFrais";
            this.Text = "fConsulterFichesFrais";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFicheFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNomVis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceFicheFrais;
        private System.Windows.Forms.ComboBox CBVisiteur;
        private System.Windows.Forms.BindingSource bindingSourceVisiteur;
        private System.Windows.Forms.BindingSource bindingSourceNomVis;
        private System.Windows.Forms.DataGridView dgvFiche;
        private System.Windows.Forms.Label labVisit;
        private System.Windows.Forms.Label labVille;
        private System.Windows.Forms.BindingSource bindingSourceRegion;
        private System.Windows.Forms.Label labDEmbau;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbDateEmb;
    }
}