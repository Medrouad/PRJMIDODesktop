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
    public partial class FicheVoiture : Form
    {
        private Vehicule vehicule;

        public FicheVoiture(string immatriculation)
        {
            vehicule = ControleurVehicule.getVehicule(immatriculation);
            InitializeComponent();
            completerFenetre();
        }


        public void completerFenetre()
        {
            immatriculation.Text = vehicule.Immatriculation;
            marque.Text = vehicule.Marque;
            modele.Text = vehicule.Modele;
            couleur.Text = vehicule.Couleur;
            carburant.Text = vehicule.Carburant;

            List<Reservation> reservations = ControleurReservation.getReservationVehicule(vehicule.Immatriculation);
            foreach (Reservation reservation in reservations)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(pr, reservation.Moniteur.Nom + " " + reservation.Moniteur.Prenom, reservation.Client.Nom + " " + reservation.Client.Prenom, reservation.Date.ToString());
                pr.Rows.Add(row);
            }
            this.pictureBox1.Image = Image.FromFile(GestionPhoto.afficherImageVoiture(vehicule.Immatriculation));
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FicheVoiture_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionVoiture gv1 = new GestionVoiture();
            gv1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac3 = new Acceuil();
            ac3.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Connexion cx = new Connexion();
            cx.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(GestionPhoto.afficherImageMoniteur(vehicule.Immatriculation));
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
