using BLOC3ProjetReservationJO.Models;

namespace BLOC3ProjetReservationJO.Models
    {
        public class OfferModel
        {
            public Guid OfferId { get; set; }
            public OfferType Offer { get; set; }
            public int OfferPrice { get; set; }
        }
    }
