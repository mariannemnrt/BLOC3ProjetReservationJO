using System.ComponentModel.DataAnnotations;
using BLOC3ProjetReservationJO.Models;



namespace BLOC3ProjetReservationJO.Models;


public class EventModel
{
    // clé primaire de la classe Event pour la BDD
    public Guid EventId { get; set; }
    // nom de sport concenré par l'event
    public SportType SportName { get; set; }
    // date de l'event
    [DataType(DataType.Date)]
    public DateTime  Date { get;  }
    // nombre de places restantes pour l'event
    public int PlaceAvailable { get; set; }

    // méthode pour connaître le nombre de places restantes pour l'event
    public int UpdateAvailability(int placesNumber)
    {
        PlaceAvailable -= placesNumber;
        return PlaceAvailable;
    }


}
