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

namespace Interface_RATP.Views
{
    public partial class PaymentView : Form
    {
        public RatpController Controller { get; set; }
        NormalTicketsView _normalTickets;
        public PaymentView(NormalTicketsView normalTickets)
        {
            InitializeComponent();
            _normalTickets = normalTickets;
        }

        private void PaymentView_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _normalTickets.Show();
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
