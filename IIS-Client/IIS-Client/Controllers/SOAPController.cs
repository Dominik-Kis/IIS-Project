using IIS_Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace IIS_Client.Controllers
{
    public class SOAPController : Controller
    {
        ValoServiceReference.SOAPSoapClient service = new ValoServiceReference.SOAPSoapClient(ValoServiceReference.SOAPSoapClient.EndpointConfiguration.SOAPSoap);
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(string? name)
        {
            string result = service.SearchWeaponAsync(name).Result.Body.SearchWeaponResult;

            if (string.IsNullOrEmpty(result))
            {
                return View();
            }

            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(result);

            XmlSerializer serializer = new XmlSerializer(typeof(Weapon));
            XmlReader reader = new XmlNodeReader(xDoc);

            Weapon weapon = (Weapon)serializer.Deserialize(reader);

            return View(weapon);
        }
    }
}
