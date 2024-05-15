
using System.ComponentModel.DataAnnotations;
namespace BLOC3ProjetReservationJO.Models
{
    public class UserModel
    {
        // clé unique utilisateur 
        [Key]
        public Guid UserKey { get; set; }
        // nom de l'utilisateur 
        public string? UserName { get; set; }
        // prénom de l'utilisateur  
        public string? UserFirstName { get; set; }
        // email de l'utilisateur   
        public string? UserEmail { get; set; }
        // mot de passe de l'utilisateur
        public string? UserPassword { get; set; }

        //Utilisateur existe déjà en BDD
        public bool UserExists { get; set; }= false;
        // Utilisateur est connecté
        public bool UserConnected { get; set; } = false;
    }
}
