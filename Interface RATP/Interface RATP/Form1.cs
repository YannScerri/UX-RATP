using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_RATP
{
    public partial class Menu : Form
    {
        NormalTickets normalTickets;
        SpecialTickets specialTickets;
        public Menu()
        {
            InitializeComponent();
            normalTickets = new NormalTickets(this);
            specialTickets = new SpecialTickets(this);
        }

        private void lblFrench_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNormalHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les billets normaux comportent les options : Adulte et prix réduit", "Billets normaux.", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnSpecialHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les billets spéciaux comportent les options : billet DisneyLand, Passe visite 1-3-5 jours et billet aéroport (tous ces billets sont disponibles au prix adulte ou réduit.", "Billets spéciaux", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void lblNormalTickets_Click(object sender, EventArgs e)
        {
            NormalTickets normalTickets = new NormalTickets(this);
            normalTickets.Show();
            this.Hide();
        }

        private void lblSpecialTickets_Click(object sender, EventArgs e)
        {
            SpecialTickets specialTickets = new SpecialTickets(this);
            specialTickets.Show();
            this.Hide();
        }
    }
}
