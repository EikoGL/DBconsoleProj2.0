using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbconsoleProj.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passangers",
                columns: table => new
                {
                    IdPassanger = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    SurName = table.Column<string>(type: "TEXT", nullable: false),
                    Datereg = table.Column<string>(name: "Date_reg", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passangers", x => x.IdPassanger);
                });

            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    IdPoint = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Num = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.IdPoint);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    IdTicket = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Passanger = table.Column<string>(type: "TEXT", nullable: false),
                    startpoint = table.Column<string>(name: "start_point", type: "TEXT", nullable: false),
                    endpoint = table.Column<string>(name: "end_point", type: "TEXT", nullable: false),
                    departuredetails = table.Column<string>(name: "departure_details", type: "TEXT", nullable: false),
                    cost = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.IdTicket);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passangers");

            migrationBuilder.DropTable(
                name: "Points");

            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
