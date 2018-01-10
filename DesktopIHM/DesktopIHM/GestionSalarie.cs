using System;
using System.IO;
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
    public partial class GestionSalarie : Form
    {
        private string urlImage;

        public GestionSalarie()
        {
            InitializeComponent();
        }

        private void GestionSalarie_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac2 = new Acceuil();
            ac2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Acceuil ac6 = new Acceuil();
            ac6.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Connexion cx = new Connexion();
            cx.Show();
        }

        private void buttonPacourirPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choisissez une image(*.jpg;  *.png; *.gif)|*.jpg;  *.png; *.gif)";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                opf.CheckFileExists = false;
                urlImage = opf.FileName;
                urlImage = Path.GetFileName(urlImage);
                urlImage = "C:\\Users\\med\\Documents\\Visual Studio 2015\\Projects\\DesktopIHM\\DesktopIHM\\Images\\" + urlImage;
                MessageBox.Show(urlImage);
                this.Show();
            }
        }

        private void button_EnregisterClient_Click(object sender, EventArgs e)
        {
            ControleurMoniteur.enregistrerMoniteur(nom.Text, prenom.Text, dateNaissance.Value.Date,
            adresse.Text, telephone.Text, adresseMail.Text, "");
            GestionPhoto.insererImageMoniteur(adresseMail.Text, urlImage);
            MessageBox.Show("moniteur ajouté");
            this.Show();
        }

        private void dateDeNaissance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RechercherClient_Click(object sender, EventArgs e)
        {
            resultatRechercheMoniteur.Rows.Clear();
            resultatRechercheMoniteur.Refresh();
            List<Moniteur> moniteurs = ControleurMoniteur.rechercherMoniteur(nomRecherche.Text, prenomRecherche.Text);
            foreach (Moniteur moniteur in moniteurs)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(resultatRechercheMoniteur, moniteur.Nom, moniteur.Prenom, moniteur.Telephone, moniteur.AdresseMail);
                resultatRechercheMoniteur.Rows.Add(row);
            }
        }

        private void resultatRechercheMoniteur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (resultatRechercheMoniteur.Columns[e.ColumnIndex].Name == "profilResultat")
            {
               

                this.Hide();
                FicheSalarie fc = new FicheSalarie(resultatRechercheMoniteur.Rows[e.RowIndex].Cells[3].Value.ToString());
                fc.Show();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }
    }
}

