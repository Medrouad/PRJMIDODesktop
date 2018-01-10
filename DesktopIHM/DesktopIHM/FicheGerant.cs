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
    public partial class FicheGerant : Form
    {
        public FicheGerant()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Acceuil ac5 = new Acceuil();
            ac5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button_EnregisterClient_Click(object sender, EventArgs e)
        {
            ControleurGerant.enregistrerGerant(nom.Text, prenom.Text, dateNaissance.Value, adresse.Text, telephone.Text, adresse.Text, password.Text);
            MessageBox.Show("gérant ajouté");
            this.Show();
        }
    }
}
