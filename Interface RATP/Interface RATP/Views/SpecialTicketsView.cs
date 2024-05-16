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
    public partial class SpecialTicketsView : Form
    {   public RatpController Controller { get; set; }
       
        private int currentPrice = 0;

        public SpecialTicketsView()
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Controller.ShowMenu();
            this.Hide();
            
        }

        private void btnAddDisneyAdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfDisneyAdultTicket.Text);
            currentValue++;
            lblNumberOfDisneyAdultTicket.Text = currentValue.ToString();

            currentPrice += 20;
            lblCurrentPriceInt.Text = currentPrice.ToString();
        }

        private void btnRemoveDisneyAdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfDisneyAdultTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfDisneyAdultTicket.Text = currentValue.ToString();
                
                if (currentPrice >= 20)
                {
                    currentPrice -= 20;
                    lblCurrentPriceInt.Text = currentPrice.ToString();
                }

            }

        }

        private void btnAddDisneyChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfDisneyChildTicket.Text);
            currentValue++;
            lblNumberOfDisneyChildTicket.Text = currentValue.ToString();

            currentPrice += 10;
            lblCurrentPriceInt.Text = currentPrice.ToString();
        }

        private void btnRemoveDisneyChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfDisneyChildTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfDisneyChildTicket.Text = currentValue.ToString();

                if (currentPrice >= 10)
                {
                    currentPrice -= 10;
                    lblCurrentPriceInt.Text = currentPrice.ToString();
                }
            }
        }

        private void btnAddParis1Adult_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis1AdultTicket.Text);
            currentValue++;
            lblNumberOfParis1AdultTicket.Text = currentValue.ToString();

            currentPrice += 15;
            lblCurrentPriceInt.Text = currentPrice.ToString();
        }

        private void btnRemoveParis1AdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis1AdultTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfParis1AdultTicket.Text = currentValue.ToString();

                if (currentPrice >= 15)
                {
                    currentPrice -= 15;
                    lblCurrentPriceInt.Text = currentPrice.ToString();
                }
            }
        }

        private void btnAddParis1ChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis1ChildTicket.Text);
            currentValue++;
            lblNumberOfParis1ChildTicket.Text = currentValue.ToString();

            currentPrice += 10;
            lblCurrentPriceInt.Text = currentPrice.ToString();
        }

        private void btnRemoveParis1ChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis1ChildTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfParis1ChildTicket.Text = currentValue.ToString();

                if (currentPrice >= 10)
                {
                    currentPrice -= 10;
                    lblCurrentPriceInt.Text = currentPrice.ToString();
                }
            }
        }

        private void btnAddParis3AdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis3AdultTicket.Text);
            currentValue++;
            lblNumberOfParis3AdultTicket.Text = currentValue.ToString();

            currentPrice += 30;
            lblCurrentPriceInt.Text = currentPrice.ToString();
        }

        private void btnRemoveParis3AdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis3AdultTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfParis3AdultTicket.Text = currentValue.ToString();

                if (currentPrice >= 30)
                {
                    currentPrice -= 30;
                    lblCurrentPriceInt.Text = currentPrice.ToString();
                }
            }
        }

        private void btnAddParis3ChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis3ChildTicket.Text);
            currentValue++;
            lblNumberOfParis3ChildTicket.Text = currentValue.ToString();

            currentPrice += 25;
            lblCurrentPriceInt.Text = currentPrice.ToString();
        }

        private void btnRemoveParis3ChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis3ChildTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfParis3ChildTicket.Text = currentValue.ToString();

                if (currentPrice >= 25)
                {
                    currentPrice -= 25;
                    lblCurrentPriceInt.Text = currentPrice.ToString();
                }
            }
        }

        private void btnAddParis5AdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis5AdultTicket.Text);
            currentValue++;
            lblNumberOfParis5AdultTicket.Text = currentValue.ToString();

            currentPrice += 60;
            lblCurrentPriceInt.Text = currentPrice.ToString();
        }

        private void btnRemoveParis5AdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis5AdultTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfParis5AdultTicket.Text = currentValue.ToString();

                if (currentPrice >= 60)
                {
                    currentPrice -= 60;
                    lblCurrentPriceInt.Text = currentPrice.ToString();
                }
            }
        }

        private void btnAddParisChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis5ChildTicket.Text);
            currentValue++;
            lblNumberOfParis5ChildTicket.Text = currentValue.ToString();

            currentPrice += 55;
            lblCurrentPriceInt.Text = currentPrice.ToString();
        }

        private void btnRemoveParis5ChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfParis5ChildTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfParis5ChildTicket.Text = currentValue.ToString();

                if (currentPrice >= 55)
                {
                    currentPrice -= 55;
                    lblCurrentPriceInt.Text = currentPrice.ToString();
                }
            }
        }

        private void btnAddAirportAdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfAirportAdultTicket.Text);
            currentValue++;
            lblNumberOfAirportAdultTicket.Text = currentValue.ToString();

            currentPrice += 10;
            lblCurrentPriceInt.Text = currentPrice.ToString();
        }

        private void btnRemoveAirportAdultTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfAirportAdultTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfAirportAdultTicket.Text = currentValue.ToString();

                if (currentPrice >= 10)
                {
                    currentPrice -= 10;
                    lblCurrentPriceInt.Text = currentPrice.ToString();
                }
            }
        }

        private void btnAddAirportChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfAirportChildTicket.Text);
            currentValue++;
            lblNumberOfAirportChildTicket.Text = currentValue.ToString();

            currentPrice += 5;
            lblCurrentPriceInt.Text = currentPrice.ToString();
        }

        private void btnRemoveAirportChildTicket_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(lblNumberOfAirportChildTicket.Text);
            if (currentValue > 0)
            {
                currentValue--;
                lblNumberOfAirportChildTicket.Text = currentValue.ToString();

                if (currentPrice >= 5)
                {
                    currentPrice -= 5;
                    lblCurrentPriceInt.Text = currentPrice.ToString();
                }
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyNormal_Click(object sender, EventArgs e)
        {
            Controller.ShowNormalTickets();
            this.Hide();
        }
    }
}
