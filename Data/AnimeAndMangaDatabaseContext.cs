using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnimeAndMangaDatabase.Models;

namespace AnimeAndMangaDatabase.Data
{
    public class AnimeAndMangaDatabaseContext : DbContext
    {
        public AnimeAndMangaDatabaseContext(DbContextOptions<AnimeAndMangaDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<AnimeAndMangaDatabase.Models.Anime> Anime { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anime>()
                .Property(a => a.ShowStillOngoing)
                .HasConversion<int>();

            modelBuilder.Entity<Anime>()
                .Property(a => a.WaitingForNewDubs)
                .HasConversion<int>();

            modelBuilder.Entity<Anime>()
                .Property(a => a.WaitingForNewSeason)
                .HasConversion<int>();

            modelBuilder.Entity<Anime>()
                .Property(a => a.Genre)
                .HasConversion<int>();
        }
    }
}