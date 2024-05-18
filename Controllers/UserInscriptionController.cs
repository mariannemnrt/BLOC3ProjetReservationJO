using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using BLOC3ProjetReservationJO.Models;

namespace BLOC3ProjetReservationJO.Controllers
{



    public class YourController : ControllerBase
    {
        [HttpPost]
        [Route("YourAction")]
        public IActionResult YourAction([FromBody] UserModel user)
        {
            if (ModelState.IsValid)
            {
                // Traitez les données ici
                // Par exemple, vous pouvez les enregistrer dans une base de données

                // Retournez une réponse appropriée
                return Ok(new { message = "Données reçues avec succès", data = user });
            }
            return BadRequest(ModelState);
        }
    }

}

      