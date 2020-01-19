using Estimador.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Estimador.Objects
{
    public class TemplateBO
    {
        public void SaveTemplate(Template template, string path = "controlsTemplate.xml")
        {
            using (StreamWriter saveTemplate = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Template));
                xmlSerializer.Serialize(saveTemplate, template);
            }
        }

        public Template LoadTemplate(string path = "controlsTemplate.xml")
        {
            Template template = new Template();
            template.Base = 0;
            template.CustomControls = new List<CustomControl>();

            if (File.Exists(path))
            {

                try
                {
                    using (StreamReader readTemplate = new StreamReader(path))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Template));
                        template = (Template)xmlSerializer.Deserialize(readTemplate);
                    }
                }
                catch { }
            }
            return template;
        }
    }
}
