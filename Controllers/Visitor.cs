using BLOC3ProjetReservationJO.Models;
using System;

namespace BLOC3ProjetReservationJO.Controllers
{
    public class Visitor
    {
        // nom du visiteur peut être null tant qu'il n'a pas créé son compte
        public string? VisitorName { get; set; }
        // prénom du visiteur peut être null tant qu'il n'a pas créé son compte
        public string? VisitorFirstName { get; set; }
        // email du visiteur peut être null tant qu'il n'a pas créé son compte
        public string? VisitorEmail { get; set; }
        // event choisi peut être null tant que le visiteur n'a pas choisi son event
        public EventModel? EventChosen { get; set;  }
        // offre choisie peut être null tant que le visiteur n'a pas choisi son offre
        public OfferModel? OfferChosen { get; set; }
        // booléen pour vérifier si le visiteur a déjà un compte et existe en BDD
        public bool VisitorChecked { get; set; } = false;
        //mot de passe saisi par le visiteur pour créer son compte
        protected static int? Password { get; set; }
        //mot de passe haché pour la sécurité
        protected string? SecurePassword { get; set; }= BCrypt.Net.BCrypt.HashPassword(Password.ToString());
        //le mot de passe saisi pour la deuxième fois est identique au premier 
        public bool PasswordChecked { get; set; } = false;
        //l'email saisi par le visiteur est valide
        public bool EmailChecked { get; set; } = false;

    }
}
