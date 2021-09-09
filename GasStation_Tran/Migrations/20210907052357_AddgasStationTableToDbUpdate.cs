using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GasStation_Tran.Migrations
{
    public partial class AddgasStationTableToDbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "GasStation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "DeleteBy",
                table: "GasStation",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertAt",
                table: "GasStation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "InsertBy",
                table: "GasStation",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "GasStation",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "GasStation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "UpdateBy",
                table: "GasStation",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "GasStation");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "GasStation");

            migrationBuilder.DropColumn(
                name: "InsertAt",
                table: "GasStation");

            migrationBuilder.DropColumn(
                name: "InsertBy",
                table: "GasStation");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "GasStation");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "GasStation");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "GasStation");
        }
    }
}
