using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST_API.Models;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValorantWeaponsController : ControllerBase
    {
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
        public Weapons GetWeapon(string weaponName)
        {
            return null;
        }

        [HttpPost]
        public void AddWeaponXSD([FromBody]Weapons weapon)
        {
            
        }
    }
}
