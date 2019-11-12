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
            this.dgvVisiteurGestion = new System.Windows.Forms.DataGridView();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsGestionSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurGestion)).BeginInit();
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
            // dgvVisiteurGestion
            // 
            this.dgvVisiteurGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurGestion.Location = new System.Drawing.Point(32, 83);
            this.dgvVisiteurGestion.Name = "dgvVisiteurGestion";
            this.dgvVisiteurGestion.Size = new System.Drawing.Size(673, 197);
            this.dgvVisiteurGestion.TabIndex = 1;
            this.dgvVisiteurGestion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(680, 404);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(98, 34);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // FrmGestionSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dgvVisiteurGestion);
            this.Controls.Add(this.cboGestionSecteur);
            this.Name = "FrmGestionSecteur";
            this.Text = "FrmGestionSecteur";
            this.Load += new System.EventHandler(this.FrmGestionSecteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsGestionSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsGestionSecteur;
        private System.Windows.Forms.ComboBox cboGestionSecteur;
        private System.Windows.Forms.DataGridView dgvVisiteurGestion;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Button btnRetour;
    }
}