using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Interface_RATP
{
    internal class Language
    {
        public enum Lang { FR, EN, SPA, GER, ITA }
        public Lang _currentLanguage;
        private ResourceManager _resource;

        public ResourceManager UpdateLanguage()
        {
            switch (_currentLanguage)
            {
                case Lang.FR:
                    _resource = new ResourceManager(typeof(Ressources.FR));
                    break;
                case Lang.EN:
                    _resource = new ResourceManager(typeof(Ressources.EN));
                    break;
            }

            return _resource;
        }
    }
}
