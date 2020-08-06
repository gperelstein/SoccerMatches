﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Soccer_Matches.Data;

namespace Soccer_Matches.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200805214310_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Soccer_Matches.Data.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AwayExtraGoals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AwayFinalGoals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AwayFirstHalfGoals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AwaySecondHalfGoals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AwayTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("HomeExtraGoals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeFinalGoals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeFirstHalfGoals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeSecondHalfGoals")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("League")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberTeamsLeague")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SoccerData");
                });
#pragma warning restore 612, 618
        }
    }
}
