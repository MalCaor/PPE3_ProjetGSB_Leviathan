namespace PPE3_Leviathan
{
    partial class FrmGestionSecteur
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
            this.bsGestionSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.cboGestionSecteur = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsGestionSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // bsGestionSecteur
            // 
            this.bsGestionSecteur.CurrentChanged += new System.EventHandler(this.BsGestionSecteur_CurrentChanged);
            // 
            // cboGestionSecteur
            // 
            this.cboGestionSecteur.FormattingEnabled = true;
            this.cboGestionSecteur.Location = new System.Drawing.Point(32, 33);
            this.cboGestionSecteur.Name = "cboGestionSecteur";
            this.cboGestionSecteur.Size = new System.Drawing.Size(121, 21);
            this.cboGestionSecteur.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 170);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmGestionSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboGestionSecteur);
            this.Name = "FrmGestionSecteur";
            this.Text = "FrmGestionSecteur";
            this.Load += new System.EventHandler(this.FrmGestionSecteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsGestionSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsGestionSecteur;
        private System.Windows.Forms.ComboBox cboGestionSecteur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsVisiteur;
    }
}