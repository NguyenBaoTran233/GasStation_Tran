// <auto-generated />
using System;
using GasStation_Tran.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GasStation_Tran.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210906073752_AddgasStationAddsToDb")]
    partial class AddgasStationAddsToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GasStation_Tran.Models.GasStationAdd", b =>
                {
                    b.Property<string>("GasStationName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GasStationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpeningTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GasStationName");

                    b.ToTable("gasStationAdds");
                });
#pragma warning restore 612, 618
        }
    }
}
