///ETML
///Auteur : Yann Scerri
///Date : 30.05.2024
///Description : Classe Controller du modèle MVC
using Interface_RATP.Models;
using Interface_RATP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_RATP.Controllers
{
    public class RatpController
    {
        private MenuView _view1;
        private NormalTicketsView _view2;
        private SpecialTicketsView _view3;
        private PaymentView _view4;
        private GoodbyeView _view5;
        private RatpModel _model;

        public int TotalPrice {  get; set; } //entier pour stocker le prix total
        public int AdultTicketCount { get; set; }
        public int ReducedTicketCount { get; set; }

        public int DisneyAdultTicketCount { get; set; }
        public int DisneyChildTicketCount { get; set; }
        public int Paris1AdultTicketCount { get; set; }
        public int Paris1ChildTicketCount { get; set; }
        public int Paris3AdultTicketCount { get; set; }
        public int Paris3ChildTicketCount { get; set; }
        public int Paris5AdultTicketCount { get; set; }
        public int Paris5ChildTicketCount { get; set; }
        public int AirportAdultTicketCount { get; set; }
        public int AirportChildTicketCount { get; set; }

        /// <summary>
        /// Constructeur du Controller
        /// </summary>
        /// <param name="view1">menu</param>
        /// <param name="view2">billets normaux</param>
        /// <param name="view3">billets spéciaux</param>
        /// <param name="view4">écran de paiement</param>
        /// <param name="view5">écran de remerciement</param>
        /// <param name="model"></param>
        public RatpController(MenuView view1, NormalTicketsView view2 , SpecialTicketsView view3 ,PaymentView view4, GoodbyeView view5, RatpModel model)
        {
            this._view1 = view1;
            this._view2 = view2;
            this._view3 = view3;
            this._view4 = view4;
            this._view5 = view5;
            this._model = model;

            this._view1.Controller = this;
            this._view2.Controller = this;
            this._view3.Controller = this;
            this._view4.Controller = this;
            this._view5.Controller = this;
            this._model.Controller = this;
        }

        /// <summary>
        /// méthode pour afficher le menu
        /// </summary>
        public void ShowMenu()
        {
            _view1.Show();
        }

        /// <summary>
        /// méthode pour afficher l'écran des billets standards
        /// </summary>
        public void ShowNormalTickets()
        {
            _view2.Show();
        }

        /// <summary>
        /// méthode pour afficher l'écran des billets spéciaux
        /// </summary>
        public void ShowSpecialTickets() 
        {
            _view3.Show();
        }

        /// <summary>
        /// méthode pour afficher l'écran de paiment
        /// </summary>
        public void ShowPayment()
        {   
            _view4.SetTotalPrice(TotalPrice);
            _view4.UpdateTicketRecap();
            _view4.Show();
        }

        /// <summary>
        /// méthode pour afficher l'écran de remerciement
        /// </summary>
        public void ShowThanks()
        {
            _view5.Show();
        }

        public int GetAdultPrice()
        {
            return _model.AdultPrice;
        }

        public int GetReducedPrice()
        {
            return _model.ReducedPrice;
        }

        public int GetDisneyAdultPrice() 
        {
            return _model.DisneyAdultPrice;
        }

        public int GetDisneyReducedPrice()
        {
            return _model.DisneyReducedPrice;
        }

        public int GetParis1AdultPrice()
        {
            return _model.Paris1AdultPrice;
        }

        public int GetReducedParis1Price()
        {
            return _model.Paris1ReducedPrice;
        }
        public int GetParis3AdultPrice()
        {
            return _model.Paris3AdultPrice;
        }
        public int GetReducedParis3Price()
        {
            return _model.Paris3ReducedPrice;
        }
        public int GetParis5AdultPrice()
        {
            return _model.Paris5AdultPrice;
        }

        public int GetParis5ReducedPrice()
        {
            return _model.Paris5ReducedPrice;
        }

        public int GetAdultAirportPrice()
        {
            return _model.AirportAdultPrice;
        }

        public int GetReducedAirportPrice()
        {
            return _model.AirportReducedPrice;
        }


        /// <summary>
        /// méthode regroupant les méthodes UpdateText des views
        /// </summary>
        public void UpdateText()
        {
            _view1.UpdateText();
            _view2.UpdateText();
            _view3.UpdateText();
            _view4.UpdateText();
            _view5.UpdateText();
        }

        public void AddAdultTicket()
        {
            AdultTicketCount++;
            TotalPrice += GetAdultPrice();
        }

        public void RemoveAdultTicket()
        {
            if (AdultTicketCount > 0)
            {
                AdultTicketCount--;
                TotalPrice -= GetAdultPrice();
            }
        }

        public void AddReducedTicket()
        {
            ReducedTicketCount++;
            TotalPrice += GetReducedPrice();
        }

        public void RemoveReducedTicket()
        {
            if (ReducedTicketCount > 0)
            {
                ReducedTicketCount--;
                TotalPrice -= GetReducedPrice();
            }
        }
        public void AddDisneyAdultTicket()
        {
            DisneyAdultTicketCount++;
            TotalPrice += GetDisneyAdultPrice();
        }

        public void RemoveDisneyAdultTicket()
        {
            if (DisneyAdultTicketCount > 0)
            {
                DisneyAdultTicketCount--;
                TotalPrice -= GetDisneyAdultPrice();
            }
        }

        public void AddDisneyChildTicket()
        {
            DisneyChildTicketCount++;
            TotalPrice += GetDisneyReducedPrice();
        }

        public void RemoveDisneyChildTicket()
        {
            if (DisneyChildTicketCount > 0)
            {
                DisneyChildTicketCount--;
                TotalPrice -= GetDisneyReducedPrice();
            }
        }
        public void AddParis1AdultTicket()
        {
            Paris1AdultTicketCount++;
            TotalPrice += GetParis1AdultPrice();
        }

        public void RemoveParis1AdultTicket()
        {
            if (Paris1AdultTicketCount > 0)
            {
                Paris1AdultTicketCount--;
                TotalPrice -= GetParis1AdultPrice();
            }
        }

        public void AddParis1ChildTicket()
        {
            Paris1ChildTicketCount++;
            TotalPrice += GetReducedParis1Price();
        }

        public void RemoveParis1ChildTicket()
        {
            if (Paris1ChildTicketCount > 0)
            {
                Paris1ChildTicketCount--;
                TotalPrice -= GetReducedParis1Price();
            }
        }
        public void AddParis3AdultTicket()
        {
            Paris3AdultTicketCount++;
            TotalPrice += GetParis3AdultPrice();
        }
        public void RemoveParis3AdultTicket()
        {
            if (Paris3AdultTicketCount > 0)
            {
                Paris3AdultTicketCount--;
                TotalPrice -= GetParis3AdultPrice();
            }
        }

        public void AddParis3ChildTicket()
        {
            Paris3ChildTicketCount++;
            TotalPrice += GetReducedParis3Price();
        }

        public void RemoveParis3ChildTicket()
        {
            if (Paris3ChildTicketCount > 0)
            {
                Paris3ChildTicketCount--;
                TotalPrice -= GetReducedParis3Price();
            }
        }

        public void AddParis5AdultTicket()
        {
            Paris5AdultTicketCount++;
            TotalPrice += GetParis5AdultPrice();
        }

        public void RemoveParis5AdultTicket()
        {
            if (Paris5AdultTicketCount > 0)
            {
                Paris5AdultTicketCount--;
                TotalPrice -= GetParis5AdultPrice();
            }
        }

        public void AddParis5ChildTicket()
        {
            Paris5ChildTicketCount++;
            TotalPrice += GetParis5ReducedPrice();
        }

        public void RemoveParis5ChildTicket()
        {
            if (Paris5ChildTicketCount > 0)
            {
                Paris5ChildTicketCount--;
                TotalPrice -= GetParis5ReducedPrice();
            }
        }

        public void AddAirportAdultTicket()
        {
            AirportAdultTicketCount++;
            TotalPrice += GetAdultAirportPrice();
        }

        public void RemoveAirportAdultTicket()
        {
            if (AirportAdultTicketCount > 0)
            {
                AirportAdultTicketCount--;
                TotalPrice -= GetAdultAirportPrice();
            }
        }

        public void AddAirportChildTicket()
        {
            AirportChildTicketCount++;
            TotalPrice += GetReducedAirportPrice();
        }

        public void RemoveAirportChildTicket()
        {
            if (AirportChildTicketCount > 0)
            {
                AirportChildTicketCount--;
                TotalPrice -= GetReducedAirportPrice();
            }
        }

    }
}
