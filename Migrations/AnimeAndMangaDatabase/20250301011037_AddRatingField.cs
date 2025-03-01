using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeAndMangaDatabase.Migrations.AnimeAndMangaDatabase
{
    /// <inheritdoc />
    public partial class AddRatingField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Anime",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "PG-13");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Anime");
        }
    }
}
