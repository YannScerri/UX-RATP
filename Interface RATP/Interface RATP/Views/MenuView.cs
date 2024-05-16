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
    public partial class MenuView : Form
    {
        public enum Lang { FR, EN, SPA, GER, ITA }
        public Lang _currentLanguage;
        public ResourceManager _resource;



        //string boxHelp1Text = "Les billets normaux comportent les options : Adulte et prix réduit";
        //string boxHelp2Text = "Les billets spéciaux comportent les options : billet DisneyLand, Passe visite 1-3-5 jours et billet aéroport (tous ces billets sont disponibles au prix adulte ou réduit.";
        //string boxHelp1Caption = "Billets normaux";
        //string boxHelp2Caption = "Billets spéciaux";




        public RatpController Controller { get; set; }
       
        public MenuView()
        {
            InitializeComponent();
        }



        private void btnNormalHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les billets normaux comportent les options : Adulte et prix réduit", "Billets normaux.", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnSpecialHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les billets spéciaux comportent les options : billet DisneyLand, Passe visite 1-3-5 jours et billet aéroport (tous ces billets sont disponibles au prix adulte ou réduit.", "Billets spéciaux", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void lblNormalTickets_Click(object sender, EventArgs e)
        {

            Controller.ShowNormalTickets();
            this.Hide();
        }

        private void lblSpecialTickets_Click(object sender, EventArgs e)
        {

            Controller.ShowSpecialTickets();
            this.Hide();
        }
        private void lblFrench_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.FR);
            UpdateText();


        }

        private void lblEnglish_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.EN);
            UpdateText();
        }

        private void lblSpanish_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.SPA);
            UpdateText();
        }

        private void lblGerman_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.GER);
            UpdateText();
        }

        private void lblItalian_Click(object sender, EventArgs e)
        {
            Language.UpdateLanguage(Interface_RATP.Lang.ITA);
            UpdateText();
        }

        private void UpdateText()
        {   
            ResourceManager rm = Language.Instance;
            foreach(Control c in this.Controls)
            {
                if(rm.GetString(c.Name) != null)
                {
                    c.Text = rm.GetString(c.Name);
                }
                
            }
        }
        
    }
}
