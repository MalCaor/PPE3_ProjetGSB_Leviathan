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
            this.labVisit = new System.Windows.Forms.Label();
            this.labVille = new System.Windows.Forms.Label();
            this.bindingSourceRegion = new System.Windows.Forms.BindingSource(this.components);
            this.labDEmbau = new System.Windows.Forms.Label();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbDateEmb = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.labRue = new System.Windows.Forms.Label();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.labCP = new System.Windows.Forms.Label();
            this.tbLab = new System.Windows.Forms.TextBox();
            this.lalLab = new System.Windows.Forms.Label();
            this.cbFicheFrais = new System.Windows.Forms.ComboBox();
            this.tbMois = new System.Windows.Forms.TextBox();
            this.labMois = new System.Windows.Forms.Label();
            this.tbNbJust = new System.Windows.Forms.TextBox();
            this.labNbJust = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFicheFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNomVis)).BeginInit();
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
            this.labDEmbau.Location = new System.Drawing.Point(204, 168);
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
            this.tbDateEmb.Location = new System.Drawing.Point(314, 165);
            this.tbDateEmb.Name = "tbDateEmb";
            this.tbDateEmb.ReadOnly = true;
            this.tbDateEmb.Size = new System.Drawing.Size(100, 20);
            this.tbDateEmb.TabIndex = 7;
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(314, 113);
            this.tbRue.Name = "tbRue";
            this.tbRue.ReadOnly = true;
            this.tbRue.Size = new System.Drawing.Size(100, 20);
            this.tbRue.TabIndex = 9;
            // 
            // labRue
            // 
            this.labRue.AutoSize = true;
            this.labRue.Location = new System.Drawing.Point(204, 116);
            this.labRue.Name = "labRue";
            this.labRue.Size = new System.Drawing.Size(33, 13);
            this.labRue.TabIndex = 8;
            this.labRue.Text = "Rue :";
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(314, 139);
            this.tbCP.Name = "tbCP";
            this.tbCP.ReadOnly = true;
            this.tbCP.Size = new System.Drawing.Size(100, 20);
            this.tbCP.TabIndex = 11;
            // 
            // labCP
            // 
            this.labCP.AutoSize = true;
            this.labCP.Location = new System.Drawing.Point(204, 142);
            this.labCP.Name = "labCP";
            this.labCP.Size = new System.Drawing.Size(70, 13);
            this.labCP.TabIndex = 10;
            this.labCP.Text = "Code Postal :";
            // 
            // tbLab
            // 
            this.tbLab.Location = new System.Drawing.Point(314, 191);
            this.tbLab.Name = "tbLab";
            this.tbLab.ReadOnly = true;
            this.tbLab.Size = new System.Drawing.Size(100, 20);
            this.tbLab.TabIndex = 13;
            // 
            // lalLab
            // 
            this.lalLab.AutoSize = true;
            this.lalLab.Location = new System.Drawing.Point(204, 194);
            this.lalLab.Name = "lalLab";
            this.lalLab.Size = new System.Drawing.Size(66, 13);
            this.lalLab.TabIndex = 12;
            this.lalLab.Text = "Laboratoire :";
            // 
            // cbFicheFrais
            // 
            this.cbFicheFrais.FormattingEnabled = true;
            this.cbFicheFrais.Location = new System.Drawing.Point(544, 82);
            this.cbFicheFrais.Name = "cbFicheFrais";
            this.cbFicheFrais.Size = new System.Drawing.Size(217, 21);
            this.cbFicheFrais.TabIndex = 14;
            this.cbFicheFrais.SelectedIndexChanged += new System.EventHandler(this.CbFicheFrais_SelectedIndexChanged);
            this.cbFicheFrais.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CbFicheFrais_Format);
            // 
            // tbMois
            // 
            this.tbMois.Location = new System.Drawing.Point(661, 113);
            this.tbMois.Name = "tbMois";
            this.tbMois.ReadOnly = true;
            this.tbMois.Size = new System.Drawing.Size(100, 20);
            this.tbMois.TabIndex = 16;
            // 
            // labMois
            // 
            this.labMois.AutoSize = true;
            this.labMois.Location = new System.Drawing.Point(551, 116);
            this.labMois.Name = "labMois";
            this.labMois.Size = new System.Drawing.Size(36, 13);
            this.labMois.TabIndex = 15;
            this.labMois.Text = "Date :";
            // 
            // tbNbJust
            // 
            this.tbNbJust.Location = new System.Drawing.Point(661, 139);
            this.tbNbJust.Name = "tbNbJust";
            this.tbNbJust.ReadOnly = true;
            this.tbNbJust.Size = new System.Drawing.Size(100, 20);
            this.tbNbJust.TabIndex = 18;
            // 
            // labNbJust
            // 
            this.labNbJust.AutoSize = true;
            this.labNbJust.Location = new System.Drawing.Point(551, 142);
            this.labNbJust.Name = "labNbJust";
            this.labNbJust.Size = new System.Drawing.Size(104, 13);
            this.labNbJust.TabIndex = 17;
            this.labNbJust.Text = "Nombre Justificatifs :";
            // 
            // fConsulterFichesFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNbJust);
            this.Controls.Add(this.labNbJust);
            this.Controls.Add(this.tbMois);
            this.Controls.Add(this.labMois);
            this.Controls.Add(this.cbFicheFrais);
            this.Controls.Add(this.tbLab);
            this.Controls.Add(this.lalLab);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.labCP);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(this.labRue);
            this.Controls.Add(this.tbDateEmb);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.labDEmbau);
            this.Controls.Add(this.labVille);
            this.Controls.Add(this.labVisit);
            this.Controls.Add(this.CBVisiteur);
            this.Name = "fConsulterFichesFrais";
            this.Text = "fConsulterFichesFrais";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FConsulterFichesFrais_FormClosing);
            this.Load += new System.EventHandler(this.FConsulterFichesFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFicheFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNomVis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceFicheFrais;
        private System.Windows.Forms.ComboBox CBVisiteur;
        private System.Windows.Forms.BindingSource bindingSourceVisiteur;
        private System.Windows.Forms.BindingSource bindingSourceNomVis;
        private System.Windows.Forms.Label labVisit;
        private System.Windows.Forms.Label labVille;
        private System.Windows.Forms.BindingSource bindingSourceRegion;
        private System.Windows.Forms.Label labDEmbau;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbDateEmb;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.Label labRue;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.Label labCP;
        private System.Windows.Forms.TextBox tbLab;
        private System.Windows.Forms.Label lalLab;
        private System.Windows.Forms.ComboBox cbFicheFrais;
        private System.Windows.Forms.TextBox tbMois;
        private System.Windows.Forms.Label labMois;
        private System.Windows.Forms.TextBox tbNbJust;
        private System.Windows.Forms.Label labNbJust;
    }
}