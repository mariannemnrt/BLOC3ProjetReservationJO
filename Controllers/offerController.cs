using BLOC3ProjetReservationJO.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class offerController : ControllerBase
{
    [HttpPost]
    public IActionResult RecevoirValeur([FromBody] EventModel  eventChosen)
    {
        
        

        // Faites ce que vous voulez avec la valeur (sauvegardez-la en base de données, effectuez des calculs, etc.)

        // Renvoyez une réponse si nécessaire
        return Ok();
    }
}

public class VotreModele
{
    public string Valeur { get; set; }
}
