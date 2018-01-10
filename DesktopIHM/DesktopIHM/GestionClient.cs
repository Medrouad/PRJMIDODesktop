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
    public partial class GestionClient : Form
    {
        private string urlImage;
        public GestionClient()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (resultatRecherche.Columns[e.ColumnIndex].Name == "Profil")
            {
                this.Hide();
                FicheClient fc = new FicheClient(resultatRecherche.Rows[e.RowIndex].Cells[3].Value.ToString());
                fc.Show();
            }
        }

        private void EnregistrerClient_Load(object sender, EventArgs e)
        {
            
        }

        private void button_EnregisterClient_Click(object sender, EventArgs e)
        {
            if(nom.Text != "" && prenom.Text != "" && adresse.Text != "" && telephone.Text != "" && adresseMail.Text!= "")
            {
                ControleurClient.enregistrerClient(nom.Text, prenom.Text, dateNaissance.Value.Date,
                adresse.Text, telephone.Text, adresseMail.Text, "");
                GestionPhoto.insererImageClient(adresseMail.Text, urlImage);
                MessageBox.Show("client ajouté");
                this.Show();
            }
            else
            {
                MessageBox.Show("saisie invalide");
                this.Show();
            }
               
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void RechercherClient_Click(object sender, EventArgs e)
        {
            resultatRecherche.Rows.Clear();
            resultatRecherche.Refresh();
            List<Client> clients = ControleurClient.rechercherClient(nomRecherche.Text, prenomRecherche.Text);
            foreach (Client client in clients)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(resultatRecherche, client.Nom, client.Prenom, client.Telephone, client.AdresseMail);
                resultatRecherche.Rows.Add(row);
            }
 
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxRechercheClient_Enter(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac1 = new Acceuil();
            ac1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Connexion cx = new Connexion();
            cx.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }
    }
}
