using Interface_RATP.Models;
using Interface_RATP.Views;

//using Interface_RATP.Views;
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
        private RatpModel _model;

        public int TotalPrice {  get; set; }

        public RatpController(MenuView view1, NormalTicketsView view2 , SpecialTicketsView view3 ,PaymentView view4, RatpModel model)
        {
            this._view1 = view1;
            this._view2 = view2;
            this._view3 = view3;
            this._view4 = view4;
            this._model = model;

            this._view1.Controller = this;
            this._view2.Controller = this;
            this._view3.Controller = this;
            this._view4.Controller = this;
            this._model.Controller = this;
        }

        public void ShowMenu()
        {
            _view1.Show();
        }

        public void ShowNormalTickets()
        {
            _view2.Show();
        }

        public void ShowSpecialTickets() 
        {
            _view3.Show();
        }
        public void ShowPayment()
        {   
            _view4.Show();
        }
    }   
}
