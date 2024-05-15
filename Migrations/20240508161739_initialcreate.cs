using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BLOC3ProjetReservationJO.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommandModel",
                columns: table => new
                {
                    CommandId = table.Column<Guid>(type: "uuid", nullable: false),
                    CommandDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PaymentKey = table.Column<Guid>(type: "uuid", nullable: false),
                    UserKey = table.Column<Guid>(type: "uuid", nullable: false),
                    TicketKey = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandModel", x => x.CommandId);
                });

            migrationBuilder.CreateTable(
                name: "EventModel",
                columns: table => new
                {
                    EventId = table.Column<Guid>(type: "uuid", nullable: false),
                    SportName = table.Column<int>(type: "integer", nullable: false),
                    PlaceAvailable = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventModel", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "OfferModel",
                columns: table => new
                {
                    OfferKey = table.Column<Guid>(type: "uuid", nullable: false),
                    EventKey = table.Column<Guid>(type: "uuid", nullable: false),
                    Offer = table.Column<int>(type: "integer", nullable: false),
                    OfferPrice = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferModel", x => x.OfferKey);
                });

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    UserKey = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    UserFirstName = table.Column<string>(type: "text", nullable: true),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    UserPassword = table.Column<string>(type: "text", nullable: true),
                    UserExists = table.Column<bool>(type: "boolean", nullable: false),
                    UserConnected = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.UserKey);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommandModel");

            migrationBuilder.DropTable(
                name: "EventModel");

            migrationBuilder.DropTable(
                name: "OfferModel");

            migrationBuilder.DropTable(
                name: "UserModel");
        }
    }
}
