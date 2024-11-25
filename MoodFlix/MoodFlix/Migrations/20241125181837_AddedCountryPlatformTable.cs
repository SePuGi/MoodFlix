using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoodFlix.Migrations
{
    /// <inheritdoc />
    public partial class AddedCountryPlatformTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "Platform");

            migrationBuilder.CreateTable(
                name: "CountryPlatform",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryPlatform", x => new { x.CountryId, x.PlatformId });
                    table.ForeignKey(
                        name: "FK_CountryPlatform_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryPlatform_Platform_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platform",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryPlatform_PlatformId",
                table: "CountryPlatform",
                column: "PlatformId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryPlatform");

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "Platform",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
