﻿// <auto-generated />
using System;
using AnimeAndMangaDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimeAndMangaDatabase.Migrations.AnimeAndMangaDatabase
{
    [DbContext(typeof(AnimeAndMangaDatabaseContext))]
    [Migration("20250228213537_AddEnums")]
    partial class AddEnums
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AnimeAndMangaDatabase.Models.Anime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateLastWatched")
                        .HasColumnType("date");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ReleaseDateForNextSeason")
                        .HasColumnType("date");

                    b.Property<int>("ShowStillOngoing")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("WaitingForNewDubs")
                        .HasColumnType("int");

                    b.Property<int>("WaitingForNewSeason")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Anime");
                });
#pragma warning restore 612, 618
        }
    }
}
