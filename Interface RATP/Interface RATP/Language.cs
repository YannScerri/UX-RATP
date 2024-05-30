///ETML
///Auteur : Yann Scerri
///Date : 30.05.2024
///Description : Classe Language permettant de gérer les informations concernant l'internationalisation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Interface_RATP
{
    public enum Lang { FR, EN, SPA, GER, ITA }
    internal class Language
    {
        
        public Lang _currentLanguage;
        private static ResourceManager _resourceManager;

        public static ResourceManager Instance
        {
            get
            {
                if (_resourceManager == null)
                {
                    _resourceManager = new ResourceManager(typeof(Ressources.FR));
                }
                return _resourceManager;
            }
        }

        public static void UpdateLanguage(Lang lang)
        {
            switch (lang)
            {
                case Lang.FR:
                    _resourceManager = new ResourceManager(typeof(Ressources.FR));
                    break;
                case Lang.EN:
                    _resourceManager = new ResourceManager(typeof(Ressources.EN));
                    break;
                case Lang.GER:
                    _resourceManager = new ResourceManager (typeof(Ressources.GER));
                    break;
                case Lang.SPA:
                    _resourceManager = new ResourceManager (typeof (Ressources.SPA));
                    break;
                case Lang.ITA:
                    _resourceManager = new ResourceManager(typeof(Ressources.ITA));
                    break;
            }

            
        }
    }
}
