﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestTaskToALEF.DataModels;

namespace TestTaskToALEF.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20200818170910_ChangeValueType")]
    partial class ChangeValueType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TestTaskToALEF.DataModels.ModelData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Vodafone",
                            Value = "066"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lifecell",
                            Value = "093"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
