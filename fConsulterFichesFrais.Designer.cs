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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFicheFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFicheFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFicheFrais
            // 
            this.dataGridViewFicheFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFicheFrais.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewFicheFrais.Name = "dataGridViewFicheFrais";
            this.dataGridViewFicheFrais.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewFicheFrais.TabIndex = 0;
            // 
            // fConsulterFichesFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewFicheFrais);
            this.Name = "fConsulterFichesFrais";
            this.Text = "fConsulterFichesFrais";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFicheFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFicheFrais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceFicheFrais;
        private System.Windows.Forms.DataGridView dataGridViewFicheFrais;
    }
}