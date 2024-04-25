using Interface_RATP.Controllers;
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
    public partial class NormalTickets : Form
    {   public RatpController Controller { get; set; }
        MenuView _menu;

        private int currentPrice = 0;
        public NormalTickets(MenuView menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        public NormalTickets()
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfAdultTicket.Text);
            currentValue++;
            lblNumberOfAdultTicket.Text = currentValue.ToString();

            // Augmente le prix actuel de 5
            currentPrice += 5;
            lblCurrentPriceInt.Text = currentPrice.ToString();
        }

        private void btnRemoveAdultTicket_Click(object sender, EventArgs e)
        {   
            int currentValue = int.Parse(lblNumberOfAdultTicket.Text);
            if (currentValue > 0) 
            {
                currentValue--;
                lblNumberOfAdultTicket.Text = currentValue.ToString();

                // Réduit le prix actuel de 5
                if (currentPrice >= 5)
                {
                    currentPrice -= 5;
                    lblCurrentPriceInt.Text = currentPrice.ToString();
                }
            }
            
        }

        private void btnAddReducedTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfReducedTicket.Text);
            currentValue++;
            lblNumberOfReducedTicket.Text = currentValue.ToString();
        }

        private void btnRemoveReducedTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfReducedTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfReducedTicket.Text = currentValue.ToString();
            }
        }

        private void lblFrench_Click(object sender, EventArgs e)
        {

        }

        private void lblEnglish_Click(object sender, EventArgs e)
        {

        }

        private void lblSpanish_Click(object sender, EventArgs e)
        {

        }

        private void lblGerman_Click(object sender, EventArgs e)
        {

        }
    }
}
