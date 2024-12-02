using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoodFlix.Migrations
{
    /// <inheritdoc />
    public partial class FixedCountryNameSpaces2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 5,
                column: "CountryName",
                value: "Antigua And Barbuda");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 21,
                column: "CountryName",
                value: "Bosnia And Herzegovina");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 32,
                column: "CountryName",
                value: "Central African Republic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 38,
                column: "CountryName",
                value: "Congo Democratic Republic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 39,
                column: "CountryName",
                value: "Congo Republic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 44,
                column: "CountryName",
                value: "Czech Republic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 48,
                column: "CountryName",
                value: "Dominican Republic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 51,
                column: "CountryName",
                value: "El Salvador");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 52,
                column: "CountryName",
                value: "Equatorial Guinea");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 69,
                column: "CountryName",
                value: "Guinea Bissau");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 88,
                column: "CountryName",
                value: "Korea North");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 89,
                column: "CountryName",
                value: "Korea South");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 107,
                column: "CountryName",
                value: "Marshall Islands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 123,
                column: "CountryName",
                value: "New Zealand");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 127,
                column: "CountryName",
                value: "North Macedonia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 134,
                column: "CountryName",
                value: "Papua New Guinea");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 144,
                column: "CountryName",
                value: "SaintKitts And Nevis");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 145,
                column: "CountryName",
                value: "Saint Lucia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 146,
                column: "CountryName",
                value: "Saint Vincent And The Grenadines");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 148,
                column: "CountryName",
                value: "San Marino");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 149,
                column: "CountryName",
                value: "Sao Tome And Principe");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 150,
                column: "CountryName",
                value: "Saudi Arabia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 154,
                column: "CountryName",
                value: "Sierra Leone");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 158,
                column: "CountryName",
                value: "Solomon Is lands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 160,
                column: "CountryName",
                value: "South Africa");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 161,
                column: "CountryName",
                value: "South Sudan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 173,
                column: "CountryName",
                value: "Timor Leste");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 176,
                column: "CountryName",
                value: "Trinidad And Tobago");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 183,
                column: "CountryName",
                value: "United Arab Emirates");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 184,
                column: "CountryName",
                value: "United Kingdom");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 185,
                column: "CountryName",
                value: "United States");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 189,
                column: "CountryName",
                value: "Vatican City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 5,
                column: "CountryName",
                value: "Antigua_And_Barbuda");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 21,
                column: "CountryName",
                value: "Bosnia_And_Herzegovina");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 32,
                column: "CountryName",
                value: "Central_African_Republic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 38,
                column: "CountryName",
                value: "Congo_Democratic_Republic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 39,
                column: "CountryName",
                value: "Congo_Republic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 44,
                column: "CountryName",
                value: "Czech_Republic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 48,
                column: "CountryName",
                value: "Dominican_Republic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 51,
                column: "CountryName",
                value: "El_Salvador");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 52,
                column: "CountryName",
                value: "Equatorial_Guinea");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 69,
                column: "CountryName",
                value: "Guinea_Bissau");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 88,
                column: "CountryName",
                value: "Korea_North");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 89,
                column: "CountryName",
                value: "Korea_South");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 107,
                column: "CountryName",
                value: "Marshall_Islands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 123,
                column: "CountryName",
                value: "New_Zealand");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 127,
                column: "CountryName",
                value: "North_Macedonia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 134,
                column: "CountryName",
                value: "Papua_New_Guinea");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 144,
                column: "CountryName",
                value: "SaintKitts_And_Nevis");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 145,
                column: "CountryName",
                value: "Saint_Lucia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 146,
                column: "CountryName",
                value: "Saint_Vincent_And_The_Grenadines");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 148,
                column: "CountryName",
                value: "San_Marino");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 149,
                column: "CountryName",
                value: "Sao_Tome_And_Principe");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 150,
                column: "CountryName",
                value: "Saudi_Arabia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 154,
                column: "CountryName",
                value: "Sierra_Leone");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 158,
                column: "CountryName",
                value: "Solomon_Is_lands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 160,
                column: "CountryName",
                value: "South_Africa");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 161,
                column: "CountryName",
                value: "South_Sudan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 173,
                column: "CountryName",
                value: "Timor_Leste");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 176,
                column: "CountryName",
                value: "Trinidad_And_Tobago");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 183,
                column: "CountryName",
                value: "United_Arab_Emirates");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 184,
                column: "CountryName",
                value: "United_Kingdom");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 185,
                column: "CountryName",
                value: "United_States");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 189,
                column: "CountryName",
                value: "Vatican_City");
        }
    }
}
