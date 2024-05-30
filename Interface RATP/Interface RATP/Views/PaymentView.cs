///ETML
///Auteur : Yann Scerri
///Date : 30.05.2024
///Description : Vue pour le paiement
using Interface_RATP.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_RATP.Views
{
    public partial class PaymentView : Form
    {
        public RatpController Controller { get; set; }
        public enum Lang { FR, EN, SPA, GER, ITA }
        //private Lang _currentLanguage;
        private ResourceManager _resource;
        public PaymentView(NormalTicketsView normalTickets)
        {
            InitializeComponent();
            UpdateText();
        }

        private void PaymentView_Load(object sender, EventArgs e)
        {
            lblTotalPrice.Text = Controller.TotalPrice.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        { 
            Controller.ShowNormalTickets();
            this.Hide();
           
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblFrench_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.FR);
            Controller.UpdateText();
        }

        private void lblEnglish_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.EN);
            Controller.UpdateText();
        }

        private void lblSpanish_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.SPA);
            Controller.UpdateText();
        }

        private void lblGerman_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.GER);
            Controller.UpdateText();
        }

        private void lblItalian_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.ITA);
            Controller.UpdateText();
        }

        public void UpdateText()
        {
            _resource = Language.Instance;
            foreach (Control c in this.Controls)
            {
                if (_resource.GetString(c.Name) != null)
                {
                    c.Text = _resource.GetString(c.Name);
                }

            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Controller.ShowThanks();
            this.Hide();
        }

        public void SetTotalPrice(int totalPrice)
        {
            lblTotalPrice.Text = totalPrice.ToString();
        }
        /// <summary>
        /// méthode pour afficher le récapitulatif des billets
        /// </summary>
        public void UpdateTicketRecap()
        {
            StringBuilder recap = new StringBuilder();
            if (Controller.AdultTicketCount > 0)
            {
                recap.AppendLine($"Billets Adultes: {Controller.AdultTicketCount}");
            }
            if (Controller.ReducedTicketCount > 0)
            {
                recap.AppendLine($"Billets réduits: {Controller.ReducedTicketCount}");
            }

            if(Controller.DisneyAdultTicketCount > 0)
                recap.AppendLine($"Billets Disney adulte: {Controller.DisneyAdultTicketCount}");
            if (Controller.DisneyChildTicketCount > 0)
                recap.AppendLine($"Billets Disney enfant: {Controller.DisneyChildTicketCount}");
            if (Controller.Paris1AdultTicketCount > 0)
                recap.AppendLine($"Passe 1 jour adulte: {Controller.Paris1AdultTicketCount}");
            if (Controller.Paris1ChildTicketCount > 0)
                recap.AppendLine($"Passe 1 jour enfant: {Controller.Paris1ChildTicketCount}");
            if (Controller.Paris3AdultTicketCount > 0)
                recap.AppendLine($"Passe 3 jours adulte: {Controller.Paris3AdultTicketCount}");
            if (Controller.Paris3ChildTicketCount > 0)
                recap.AppendLine($"Passe 3 jours enfant: {Controller.Paris3ChildTicketCount}");
            if (Controller.Paris5AdultTicketCount > 0)
                recap.AppendLine($"Passe 5 jours adulte: {Controller.Paris5AdultTicketCount}");
            if (Controller.Paris5ChildTicketCount > 0)
                recap.AppendLine($"Passe 5 jours enfant: {Controller.Paris5ChildTicketCount}");
            if (Controller.AirportAdultTicketCount > 0)
                recap.AppendLine($"Billets aéroport adulte: {Controller.AirportAdultTicketCount}");
            if (Controller.AirportChildTicketCount > 0)
                recap.AppendLine($"Billets aéroport enfant: {Controller.AirportChildTicketCount}");

            lblTicketsRecap.Text = recap.ToString(); 
            lblTicketsRecap.Font = new Font(lblTicketsRecap.Font.FontFamily, 14); //ajuster la taille du texte
        }


        private void lblTicketsRecap_Click(object sender, EventArgs e)
        {

        }
    }
}
