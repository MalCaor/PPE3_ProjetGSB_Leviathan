namespace PPE3_Leviathan
{
    partial class fModifFF
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
            this.bsFF = new System.Windows.Forms.BindingSource(this.components);
            this.lTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitre
            // 
            this.lTitre.AutoSize = true;
            this.lTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitre.Location = new System.Drawing.Point(13, 13);
            this.lTitre.Name = "lTitre";
            this.lTitre.Size = new System.Drawing.Size(190, 31);
            this.lTitre.TabIndex = 0;
            this.lTitre.Text = "Etat de Frais : ";
            // 
            // fModifFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lTitre);
            this.Name = "fModifFF";
            this.Text = "fModifFF";
            ((System.ComponentModel.ISupportInitialize)(this.bsFF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsFF;
        private System.Windows.Forms.Label lTitre;
    }
}