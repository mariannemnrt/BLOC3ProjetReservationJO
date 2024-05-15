using System.ComponentModel.DataAnnotations;
namespace BLOC3ProjetReservationJO.Models
{
    public class CommandModel
    {
        // clé primaire pour la BDD
        [Key]
        public Guid CommandId { get; set; }
        //date de la commande
        [DataType(DataType.Date)]
        public DateTime CommandDate { get; set; }
        // référence du paiement 
        public Guid PaymentKey { get; set; }
        // référence du client 
        public Guid UserKey { get; set; }
        // clé ticket : concaténation des clés userKey et paymentKey
        public string? TicketKey { get; set; }

        public string CreateTicket (Guid userKey, Guid paymentKey)
        {
            TicketKey = userKey.ToString() + paymentKey.ToString();
            return TicketKey;
        }
    }
}
