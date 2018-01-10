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
    public partial class GestionVoiture : Form
    {
        public GestionVoiture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnregistrerVoiture fv = new EnregistrerVoiture();
            fv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RechercheVoiture rv = new RechercheVoiture();
            rv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac3 = new Acceuil();
            ac3.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac6 = new Acceuil();
            ac6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connexion cx = new Connexion();
            cx.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Acceuil ac = new Acceuil();
            ac.Show();
        }
    }
}
