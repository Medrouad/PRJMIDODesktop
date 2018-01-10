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
    public partial class FicheClient : Form
    {
        private Client client;

        public FicheClient(string adresseMail)
        {
            client = ControleurClient.getClient(adresseMail);
            InitializeComponent();
            completerFenetre();
        }

        public void completerFenetre()
        {
            nom.Text = client.Nom;
            prenom.Text = client.Prenom;
            dateNaissance.Text = client.DateNaissance.ToString("dd-MM-yyyy");
            adresse.Text = client.Adresse;
            telephone.Text = client.Telephone;
            adresseMail.Text = client.AdresseMail;
            heureEffective.Text = ControleurClient.getNombreHeureEffectiveClient(client.AdresseMail).ToString();
            List<Reservation> reservations = ControleurReservation.getReservationClient(client.AdresseMail);
            foreach (Reservation reservation in reservations)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(planning, reservation.Moniteur.Nom+" "+ reservation.Moniteur.Prenom, reservation.Vehicule.Immatriculation, reservation.Date.ToString());
                planning.Rows.Add(row);
            }
            this.pictureBox1.Image = Image.FromFile(GestionPhoto.afficherImageClient(client.AdresseMail));
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FicheClient_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void typeFC_Click(object sender, EventArgs e)
        {

        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void planning_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControleurPaiement.enregistrerPaiement(client.AdresseMail, typePaiment.Text, Convert.ToDouble(montantPaiment.Text));
            MessageBox.Show("paiement de "+ montantPaiment.Text+"€ enregistré");
            this.Show();
        }

        private void typePaiment_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac2 = new Acceuil();
            ac2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connexion cx = new Connexion();
            cx.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jour2 = jour.Value.ToString("yyyy-MM-dd HH:mm:ss").Split(' ')[0];
            string date1 = jour2 + " 00:00:00";
            DateTime tmp = Outils.convertirStringToDateTime(date1);
            int res = GestionReservation.effectuerReservation(client.AdresseMail,heure.Text,tmp);
            if (res == -1 || res ==0 )
            {
                MessageBox.Show("reservation non effectuée car pas de disponibilité");
                this.Show();
            }
            else
            {
                MessageBox.Show("reservation effectuée");
                this.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionClient gc = new GestionClient();
            gc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionPDF.genererPDFClient(client.AdresseMail);
            MessageBox.Show("pdf généré à la racine du projet IHM");
            this.Show();
        }

       private void pictureBox1_Click(object sender, EventArgs e)
       {
            this.pictureBox1.Image = Image.FromFile(GestionPhoto.afficherImageClient(client.AdresseMail));
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
