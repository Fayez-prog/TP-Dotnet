namespace TP_N_1
{
    partial class Dessiner
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
            this.lblLigne = new System.Windows.Forms.Label();
            this.lblCologne = new System.Windows.Forms.Label();
            this.lblDessin = new System.Windows.Forms.Label();
            this.txtLignes = new System.Windows.Forms.TextBox();
            this.txtColonnes = new System.Windows.Forms.TextBox();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.lblErr = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLigne
            // 
            this.lblLigne.AutoSize = true;
            this.lblLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigne.Location = new System.Drawing.Point(69, 67);
            this.lblLigne.Name = "lblLigne";
            this.lblLigne.Size = new System.Drawing.Size(187, 26);
            this.lblLigne.TabIndex = 0;
            this.lblLigne.Text = "Nombre de ligne";
            // 
            // lblCologne
            // 
            this.lblCologne.AutoSize = true;
            this.lblCologne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCologne.Location = new System.Drawing.Point(69, 158);
            this.lblCologne.Name = "lblCologne";
            this.lblCologne.Size = new System.Drawing.Size(219, 26);
            this.lblCologne.TabIndex = 1;
            this.lblCologne.Text = "Nombre de cologne";
            // 
            // lblDessin
            // 
            this.lblDessin.AutoSize = true;
            this.lblDessin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDessin.Location = new System.Drawing.Point(192, 242);
            this.lblDessin.Name = "lblDessin";
            this.lblDessin.Size = new System.Drawing.Size(85, 26);
            this.lblDessin.TabIndex = 2;
            this.lblDessin.Text = "Dessin";
            // 
            // txtLignes
            // 
            this.txtLignes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLignes.Location = new System.Drawing.Point(396, 61);
            this.txtLignes.Name = "txtLignes";
            this.txtLignes.Size = new System.Drawing.Size(100, 32);
            this.txtLignes.TabIndex = 3;
            // 
            // txtColonnes
            // 
            this.txtColonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonnes.Location = new System.Drawing.Point(396, 152);
            this.txtColonnes.Name = "txtColonnes";
            this.txtColonnes.Size = new System.Drawing.Size(100, 32);
            this.txtColonnes.TabIndex = 4;
            // 
            // btnRectangle
            // 
            this.btnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangle.Location = new System.Drawing.Point(615, 52);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(130, 41);
            this.btnRectangle.TabIndex = 5;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriangle.Location = new System.Drawing.Point(615, 143);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(130, 41);
            this.btnTriangle.TabIndex = 6;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErr.Location = new System.Drawing.Point(525, 242);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(78, 26);
            this.lblErr.TabIndex = 7;
            this.lblErr.Text = "Erreur";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(233, 291);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 26);
            this.lblResultat.TabIndex = 8;
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.Location = new System.Drawing.Point(368, 302);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 26);
            this.lblErreur.TabIndex = 9;
            // 
            // DessinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.txtColonnes);
            this.Controls.Add(this.txtLignes);
            this.Controls.Add(this.lblDessin);
            this.Controls.Add(this.lblCologne);
            this.Controls.Add(this.lblLigne);
            this.Name = "DessinerForm";
            this.Text = "Dessiner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLigne;
        private System.Windows.Forms.Label lblCologne;
        private System.Windows.Forms.Label lblDessin;
        private System.Windows.Forms.TextBox txtLignes;
        private System.Windows.Forms.TextBox txtColonnes;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblErreur;
    }
}