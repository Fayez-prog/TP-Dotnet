namespace TP_N_1
{
    partial class GestionTemperature
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
            this.grpJours = new System.Windows.Forms.GroupBox();
            this.grpMoyenne = new System.Windows.Forms.GroupBox();
            this.lblDimanche = new System.Windows.Forms.Label();
            this.lblLundi = new System.Windows.Forms.Label();
            this.lblMardi = new System.Windows.Forms.Label();
            this.lblMercredi = new System.Windows.Forms.Label();
            this.lblJeudi = new System.Windows.Forms.Label();
            this.lblVendredi = new System.Windows.Forms.Label();
            this.lblSamedi = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtDimanche = new System.Windows.Forms.TextBox();
            this.txtLundi = new System.Windows.Forms.TextBox();
            this.txtMardi = new System.Windows.Forms.TextBox();
            this.txtMercredi = new System.Windows.Forms.TextBox();
            this.txtJeudi = new System.Windows.Forms.TextBox();
            this.txtVendredi = new System.Windows.Forms.TextBox();
            this.txtSamedi = new System.Windows.Forms.TextBox();
            this.txtMoyenne = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.grpJours.SuspendLayout();
            this.grpMoyenne.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpJours
            // 
            this.grpJours.Controls.Add(this.btnCalculer);
            this.grpJours.Controls.Add(this.txtSamedi);
            this.grpJours.Controls.Add(this.txtVendredi);
            this.grpJours.Controls.Add(this.txtJeudi);
            this.grpJours.Controls.Add(this.txtMercredi);
            this.grpJours.Controls.Add(this.txtMardi);
            this.grpJours.Controls.Add(this.txtLundi);
            this.grpJours.Controls.Add(this.txtDimanche);
            this.grpJours.Controls.Add(this.lblSamedi);
            this.grpJours.Controls.Add(this.lblVendredi);
            this.grpJours.Controls.Add(this.lblJeudi);
            this.grpJours.Controls.Add(this.lblMercredi);
            this.grpJours.Controls.Add(this.lblMardi);
            this.grpJours.Controls.Add(this.lblLundi);
            this.grpJours.Controls.Add(this.lblDimanche);
            this.grpJours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpJours.Location = new System.Drawing.Point(101, 29);
            this.grpJours.Name = "grpJours";
            this.grpJours.Size = new System.Drawing.Size(588, 272);
            this.grpJours.TabIndex = 0;
            this.grpJours.TabStop = false;
            this.grpJours.Text = "Saisie des temperatures par jour";
            // 
            // grpMoyenne
            // 
            this.grpMoyenne.Controls.Add(this.txtMoyenne);
            this.grpMoyenne.Controls.Add(this.lblTemperature);
            this.grpMoyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMoyenne.Location = new System.Drawing.Point(152, 324);
            this.grpMoyenne.Name = "grpMoyenne";
            this.grpMoyenne.Size = new System.Drawing.Size(485, 100);
            this.grpMoyenne.TabIndex = 1;
            this.grpMoyenne.TabStop = false;
            this.grpMoyenne.Text = "Statistiques";
            // 
            // lblDimanche
            // 
            this.lblDimanche.AutoSize = true;
            this.lblDimanche.Location = new System.Drawing.Point(18, 46);
            this.lblDimanche.Name = "lblDimanche";
            this.lblDimanche.Size = new System.Drawing.Size(119, 26);
            this.lblDimanche.TabIndex = 0;
            this.lblDimanche.Text = "Dimanche";
            // 
            // lblLundi
            // 
            this.lblLundi.AutoSize = true;
            this.lblLundi.Location = new System.Drawing.Point(42, 103);
            this.lblLundi.Name = "lblLundi";
            this.lblLundi.Size = new System.Drawing.Size(70, 26);
            this.lblLundi.TabIndex = 1;
            this.lblLundi.Text = "Lundi";
            // 
            // lblMardi
            // 
            this.lblMardi.AutoSize = true;
            this.lblMardi.Location = new System.Drawing.Point(42, 157);
            this.lblMardi.Name = "lblMardi";
            this.lblMardi.Size = new System.Drawing.Size(71, 26);
            this.lblMardi.TabIndex = 2;
            this.lblMardi.Text = "Mardi";
            // 
            // lblMercredi
            // 
            this.lblMercredi.AutoSize = true;
            this.lblMercredi.Location = new System.Drawing.Point(18, 213);
            this.lblMercredi.Name = "lblMercredi";
            this.lblMercredi.Size = new System.Drawing.Size(104, 26);
            this.lblMercredi.TabIndex = 3;
            this.lblMercredi.Text = "Mercredi";
            // 
            // lblJeudi
            // 
            this.lblJeudi.AutoSize = true;
            this.lblJeudi.Location = new System.Drawing.Point(343, 46);
            this.lblJeudi.Name = "lblJeudi";
            this.lblJeudi.Size = new System.Drawing.Size(69, 26);
            this.lblJeudi.TabIndex = 4;
            this.lblJeudi.Text = "Jeudi";
            // 
            // lblVendredi
            // 
            this.lblVendredi.AutoSize = true;
            this.lblVendredi.Location = new System.Drawing.Point(321, 103);
            this.lblVendredi.Name = "lblVendredi";
            this.lblVendredi.Size = new System.Drawing.Size(107, 26);
            this.lblVendredi.TabIndex = 5;
            this.lblVendredi.Text = "Vendredi";
            // 
            // lblSamedi
            // 
            this.lblSamedi.AutoSize = true;
            this.lblSamedi.Location = new System.Drawing.Point(321, 157);
            this.lblSamedi.Name = "lblSamedi";
            this.lblSamedi.Size = new System.Drawing.Size(93, 26);
            this.lblSamedi.TabIndex = 6;
            this.lblSamedi.Text = "Samedi";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(40, 50);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(249, 26);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "Temperature Moyenne";
            // 
            // txtDimanche
            // 
            this.txtDimanche.Location = new System.Drawing.Point(155, 43);
            this.txtDimanche.Name = "txtDimanche";
            this.txtDimanche.Size = new System.Drawing.Size(100, 32);
            this.txtDimanche.TabIndex = 7;
            // 
            // txtLundi
            // 
            this.txtLundi.Location = new System.Drawing.Point(155, 100);
            this.txtLundi.Name = "txtLundi";
            this.txtLundi.Size = new System.Drawing.Size(100, 32);
            this.txtLundi.TabIndex = 8;
            // 
            // txtMardi
            // 
            this.txtMardi.Location = new System.Drawing.Point(155, 157);
            this.txtMardi.Name = "txtMardi";
            this.txtMardi.Size = new System.Drawing.Size(100, 32);
            this.txtMardi.TabIndex = 9;
            // 
            // txtMercredi
            // 
            this.txtMercredi.Location = new System.Drawing.Point(155, 213);
            this.txtMercredi.Name = "txtMercredi";
            this.txtMercredi.Size = new System.Drawing.Size(100, 32);
            this.txtMercredi.TabIndex = 10;
            // 
            // txtJeudi
            // 
            this.txtJeudi.Location = new System.Drawing.Point(444, 46);
            this.txtJeudi.Name = "txtJeudi";
            this.txtJeudi.Size = new System.Drawing.Size(100, 32);
            this.txtJeudi.TabIndex = 11;
            // 
            // txtVendredi
            // 
            this.txtVendredi.Location = new System.Drawing.Point(444, 103);
            this.txtVendredi.Name = "txtVendredi";
            this.txtVendredi.Size = new System.Drawing.Size(100, 32);
            this.txtVendredi.TabIndex = 12;
            // 
            // txtSamedi
            // 
            this.txtSamedi.Location = new System.Drawing.Point(444, 157);
            this.txtSamedi.Name = "txtSamedi";
            this.txtSamedi.Size = new System.Drawing.Size(100, 32);
            this.txtSamedi.TabIndex = 13;
            // 
            // txtMoyenne
            // 
            this.txtMoyenne.Location = new System.Drawing.Point(328, 50);
            this.txtMoyenne.Name = "txtMoyenne";
            this.txtMoyenne.Size = new System.Drawing.Size(100, 32);
            this.txtMoyenne.TabIndex = 1;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculer.Location = new System.Drawing.Point(379, 202);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(122, 46);
            this.btnCalculer.TabIndex = 14;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // GestionTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpMoyenne);
            this.Controls.Add(this.grpJours);
            this.Name = "GestionTemperature";
            this.Text = "GestionTemperature";
            this.grpJours.ResumeLayout(false);
            this.grpJours.PerformLayout();
            this.grpMoyenne.ResumeLayout(false);
            this.grpMoyenne.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpJours;
        private System.Windows.Forms.GroupBox grpMoyenne;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.TextBox txtSamedi;
        private System.Windows.Forms.TextBox txtVendredi;
        private System.Windows.Forms.TextBox txtJeudi;
        private System.Windows.Forms.TextBox txtMercredi;
        private System.Windows.Forms.TextBox txtMardi;
        private System.Windows.Forms.TextBox txtLundi;
        private System.Windows.Forms.TextBox txtDimanche;
        private System.Windows.Forms.Label lblSamedi;
        private System.Windows.Forms.Label lblVendredi;
        private System.Windows.Forms.Label lblJeudi;
        private System.Windows.Forms.Label lblMercredi;
        private System.Windows.Forms.Label lblMardi;
        private System.Windows.Forms.Label lblLundi;
        private System.Windows.Forms.Label lblDimanche;
        private System.Windows.Forms.TextBox txtMoyenne;
        private System.Windows.Forms.Label lblTemperature;
    }
}