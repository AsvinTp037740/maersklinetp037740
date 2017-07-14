using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MaerskLine.Models;

namespace MaerskLine.Migrations
{
    [DbContext(typeof(MaerskLineContext))]
    [Migration("20170713042354_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MaerskLine.Models.Agent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AgentCompany");

                    b.Property<int>("AgentID");

                    b.Property<string>("AgentName");

                    b.Property<string>("AgentRole");

                    b.HasKey("ID");

                    b.ToTable("Agent");
                });

            modelBuilder.Entity("MaerskLine.Models.Cargo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CargoMaterial");

                    b.Property<string>("CargoTag");

                    b.Property<int>("CargoWeight");

                    b.Property<int>("WarehouseNo");

                    b.HasKey("ID");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("MaerskLine.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustAge");

                    b.Property<int>("CustID");

                    b.Property<string>("CustJob");

                    b.Property<string>("CustName");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MaerskLine.Models.Shipping", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CargoTag");

                    b.Property<string>("Destination");

                    b.Property<int>("ShipID");

                    b.Property<string>("ShippingDate");

                    b.Property<string>("ShippingStatus");

                    b.HasKey("ID");

                    b.ToTable("Shipping");
                });

            modelBuilder.Entity("MaerskLine.Models.Warehouse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("WarehouseCapacity");

                    b.Property<string>("WarehouseLocation");

                    b.Property<int>("WarehouseNo");

                    b.HasKey("ID");

                    b.ToTable("Warehouse");
                });
        }
    }
}
