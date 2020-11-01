﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi13Oct2020.Controllers;

namespace WebApi13Oct2020.Migrations
{
    [DbContext(typeof(CFLDBContext))]
    [Migration("20201019085232_AddSeasonTable")]
    partial class AddSeasonTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("WebApi13Oct2020.Schedule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Attendance")
                        .HasColumnType("int");

                    b.Property<int>("AwayPoints")
                        .HasColumnType("int");

                    b.Property<string>("AwayTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GameDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HomePoints")
                        .HasColumnType("int");

                    b.Property<string>("HomeTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("WebApi13Oct2020.Season", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("SeasonID")
                        .HasColumnType("int");

                    b.Property<string>("SeasonName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("WebApi13Oct2020.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Abbrev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stadium")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Team");
                });
#pragma warning restore 612, 618
        }
    }
}