namespace TP_N_1
{
    partial class Calculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculatrice));
            this.lblValeur1 = new System.Windows.Forms.Label();
            this.lblValeur2 = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.txtValeur1 = new System.Windows.Forms.TextBox();
            this.txtValeur2 = new System.Windows.Forms.TextBox();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSoustraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValeur1
            // 
            this.lblValeur1.AutoSize = true;
            this.lblValeur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeur1.Location = new System.Drawing.Point(91, 55);
            this.lblValeur1.Name = "lblValeur1";
            this.lblValeur1.Size = new System.Drawing.Size(94, 26);
            this.lblValeur1.TabIndex = 0;
            this.lblValeur1.Text = "Valeur1";
            // 
            // lblValeur2
            // 
            this.lblValeur2.AutoSize = true;
            this.lblValeur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeur2.Location = new System.Drawing.Point(91, 160);
            this.lblValeur2.Name = "lblValeur2";
            this.lblValeur2.Size = new System.Drawing.Size(94, 26);
            this.lblValeur2.TabIndex = 1;
            this.lblValeur2.Text = "Valeur2";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.ForeColor = System.Drawing.Color.Teal;
            this.lblResultat.Location = new System.Drawing.Point(91, 295);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(100, 26);
            this.lblResultat.TabIndex = 2;
            this.lblResultat.Text = "Resultat";
            this.lblResultat.Click += new System.EventHandler(this.lblResultat_Click);
            // 
            // txtValeur1
            // 
            this.txtValeur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeur1.Location = new System.Drawing.Point(347, 49);
            this.txtValeur1.Name = "txtValeur1";
            this.txtValeur1.Size = new System.Drawing.Size(100, 32);
            this.txtValeur1.TabIndex = 3;
            // 
            // txtValeur2
            // 
            this.txtValeur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeur2.Location = new System.Drawing.Point(347, 154);
            this.txtValeur2.Name = "txtValeur2";
            this.txtValeur2.Size = new System.Drawing.Size(100, 32);
            this.txtValeur2.TabIndex = 4;
            // 
            // txtResultat
            // 
            this.txtResultat.Enabled = false;
            this.txtResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultat.Location = new System.Drawing.Point(347, 289);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(100, 32);
            this.txtResultat.TabIndex = 5;
            // 
            // btnAddition
            // 
            this.btnAddition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddition.Image = ((System.Drawing.Image)(resources.GetObject("btnAddition.Image")));
            this.btnAddition.Location = new System.Drawing.Point(557, 80);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(60, 40);
            this.btnAddition.TabIndex = 6;
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSoustraction
            // 
            this.btnSoustraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoustraction.Image = ((System.Drawing.Image)(resources.GetObject("btnSoustraction.Image")));
            this.btnSoustraction.Location = new System.Drawing.Point(557, 160);
            this.btnSoustraction.Name = "btnSoustraction";
            this.btnSoustraction.Size = new System.Drawing.Size(60, 40);
            this.btnSoustraction.TabIndex = 7;
            this.btnSoustraction.UseVisualStyleBackColor = true;
            this.btnSoustraction.Click += new System.EventHandler(this.btnSoustraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Image = ((System.Drawing.Image)(resources.GetObject("btnMultiplication.Image")));
            this.btnMultiplication.Location = new System.Drawing.Point(557, 250);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(60, 40);
            this.btnMultiplication.TabIndex = 8;
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSoustraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.txtValeur2);
            this.Controls.Add(this.txtValeur1);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblValeur2);
            this.Controls.Add(this.lblValeur1);
            this.Name = "Calculatrice";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValeur1;
        private System.Windows.Forms.Label lblValeur2;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.TextBox txtValeur1;
        private System.Windows.Forms.TextBox txtValeur2;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSoustraction;
        private System.Windows.Forms.Button btnMultiplication;
    }
}

