using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST_API.Models;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValorantWeaponsController : ControllerBase
    {
        [HttpGet]
        public List<WeaponClass> GetWeaponClasses()
        {
            return null;
        }

        [Route("[action]/{weaponClassName}")]
        [HttpGet]
        public WeaponClass GetWeaponClass(string weaponClassName)
        {
            return null;
        }

        [HttpPost]
        public void AddWeaponClass([FromBody] WeaponClass weaponClass)
        {

        }

        [Route("[action]/{weaponName}")]
        [HttpGet]
        public Weapon GetWeapon(string weaponName)
        {
            return null;
        }

        [HttpPost]
        public void AddWeapon([FromBody]Weapon weapon)
        {

        }
    }
}
