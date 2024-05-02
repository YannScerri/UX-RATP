using Interface_RATP.Models;
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
        private RatpModel _model;

        public RatpController(MenuView view1, NormalTicketsView view2 , SpecialTicketsView view3 ,RatpModel model)
        {
            this._view1 = view1;
            this._view2 = view2;
            this._view3 = view3;    
            this._model = model;

            this._view1.Controller = this;
            this._view2.Controller = this;
            this._view3.Controller = this;
            this._model.Controller = this;
        }
    }
}
