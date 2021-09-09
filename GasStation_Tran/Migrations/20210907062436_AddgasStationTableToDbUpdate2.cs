using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GasStation_Tran.Migrations
{
    public partial class AddgasStationTableToDbUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gasStationTable");

            migrationBuilder.CreateTable(
                name: "GasStation",
                columns: table => new
                {
                    GasStationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GasStationName = table.Column<string>(nullable: true),
                    GasStationType = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    DistrictName = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    InsertedAt = table.Column<DateTime>(nullable: false),
                    InsertedBy = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<long>(nullable: true),
                    OpeningTime = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    TypeCode = table.Column<string>(nullable: true),
                    GasStationTypeCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GasStation", x => x.GasStationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GasStation");

            migrationBuilder.CreateTable(
                name: "gasStationTable",
                columns: table => new
                {
                    GasStationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<long>(type: "bigint", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GasStationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GasStationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GasStationTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertBy = table.Column<long>(type: "bigint", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gasStationTable", x => x.GasStationId);
                });
        }
    }
}
