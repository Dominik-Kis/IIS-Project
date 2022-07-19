using IIS_Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace IIS_Client.Controllers
{
    public class RNGController : Controller
    {
        private const string url = "http://localhost:5001/api/ValorantRNG";
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public async Task<IActionResult> CreateAsync(Weapon weapon)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", weapon);
            }

            DataContractSerializer serializer = new DataContractSerializer(typeof(Weapon));
            MemoryStream stream = new MemoryStream();
            XmlWriter writer = XmlWriter.Create(stream);
            serializer.WriteObject(writer, weapon);
            writer.Close();

            byte[] data = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(stream.ToArray()));

            var request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/xml";
            Stream bodyHttp = request.GetRequestStream();
            bodyHttp.Write(data, 0, data.Length);
            bodyHttp.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseData = response.GetResponseStream();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Weapon));

            Weapon w = (Weapon)xmlSerializer.Deserialize(responseData);

            Console.WriteLine(w);

            return View("Data", w);

        }

        public IActionResult Data(Weapon weapon)
        {
            return View(weapon);
        }
    }
}
