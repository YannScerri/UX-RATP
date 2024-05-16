﻿using Interface_RATP.Controllers;
using Interface_RATP.Models;
using Interface_RATP.Views;

//using Interface_RATP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_RATP
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //création des vues
            MenuView view1 = new MenuView();
            NormalTicketsView view2 = new NormalTicketsView();
            SpecialTicketsView view3 = new SpecialTicketsView();  
            PaymentView view4 = new PaymentView(view2);

            //création du modèle
            RatpModel model = new RatpModel();
            //création du contrôleur
            RatpController controller = new RatpController(view1,view2,view3,view4, model);

            Application.Run(view1);

        }
    }
}
