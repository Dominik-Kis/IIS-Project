using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using System.Net;
using System.Runtime.Serialization;
using IIS_Client.Models;
using System.Xml;
using System.Text;

namespace IIS_Client.Controllers
{
    public class XSDController : Controller
    {
        private const string url = "http://localhost:5001/api/ValorantXSD";

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

            string path = Path.GetFullPath("test.xml");
            FileStream file = System.IO.File.Create(path);
            XmlWriter xmlWriter = XmlWriter.Create(file);
            serializer.WriteObject(xmlWriter, weapon);
            xmlWriter.Close();
            file.Close();

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

            ViewBag.data = w;

            return View("Data", w);

        }

        public IActionResult Data(Weapon weapon)
        {
            return View(weapon);
        }

    }
}
