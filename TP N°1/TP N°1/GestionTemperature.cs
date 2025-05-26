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
    public partial class GestionTemperature : Form
    {
        public GestionTemperature()
        {
            InitializeComponent();
            grpMoyenne.Visible = false;
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            decimal[] temperatures = new decimal[7];
            try
            {
                temperatures[0] = Convert.ToDecimal(txtDimanche.Text);
                temperatures[1] = Convert.ToDecimal(txtLundi.Text);
                temperatures[2] = Convert.ToDecimal(txtMardi.Text);
                temperatures[3] = Convert.ToDecimal(txtMercredi.Text);
                temperatures[4] = Convert.ToDecimal(txtJeudi.Text);
                temperatures[5] = Convert.ToDecimal(txtVendredi.Text);
                temperatures[6] = Convert.ToDecimal(txtSamedi.Text);
            }
            catch
            {
                MessageBox.Show("Veuillez entrer des valeurs numériques valides");
                return;
            }

            decimal somme = 0;
            foreach (decimal temp in temperatures)
            {
                somme += temp;
            }

            decimal moyenne = somme / 7;
            txtMoyenne.Text = moyenne.ToString("F2");
            grpMoyenne.Visible = true;
        }
    }
}
