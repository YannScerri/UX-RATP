///ETML
///Auteur : Yann Scerri
///Date : 30.05.2024
///Description : Vue pour acheter un ticket spécial
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

namespace Interface_RATP
{
    public partial class SpecialTicketsView : Form
    {   public RatpController Controller { get; set; } //getter setter du Controller
        public enum Lang { FR, EN, SPA, GER, ITA } //énumerateur des langues disponibles
        private ResourceManager _resource; //variables privée pour accéder aux ressources

        private int _currentPrice = 0; //variable privée pour garder en mémoire le prix actuel

        public SpecialTicketsView()
        {
            InitializeComponent();
            UpdateText();
        }

        /// <summary>
        /// pour retourner en arrière
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Controller.ShowMenu();
            this.Hide();
            
        }

        /// <summary>
        /// ajouter un billet disney
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDisneyAdultTicket_Click(object sender, EventArgs e)
        {
            Controller.AddDisneyAdultTicket();
            lblNumberOfDisneyAdultTicket.Text = Controller.DisneyAdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// enlever un billet disney
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveDisneyAdultTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveDisneyAdultTicket();
            lblNumberOfDisneyAdultTicket.Text = Controller.DisneyAdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();

        }

        /// <summary>
        /// ajouter un billet disney (enfant)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDisneyChildTicket_Click(object sender, EventArgs e)
        {
            Controller.AddDisneyChildTicket();
            lblNumberOfDisneyChildTicket.Text = Controller.DisneyChildTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// enlever un billet disney (enfant)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveDisneyChildTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveDisneyChildTicket();
            lblNumberOfDisneyChildTicket.Text = Controller.DisneyChildTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// ajouter un pass 1 jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddParis1Adult_Click(object sender, EventArgs e)
        {
            Controller.AddParis1AdultTicket();
            lblNumberOfParis1AdultTicket.Text = Controller.Paris1AdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// enlever un pass 1 jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveParis1AdultTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveParis1AdultTicket();
            lblNumberOfParis1AdultTicket.Text = Controller.Paris1AdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// ajouter un pass 1 jour (enfant)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddParis1ChildTicket_Click(object sender, EventArgs e)
        {
            Controller.AddParis1ChildTicket();
            lblNumberOfParis1ChildTicket.Text = Controller.Paris1ChildTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// enlever un pass 1 jour (enfant)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveParis1ChildTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveParis1ChildTicket();
            lblNumberOfParis1ChildTicket.Text = Controller.Paris1ChildTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// ajouter un pass 3 jours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddParis3AdultTicket_Click(object sender, EventArgs e)
        {
            Controller.AddParis3AdultTicket();
            lblNumberOfParis3AdultTicket.Text = Controller.Paris3AdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// enlever un pass 3 jours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveParis3AdultTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveParis3AdultTicket();
            lblNumberOfParis3AdultTicket.Text = Controller.Paris3AdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// ajouter un pass enfant 3 jours (enfant)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddParis3ChildTicket_Click(object sender, EventArgs e)
        {
            Controller.AddParis3ChildTicket();
            lblNumberOfParis3ChildTicket.Text = Controller.Paris3ChildTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// enlever un pass 3 jours (enfant)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveParis3ChildTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveParis3ChildTicket();
            lblNumberOfParis3ChildTicket.Text = Controller.Paris3ChildTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// ajouter un pass 5 jours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddParis5AdultTicket_Click(object sender, EventArgs e)
        {
            Controller.AddParis5AdultTicket();
            lblNumberOfParis5AdultTicket.Text = Controller.Paris5AdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// enlever un pass 5 jours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveParis5AdultTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveParis5AdultTicket();
            lblNumberOfParis5AdultTicket.Text = Controller.Paris5AdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// ajouter un pass 5 jour (enfant)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddParisChildTicket_Click(object sender, EventArgs e)
        {
            Controller.AddParis5ChildTicket();
            lblNumberOfParis5ChildTicket.Text = Controller.Paris5ChildTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// enlever un pass 5 jour (enfant)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveParis5ChildTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveParis5ChildTicket();
            lblNumberOfParis5ChildTicket.Text = Controller.Paris5ChildTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// ajouter un billet aéroport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAirportAdultTicket_Click(object sender, EventArgs e)
        {
            Controller.AddAirportAdultTicket();
            lblNumberOfAirportAdultTicket.Text = Controller.AirportAdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// enlever un billet aéroport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveAirportAdultTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveAirportAdultTicket();
            lblNumberOfAirportAdultTicket.Text = Controller.AirportAdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// ajouter un billet aéroport (enfant)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAirportChildTicket_Click(object sender, EventArgs e)
        {
            Controller.AddAirportChildTicket();
            lblNumberOfAirportChildTicket.Text = Controller.AirportChildTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// enlever un billet aéroport (enfant)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveAirportChildTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveAirportChildTicket();
            lblNumberOfAirportChildTicket.Text = Controller.AirportChildTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// passer à l'écran pour acheter des billets standards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuyNormal_Click(object sender, EventArgs e)
        {
            Controller.ShowNormalTickets();
            this.Hide();
        }

        /// <summary>
        /// passer à l'écran de paimement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPay_Click(object sender, EventArgs e)
        {
            Controller.ShowPayment();
            this.Hide();
        }

        /// <summary>
        /// passer en français
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblFrench_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.FR);
            Controller.UpdateText();
        }

        /// <summary>
        /// passer en anglais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblEnglish_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.EN);
            Controller.UpdateText();
        }

        /// <summary>
        /// passer en espagnol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSpanish_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.SPA);
            Controller.UpdateText();
        }

        /// <summary>
        /// passer en allemand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblGerman_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.GER);
            Controller.UpdateText();
        }

        /// <summary>
        /// passer en italien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblItalian_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.ITA);
            Controller.UpdateText();
        }

        /// <summary>
        /// mettre à jour le texte 
        /// </summary>
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
    }
}
