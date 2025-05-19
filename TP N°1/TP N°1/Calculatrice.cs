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
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
            txtResultat.ReadOnly = true;

            // Réassociation manuelle des événements (au cas où)
            btnSoustraction.Click += btnSoustraction_Click;
            btnMultiplication.Click += btnMultiplication_Click;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            Calculer((a, b) => a + b); // Addition
        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            Calculer((a, b) => a - b); // Soustraction
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Calculer((a, b) => a * b); // Multiplication
        }

        private void Calculer(Func<decimal, decimal, decimal> operation)
        {
            try
            {
                decimal val1 = Convert.ToDecimal(txtValeur1.Text);
                decimal val2 = Convert.ToDecimal(txtValeur2.Text);
                decimal result = operation(val1, val2);
                txtResultat.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez entrer des nombres valides.", "Erreur");
            }
        }

        private void lblResultat_Click(object sender, EventArgs e)
        {

        }
    }
}
