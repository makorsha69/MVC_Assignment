﻿// <auto-generated />
using MVCAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCAssignment.Migrations
{
    [DbContext(typeof(FootballDBContext))]
    partial class FootballDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCAssignment.Models.FootballLeague", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TeamName1")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TeamName2")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("WinningTeam")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("MatchId");

                    b.ToTable("FootballLeagues");
                });
#pragma warning restore 612, 618
        }
    }
}