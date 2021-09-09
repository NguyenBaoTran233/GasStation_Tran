using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GasStation_Tran.Migrations
{
    public partial class AddgasStationAddsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GasStation",
                columns: table => new
                {
                    GasStationName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GasStationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gasStationAdds", x => x.GasStationName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gasStationAdds");
        }
    }
}
