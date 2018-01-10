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
    public partial class EnregistrerVoiture : Form
    {
        private string urlImage;


        public EnregistrerVoiture()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControleurVehicule.enregistrerVehicule(immatriculation.Text, marque.Text, modele.Text, couleur.Text, carburant.Text, "");
            GestionPhoto.insererImageVehicule(immatriculation.Text, urlImage);
            MessageBox.Show("vehicule ajouté");
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac1 = new Acceuil();
            ac1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connexion cx = new Connexion();
            cx.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionVoiture gv = new GestionVoiture();
            gv.Show();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choisissez une image(*.jpg;  *.png; *.gif)|*.jpg;  *.png; *.gif)";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                opf.CheckFileExists = false;
                urlImage = opf.FileName;
                urlImage = Path.GetFileName(urlImage);
                urlImage = "C:\\Users\\med\\Documents\\Visual Studio 2015\\Projects\\DesktopIHM\\DesktopIHM\\Images\\" + urlImage;
            }
        }
    }
}
