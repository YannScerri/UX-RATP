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
    public partial class SpecialTickets : Form
    {   MenuView _menu;
        public SpecialTickets(MenuView menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _menu.Show();
        }

        private void btnAddDisneyAdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfDisneyAdultTicket.Text);
            currentValue++;
            lblNumberOfDisneyAdultTicket.Text = currentValue.ToString();
        }

        private void btnRemoveDisneyAdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfDisneyAdultTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfDisneyAdultTicket.Text = currentValue.ToString();
            }
        }

        private void btnAddDisneyChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfDisneyChildTicket.Text);
            currentValue++;
            lblNumberOfDisneyChildTicket.Text = currentValue.ToString();
        }

        private void btnRemoveDisneyChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfDisneyChildTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfDisneyChildTicket.Text = currentValue.ToString();
            }
        }
    }
}
