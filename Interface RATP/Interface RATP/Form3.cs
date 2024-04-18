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
    {   Menu _menu;
        public SpecialTickets(Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _menu.Show();
        }
    }
}
