using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeAndMangaDatabase.Migrations.AnimeAndMangaDatabase
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateLastWatched = table.Column<DateOnly>(type: "date", nullable: false),
                    ShowStillOngoing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaitingForNewDubs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaitingForNewSeason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDateForNextSeason = table.Column<DateOnly>(type: "date", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anime", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anime");
        }
    }
}
