﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NhlDAL.Migrations
{
    [DbContext(typeof(NhlContext))]
    [Migration("20220704215521_AddingPlayerStats")]
    partial class AddingPlayerStats
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lib.Classes.PlayerStats", b =>
                {
                    b.Property<Guid>("PlayerStatsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("Blocked")
                        .HasColumnType("int");

                    b.Property<string>("EvenTimeOnIce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("EvenTimeOnIcePerGame")
                        .HasColumnType("time");

                    b.Property<int>("FaceOffPct")
                        .HasColumnType("int");

                    b.Property<int>("GameType")
                        .HasColumnType("int");

                    b.Property<int>("GameWinningGoals")
                        .HasColumnType("int");

                    b.Property<int>("Games")
                        .HasColumnType("int");

                    b.Property<int>("Goals")
                        .HasColumnType("int");

                    b.Property<int>("Hits")
                        .HasColumnType("int");

                    b.Property<int>("OverTimeGoals")
                        .HasColumnType("int");

                    b.Property<int>("PenaltyMinutes")
                        .HasColumnType("int");

                    b.Property<int>("Pim")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PlusMinus")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("PowerPlayGoals")
                        .HasColumnType("int");

                    b.Property<int>("PowerPlayPoints")
                        .HasColumnType("int");

                    b.Property<string>("PowerPlayTimeOnIce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("PowerPlayTimeOnIcePerGame")
                        .HasColumnType("time");

                    b.Property<int>("SeasonEnd")
                        .HasColumnType("int");

                    b.Property<int>("SeasonStart")
                        .HasColumnType("int");

                    b.Property<int>("Shifts")
                        .HasColumnType("int");

                    b.Property<int>("ShortHandedGoals")
                        .HasColumnType("int");

                    b.Property<int>("ShortHandedPoints")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("ShortHandedTimeOnIce")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("ShortHandedTimeOnIcePerGame")
                        .HasColumnType("time");

                    b.Property<double>("ShotPct")
                        .HasColumnType("float");

                    b.Property<int>("Shots")
                        .HasColumnType("int");

                    b.Property<string>("TimeOnIce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("TimeOnIcePerGame")
                        .HasColumnType("time");

                    b.HasKey("PlayerStatsId");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerStats");
                });

            modelBuilder.Entity("NhlLib.Classes.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JerseyNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NhlPlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("NhlLib.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Abbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FranchiseId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NhlTeamId")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Lib.Classes.PlayerStats", b =>
                {
                    b.HasOne("NhlLib.Classes.Player", "Player")
                        .WithMany("Stats")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("NhlLib.Classes.Player", b =>
                {
                    b.HasOne("NhlLib.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("NhlLib.Classes.Player", b =>
                {
                    b.Navigation("Stats");
                });

            modelBuilder.Entity("NhlLib.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
