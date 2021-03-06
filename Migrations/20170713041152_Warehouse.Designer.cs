﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MaerskLine.Models;

namespace MaerskLine.Migrations
{
    [DbContext(typeof(MaerskLineContext))]
    [Migration("20170713041152_Warehouse")]
    partial class Warehouse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
