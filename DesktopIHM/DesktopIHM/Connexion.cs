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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            int res = ControleurGerant.connexionGerant(textBox1.Text,textBox2.Text);
            Console.WriteLine("res=" + res+" email:"+ textBox1.Text+" pwd:"+ textBox2.Text);

            if (res == -1)
            {
                MessageBox.Show("adresse mail invalide");
                this.Show();
            }
               
            else if (res == 0) {
                MessageBox.Show("mots de passse incorrect");
                this.Show();
            }
            else if(res==1){
                Acceuil ac = new Acceuil();
                ac.Show();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
