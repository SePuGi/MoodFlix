using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoodFlix.Migrations
{
    /// <inheritdoc />
    public partial class AddedCountryCodeColumnInPlatform : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "Platform",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "Platform");
        }
    }
}
