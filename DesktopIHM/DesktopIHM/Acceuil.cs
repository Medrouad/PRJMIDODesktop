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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionSalarie gs = new GestionSalarie();
            gs.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionClient gc = new GestionClient();
            gc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionVoiture ev = new GestionVoiture();
            ev.Show();
        }

        private void deconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connexion cx = new Connexion();
            cx.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FicheGerant fg = new FicheGerant();
            fg.Show();
        }
    }
}
