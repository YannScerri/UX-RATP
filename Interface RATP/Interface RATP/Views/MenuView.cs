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
    public partial class MenuView : Form
    {
        public enum Lang { FR, EN, SPA, GER, ITA }
        public Lang _currentLanguage;
        public ResourceManager _resource;



        string boxHelp1Text = "Les billets normaux comportent les options : Adulte et prix réduit";
        string boxHelp2Text = "Les billets spéciaux comportent les options : billet DisneyLand, Passe visite 1-3-5 jours et billet aéroport (tous ces billets sont disponibles au prix adulte ou réduit.";
        string boxHelp1Caption = "Billets normaux";
        string boxHelp2Caption = "Billets spéciaux";




        public RatpController Controller { get; set; }
        NormalTickets normalTickets;
        SpecialTickets specialTickets;
        public MenuView()
        {
            InitializeComponent();
            normalTickets = new NormalTickets(this);
            specialTickets = new SpecialTickets(this);
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
            NormalTickets normalTickets = new NormalTickets(this);
            normalTickets.Show();
            this.Hide();
        }

        private void lblSpecialTickets_Click(object sender, EventArgs e)
        {
            SpecialTickets specialTickets = new SpecialTickets(this);
            specialTickets.Show();
            this.Hide();
        }
        private void lblFrench_Click(object sender, EventArgs e)
        {
            Language update = new Language();
            _currentLanguage = Lang.FR;
            update.UpdateLanguage();
            UpdateText();


        }

        private void lblEnglish_Click(object sender, EventArgs e)
        {
            Language update = new Language();
            _currentLanguage = Lang.EN;
            update.UpdateLanguage();
            UpdateText();
        }

        private void lblSpanish_Click(object sender, EventArgs e)
        {
            //_currentLanguage = Lang.SPA;
        }

        private void lblGerman_Click(object sender, EventArgs e)
        {

        }

        private void lblItalian_Click(object sender, EventArgs e)
        {

        }

        private void UpdateText()
        {
            foreach(Control c in this.Controls)
            {
                if(_resource.GetString(c.Name) != null)
                {
                    c.Text = _resource.GetString(c.Name);
                }
            }
        }
        
    }
}
