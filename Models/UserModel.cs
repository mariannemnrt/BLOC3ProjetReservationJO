
namespace BLOC3ProjetReservationJO.Models
{
    public class UserModel
    {
        // clé unique utilisateur 
        public Guid UserKey { get; set; }
        // nom de l'utilisateur 
        public string? UserName { get; set; }
        // prénom de l'utilisateur  
        public string? UserFirstName { get; set; }
        // email de l'utilisateur   
        public string? UserEmail { get; set; }
        // mot de passe de l'utilisateur
        public string? UserPassword { get; set; } 
        //choix de l'event par l'utilisateur
        public EventModel? EventChosen { get; set; }
        //choix de l'offre par l'utilisateur
        public OfferModel? OfferChosen { get; set; }
        //booléen pour vérifier si l'utilisateur est bien inscrit   
        public bool UserChecked { get; set; } = false;    

    }
}
