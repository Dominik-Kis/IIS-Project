using Commons.Xml.Relaxng;
using Microsoft.AspNetCore.Mvc;
using REST_API.Models;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValorantRNGController : ControllerBase
    {
        [HttpPost]
        public string Post([FromBody] Weapon weapon)
        {
            string xml;

            XmlSerializer xmlSerializer = new XmlSerializer(weapon.GetType());

            using (StringWriter textWriter = new Utf8StringWriter())
            {
                xmlSerializer.Serialize(textWriter, weapon);
                xml = textWriter.ToString();
            }

            try
            {
                string path = Path.GetFullPath("Schemas");
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);
                xmlDocument.Save(path + "\\XMLFile.xml");


                XmlReader xmlReaderXML = XmlReader.Create(path + "\\XMLFile.xml");
                XmlReader xmlReaderRNG = new XmlTextReader(path + "\\WeaponRNG.xml");

                XmlReader rd = new RelaxngValidatingReader(xmlReaderXML, xmlReaderRNG);
                XDocument doc = XDocument.Load(rd);
            }
            catch (Exception)
            {
                return null;
            }

            return xml;
        }

        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error) throw new Exception(e.Message);
            }
        }
    }
}
