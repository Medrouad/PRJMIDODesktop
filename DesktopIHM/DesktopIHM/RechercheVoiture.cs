using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopIHM
{
    public partial class RechercheVoiture : Form
    {
        public RechercheVoiture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultatVoiture.Rows.Clear();
            resultatVoiture.Refresh();
            List<Vehicule> vehicules = ControleurVehicule.rechercherVehicule(immatriculation.Text, marqueVoiture.Text, modeleVoiture.Text);
            foreach (Vehicule vehicule in vehicules)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(resultatVoiture,vehicule.Immatriculation,vehicule.Marque,vehicule.Modele);
                resultatVoiture.Rows.Add(row);
            }
        }

        private void resultatVoiture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (resultatVoiture.Columns[e.ColumnIndex].Name == "Column1PageVoiture")
            {
                MessageBox.Show(resultatVoiture.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Show();
                this.Hide();
                FicheVoiture fv = new FicheVoiture(resultatVoiture.Rows[e.RowIndex].Cells[0].Value.ToString());
                fv.Show();
            }
            else
            {
                MessageBox.Show("nok");
                this.Show();
            }
        }

        private void immatriculation_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionVoiture gv3 = new GestionVoiture();
            gv3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
