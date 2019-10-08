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
            this.dataGridViewFicheFrais = new System.Windows.Forms.DataGridView();
            this.bindingSourceFicheFrais = new System.Windows.Forms.BindingSource(this.components);
            this.CBVisiteur = new System.Windows.Forms.ComboBox();
            this.bindingSourceVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceNomVis = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFiche = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFicheFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFicheFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNomVis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiche)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFicheFrais
            // 
            this.dataGridViewFicheFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFicheFrais.Location = new System.Drawing.Point(443, 12);
            this.dataGridViewFicheFrais.Name = "dataGridViewFicheFrais";
            this.dataGridViewFicheFrais.Size = new System.Drawing.Size(345, 194);
            this.dataGridViewFicheFrais.TabIndex = 0;
            // 
            // CBVisiteur
            // 
            this.CBVisiteur.FormattingEnabled = true;
            this.CBVisiteur.Location = new System.Drawing.Point(13, 13);
            this.CBVisiteur.Name = "CBVisiteur";
            this.CBVisiteur.Size = new System.Drawing.Size(121, 21);
            this.CBVisiteur.TabIndex = 1;
            this.CBVisiteur.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // dgvFiche
            // 
            this.dgvFiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiche.Location = new System.Drawing.Point(443, 227);
            this.dgvFiche.Name = "dgvFiche";
            this.dgvFiche.Size = new System.Drawing.Size(240, 150);
            this.dgvFiche.TabIndex = 2;
            // 
            // fConsulterFichesFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFiche);
            this.Controls.Add(this.CBVisiteur);
            this.Controls.Add(this.dataGridViewFicheFrais);
            this.Name = "fConsulterFichesFrais";
            this.Text = "fConsulterFichesFrais";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFicheFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFicheFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNomVis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceFicheFrais;
        private System.Windows.Forms.DataGridView dataGridViewFicheFrais;
        private System.Windows.Forms.ComboBox CBVisiteur;
        private System.Windows.Forms.BindingSource bindingSourceVisiteur;
        private System.Windows.Forms.BindingSource bindingSourceNomVis;
        private System.Windows.Forms.DataGridView dgvFiche;
    }
}