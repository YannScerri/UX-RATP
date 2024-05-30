///ETML
///Auteur : Yann Scerri
///Date : 30.05.2024
///Description : Vue pour afficher l'écran final d'après paiement
using Interface_RATP.Controllers;
using Interface_RATP.Properties;
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
    public partial class GoodbyeView : Form
    {
        
        public RatpController Controller { get; set; }
        public enum Lang { FR, EN, SPA, GER, ITA }
        private ResourceManager _resource;

        public GoodbyeView()
        {
            
            InitializeComponent();
            UpdateText();
            
        }

        private void GoodbyeView_Load(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(5000);
            //Controller.ShowMenu();
            //this.Hide();
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
    }
}
