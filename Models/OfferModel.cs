using BLOC3ProjetReservationJO.Models;
using System.ComponentModel.DataAnnotations;

namespace BLOC3ProjetReservationJO.Models
    {
        public class OfferModel
        {
        // clé unique de l'offre
        [Key]
        public Guid OfferKey { get; set; }
        // event lié à l'offre clé étrangère donnant l'épreuve sélectionnée
        public Guid EventKey { get; set; }

        // type de l'offre solo, duo ou famille
        public OfferType Offer { get; set; }
        // prix de l'offre
        public int OfferPrice { get; set; }
        }
    }
