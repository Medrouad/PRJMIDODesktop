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
    public partial class FicheSalarie : Form
    {
        private Moniteur moniteur;

        public FicheSalarie(string adresseMail)
        {

            moniteur = ControleurMoniteur.getMoniteur(adresseMail);
            InitializeComponent();
            completerFenetre();
        }

        public void completerFenetre()
        {
            nom.Text = moniteur.Nom;
            prenom.Text = moniteur.Prenom;
            dateNaissance.Text = moniteur.DateNaissance.ToString("dd-MM-yyyy");
            adresse.Text = moniteur.Adresse;
            telephone.Text = moniteur.Telephone;
            adresseMail.Text = moniteur.AdresseMail;
            List<AgendaMoniteur> planning = ControleurAgendaMoniteur.getAgendaMoniteur(moniteur.AdresseMail);
            string etat = "";
            foreach (AgendaMoniteur a in planning)
            {
                DataGridViewRow row = new DataGridViewRow();
                if (a.Valeur == 1)
                    etat = "disponible";
                else
                    etat = "indisponible";
                row.CreateCells(agenda,a.Creneau.Creneau+"h",a.Jour.Jours,etat);
                agenda.Rows.Add(row);
            }
            this.pictureBox1.Image = Image.FromFile(GestionPhoto.afficherImageMoniteur(moniteur.AdresseMail));
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void heure_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac4 = new Acceuil();
            ac4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connexion cx = new Connexion();
            cx.Show();
        }

        private void FicheSalarie_Load(object sender, EventArgs e)
        {

        }

        private void adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionSalarie gs = new GestionSalarie();
            gs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionPDF.genererPDFMoniteur(moniteur.AdresseMail);
            MessageBox.Show("pdf généré à la racine du projet IHM");
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(GestionPhoto.afficherImageMoniteur(moniteur.AdresseMail));
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
