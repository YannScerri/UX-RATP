///ETML
///Auteur : Yann Scerri
///Date : 30.05.2024
///Description : Vue pour acheter un ticket normal
using Interface_RATP.Controllers;
using Interface_RATP.Views;
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
    public partial class NormalTicketsView : Form
    {   public RatpController Controller { get; set; } //getter setter du Controller

        public enum Lang { FR, EN, SPA, GER, ITA } //énumérateur des langues disponibles
        public ResourceManager _resource; //variable privée pour accéder aux ressources
        
        private int _currentPrice = 0; //variable privée pour garder le prix en mémoire
        public NormalTicketsView()
        {
            InitializeComponent();
            UpdateText();
            
        }

        /// <summary>
        /// bouton pour revenir en arrière
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controller.ShowMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Ajouter un ticket adulte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAdultTicket_Click(object sender, EventArgs e)
        {
            Controller.AddAdultTicket();
            lblNumberOfAdultTicket.Text = Controller.AdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();


        }

        /// <summary>
        /// enlever un ticket adulte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveAdultTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveAdultTicket();
            lblNumberOfAdultTicket.Text = Controller.AdultTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();



        }
        /// <summary>
        /// ajouter un ticket enfant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddReducedTicket_Click(object sender, EventArgs e)
        {
            Controller.AddReducedTicket();
            lblNumberOfReducedTicket.Text = Controller.ReducedTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();

        }

        /// <summary>
        /// enlever un ticket enfant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveReducedTicket_Click(object sender, EventArgs e)
        {
            Controller.RemoveReducedTicket();
            lblNumberOfReducedTicket.Text = Controller.ReducedTicketCount.ToString();
            lblCurrentPriceInt.Text = Controller.TotalPrice.ToString();
        }

        /// <summary>
        /// change la langue en français
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblFrench_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.FR);
            Controller.UpdateText();
        }

        /// <summary>
        /// change la langue en anglais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblEnglish_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.EN);
            Controller.UpdateText();
        }

        /// <summary>
        /// change la langue en espagnol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSpanish_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.SPA);
            Controller.UpdateText();
        }

        /// <summary>
        /// change la langue en allemand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblGerman_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.GER);
            Controller.UpdateText();
        }

        /// <summary>
        /// change la langue en italien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblItalian_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.ITA);
            Controller.UpdateText();
        }

        /// <summary>
        /// passer à l'écran d'achat des billets spéciaux
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuySpecial_Click(object sender, EventArgs e)
        {

            Controller.ShowSpecialTickets();
            this.Hide();

        }

        /// <summary>
        /// passer à l'écran de paiement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPay_Click(object sender, EventArgs e)
        {   
            
            Controller.ShowPayment();
            this.Hide();
            
        }

        /// <summary>
        /// méthode pour mettre à jour les textes en cas de changement de langue
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
