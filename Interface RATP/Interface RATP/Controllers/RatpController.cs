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
        private MenuView view1;
        private RatpModel model;

        public RatpController(MenuView _view1, RatpModel _model)
        {
            view1 = _view1;
            model = _model;

            view1.Controller = this;
            model.Controller = this;
        }
    }
}
