using Microsoft.EntityFrameworkCore.Migrations;

namespace GasStation_Tran.Migrations
{
    public partial class AddgasStationTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GasStation",
                columns: table => new
                {
                    GasStationId = table.Column<string>(nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    GasStationName = table.Column<string>(nullable: true),
                    GasStationType = table.Column<string>(nullable: true),
                    DistrictName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    OpeningTime = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    TypeCode = table.Column<string>(nullable: true),
                    GasStationTypeCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gasStationTable", x => x.GasStationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GasStation");
        }
    }
}
