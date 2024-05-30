///ETML
///Auteur : Yann Scerri
///Date : 30.05.2024
///Description : Vue du menu principal
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
        public enum Lang { FR, EN, SPA, GER, ITA } //énumérateur des langues disponibles
        private ResourceManager _resource; //variable privée pour accéder aux ressources
        
        public RatpController Controller { get; set; } //getter setter du Controller
       
        /// <summary>
        /// constructeur du Menu
        /// </summary>
        public MenuView()
        {
            InitializeComponent();
            UpdateText();
        }


        /// <summary>
        /// méthode pour afficher l'aide sur les billets normaux dans une messagebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNormalHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_resource.GetString("MessageBox1Text"), _resource.GetString("MessageBox1Caption"), MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        /// <summary>
        /// méthode pour afficher l'aide sur les billets spéciaux dans une messagebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpecialHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_resource.GetString("MessageBox2Text"), _resource.GetString("MessageBox2Caption"), MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        /// <summary>
        /// permet d'accéder à l'écran pour acheter des billets normaux
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblNormalTickets_Click(object sender, EventArgs e)
        {

            Controller.ShowNormalTickets();
            this.Hide();
        }

        /// <summary>
        /// permet d'accéder à l'écran pour acheter des billets spéciaux
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSpecialTickets_Click(object sender, EventArgs e)
        {

            Controller.ShowSpecialTickets();
            this.Hide();
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
        /// méthode pour mettre à jour les textes en cas de changement de langue
        /// </summary>
        public void UpdateText()
        {   
            _resource = Language.Instance;
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
