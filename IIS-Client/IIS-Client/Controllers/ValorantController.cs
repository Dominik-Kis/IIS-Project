using IIS_Client.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IIS_Client.Controllers
{
    public class ValorantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("GetWeapon")]
        public async Task<IActionResult> GetWeaponAsync(string? name)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://valorant-weapons.p.rapidapi.com/weapon/" + name),
                Headers =
                {
                    { "X-RapidAPI-Key", "149905955cmshdd476b497977b1ep14fc95jsn9041bf28a9ab" },
                    { "X-RapidAPI-Host", "valorant-weapons.p.rapidapi.com" },
                },
            };

            string jsonResponse;

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                jsonResponse = await response.Content.ReadAsStringAsync();
            }

            Weapons weapon = JsonConvert.DeserializeObject<Weapons>(jsonResponse);

            return View(weapon);
        }
    }
}
