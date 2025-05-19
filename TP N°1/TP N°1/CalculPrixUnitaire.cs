using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_N_1
{
    public partial class CalculPrixUnitaire : Form
    {
        public CalculPrixUnitaire()
        {
            InitializeComponent();
            lblErreur.Text = ""; // Initialisation du message d'erreur
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            lblErreur.Text = "";
            lblErreur.ForeColor = Color.Red;

            // Validation des champs
            if (string.IsNullOrWhiteSpace(txtPrixUnitaire.Text) ||
                string.IsNullOrWhiteSpace(txtQuantite.Text) ||
                string.IsNullOrWhiteSpace(txtTVA.Text))
            {
                lblErreur.Text = "Tous les champs sont obligatoires";
                return;
            }

            // Conversion et vérification des valeurs
            if (!decimal.TryParse(txtPrixUnitaire.Text, out decimal prix) || prix <= 0)
            {
                lblErreur.Text = "Prix unitaire invalide (doit être > 0)";
                txtPrixUnitaire.Focus();
                return;
            }

            if (!int.TryParse(txtQuantite.Text, out int quantite) || quantite <= 0)
            {
                lblErreur.Text = "Quantité invalide (doit être > 0)";
                txtQuantite.Focus();
                return;
            }

            if (!decimal.TryParse(txtTVA.Text, out decimal tva) || tva < 0 || tva > 100)
            {
                lblErreur.Text = "TVA invalide (doit être entre 0 et 100)";
                txtTVA.Focus();
                return;
            }

            // Calcul et affichage
            decimal total = prix * quantite * (1 + tva / 100);
            txtTotal.Text = total.ToString("0.00") + " €";
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            txtPrixUnitaire.Text = "";
            txtQuantite.Text = "";
            txtTVA.Text = "";
            txtTotal.Text = "";
            lblErreur.Text = "";
            txtPrixUnitaire.Focus() ;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
