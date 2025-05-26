namespace TP_N_1
{
    partial class CalculPrixUnitaire
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
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblQuantité = new System.Windows.Forms.Label();
            this.lblTVA = new System.Windows.Forms.Label();
            this.lblPourcentage = new System.Windows.Forms.Label();
            this.txtPrixUnitaire = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtTVA = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblErr = new System.Windows.Forms.Label();
            this.lblErreur = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(89, 71);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(144, 26);
            this.lblPrix.TabIndex = 0;
            this.lblPrix.Text = "Prix Unitaire";
            // 
            // lblQuantité
            // 
            this.lblQuantité.AutoSize = true;
            this.lblQuantité.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantité.Location = new System.Drawing.Point(107, 158);
            this.lblQuantité.Name = "lblQuantité";
            this.lblQuantité.Size = new System.Drawing.Size(102, 26);
            this.lblQuantité.TabIndex = 1;
            this.lblQuantité.Text = "Quantité";
            // 
            // lblTVA
            // 
            this.lblTVA.AutoSize = true;
            this.lblTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTVA.Location = new System.Drawing.Point(125, 245);
            this.lblTVA.Name = "lblTVA";
            this.lblTVA.Size = new System.Drawing.Size(57, 26);
            this.lblTVA.TabIndex = 2;
            this.lblTVA.Text = "TVA";
            // 
            // lblPourcentage
            // 
            this.lblPourcentage.AutoSize = true;
            this.lblPourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPourcentage.Location = new System.Drawing.Point(530, 245);
            this.lblPourcentage.Name = "lblPourcentage";
            this.lblPourcentage.Size = new System.Drawing.Size(33, 26);
            this.lblPourcentage.TabIndex = 3;
            this.lblPourcentage.Text = "%";
            // 
            // txtPrixUnitaire
            // 
            this.txtPrixUnitaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixUnitaire.Location = new System.Drawing.Point(395, 65);
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.Size = new System.Drawing.Size(100, 32);
            this.txtPrixUnitaire.TabIndex = 4;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantite.Location = new System.Drawing.Point(395, 152);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(100, 32);
            this.txtQuantite.TabIndex = 5;
            // 
            // txtTVA
            // 
            this.txtTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTVA.Location = new System.Drawing.Point(395, 239);
            this.txtTVA.Name = "txtTVA";
            this.txtTVA.Size = new System.Drawing.Size(100, 32);
            this.txtTVA.TabIndex = 6;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculer.Location = new System.Drawing.Point(89, 298);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(120, 44);
            this.btnCalculer.TabIndex = 7;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // btnVider
            // 
            this.btnVider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.Location = new System.Drawing.Point(337, 298);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(120, 44);
            this.btnVider.TabIndex = 8;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(593, 298);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(120, 44);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErr.Location = new System.Drawing.Point(390, 355);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(78, 26);
            this.lblErr.TabIndex = 10;
            this.lblErr.Text = "Erreur";
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(255, 396);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 26);
            this.lblErreur.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(600, 100);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(149, 26);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Prix d\'achats";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(605, 152);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(144, 32);
            this.txtTotal.TabIndex = 13;
            // 
            // CalculPrixUnitaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.txtTVA);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtPrixUnitaire);
            this.Controls.Add(this.lblPourcentage);
            this.Controls.Add(this.lblTVA);
            this.Controls.Add(this.lblQuantité);
            this.Controls.Add(this.lblPrix);
            this.Name = "CalculPrixUnitaire";
            this.Text = "CalculPrixUnitaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblQuantité;
        private System.Windows.Forms.Label lblTVA;
        private System.Windows.Forms.Label lblPourcentage;
        private System.Windows.Forms.TextBox txtPrixUnitaire;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtTVA;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}