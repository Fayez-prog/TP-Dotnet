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
    public partial class Dessiner : Form
    {
        public Dessiner()
        {
            InitializeComponent();
            // Double vérification des événements
            btnTriangle.Click += btnTriangle_Click;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLignes.Text, out int lignes) || !int.TryParse(txtColonnes.Text, out int colonnes))
            {
                lblErreur.Text = "Veuillez entrer des nombres valides";
                return;
            }

            if (lignes <= 0 || colonnes <= 0)
            {
                lblErreur.Text = "Les valeurs doivent être positives";
                return;
            }

            lblErreur.Text = "";
            string rectangle = "";

            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colonnes; j++)
                {
                    rectangle += "* ";
                }
                rectangle += "\n";
            }

            lblResultat.Text = rectangle;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            try
            {
                int lignes = int.Parse(txtLignes.Text);
                if (lignes < 1) throw new ArgumentException();

                lblResultat.Text = string.Join("\n",
                    Enumerable.Range(1, lignes).Select(i => new string('*', i)));
                lblErreur.Text = "";
            }
            catch
            {
                lblErreur.Text = "Entrez un nombre ≥ 1";
                lblResultat.Text = "";
            }
        }

    }
}
