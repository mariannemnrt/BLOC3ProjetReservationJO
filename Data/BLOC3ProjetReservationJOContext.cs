using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BLOC3ProjetReservationJO.Models;

namespace BLOC3ProjetReservationJO.Data
{
    public class BLOC3ProjetReservationJOContext : DbContext
    {
        public BLOC3ProjetReservationJOContext (DbContextOptions<BLOC3ProjetReservationJOContext> options)
            : base(options)
        {
        }

        public DbSet<BLOC3ProjetReservationJO.Models.CommandModel> CommandModel { get; set; } = default!;
        public DbSet<BLOC3ProjetReservationJO.Models.EventModel> EventModel { get; set; } = default!;
        public DbSet<BLOC3ProjetReservationJO.Models.OfferModel> OfferModel { get; set; } = default!;
        public DbSet<BLOC3ProjetReservationJO.Models.UserModel> UserModel { get; set; } = default!;
    }
}
