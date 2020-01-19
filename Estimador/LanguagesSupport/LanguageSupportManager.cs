using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Globalization;

namespace Estimador.LanguagesSupport
{
    public class LanguageSupportManager
    {
        ResourceManager resourceManager = null;

        public LanguageSupportManager()
        {
            Assembly estimador = Assembly.Load("Fireboss");

            string language = CultureInfo.CurrentCulture.Name;

            if (!ValidResource(language)) language = "en-US";

            resourceManager = new ResourceManager($"Estimador.LanguagesSupport.{language}", estimador);
            
        }

        private bool ValidResource(string language)
        {
            List<string> languages = new List<string>() {
                "en-US",
                "es-419",
                "es-AR",
                "es-ES",
                "es-MX"
            };

            return languages.Contains(language);
        }

        public string GetStringValue(string key)
        {
            if (resourceManager == null) return string.Empty;

            return resourceManager.GetString(key);
        }

        public object GetObjectValue(string key)
        {
            if (resourceManager == null) return string.Empty;

            return resourceManager.GetObject(key);
        }
    }
}
