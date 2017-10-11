using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Linq;
using System.Windows;
using System.IO;
using System.Xml;

namespace ViewModelsXML.Tools
{
    public  class ValidateXML
    {

        public ValidateXML()
        {
            schema = new XmlSchemaSet();
            string xsdPath = @"..\..\..\ViewModelsXML\XML\Main\RadioStations.xsd";
            schema.Add("", xsdPath);
        }

        public XmlSchemaSet schema { get; set; }

        public bool validate(string xmlPath, bool showSucceedMessage)
        {
            bool ValidationErrors = false;

            XDocument doc = new XDocument();
            try
            {
                 doc = XDocument.Load(xmlPath);
                doc.Validate(schema, (s, e) =>
                {
                    string Filename = Path.GetFileName(xmlPath);
                    MessageBox.Show(Filename + " is not valid: " + e.Message);

                    ValidationErrors = true;
                });

                if (ValidationErrors)
                {
                    MessageBox.Show("XSD validation failed");
                }
                else if (showSucceedMessage)
                {
                    MessageBox.Show("XSD validation Succeeded");
                }
            }
            catch (XmlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }


            

          


            return ValidationErrors;

        }

    }
}
