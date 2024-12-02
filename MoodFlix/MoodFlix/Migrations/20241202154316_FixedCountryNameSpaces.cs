using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoodFlix.Migrations
{
    /// <inheritdoc />
    public partial class FixedCountryNameSpaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 5,
                column: "CountryName",
                value: "AntiguaAndBarbuda");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 21,
                column: "CountryName",
                value: "BosniaAndHerzegovina");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 32,
                column: "CountryName",
                value: "CentralAfricanRepublic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 38,
                column: "CountryName",
                value: "CongoDemocraticRepublic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 39,
                column: "CountryName",
                value: "CongoRepublic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 44,
                column: "CountryName",
                value: "CzechRepublic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 48,
                column: "CountryName",
                value: "DominicanRepublic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 51,
                column: "CountryName",
                value: "ElSalvador");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 52,
                column: "CountryName",
                value: "EquatorialGuinea");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 69,
                column: "CountryName",
                value: "GuineaBissau");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 88,
                column: "CountryName",
                value: "KoreaNorth");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 89,
                column: "CountryName",
                value: "KoreaSouth");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 107,
                column: "CountryName",
                value: "MarshallIslands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 123,
                column: "CountryName",
                value: "NewZealand");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 127,
                column: "CountryName",
                value: "NorthMacedonia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 134,
                column: "CountryName",
                value: "PapuaNewGuinea");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 144,
                column: "CountryName",
                value: "SaintKittsAndNevis");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 145,
                column: "CountryName",
                value: "SaintLucia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 146,
                column: "CountryName",
                value: "SaintVincentAndTheGrenadines");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 148,
                column: "CountryName",
                value: "SanMarino");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 149,
                column: "CountryName",
                value: "SaoTomeAndPrincipe");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 150,
                column: "CountryName",
                value: "SaudiArabia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 154,
                column: "CountryName",
                value: "SierraLeone");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 158,
                column: "CountryName",
                value: "SolomonIslands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 160,
                column: "CountryName",
                value: "SouthAfrica");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 161,
                column: "CountryName",
                value: "SouthSudan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 173,
                column: "CountryName",
                value: "TimorLeste");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 176,
                column: "CountryName",
                value: "TrinidadAndTobago");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 183,
                column: "CountryName",
                value: "UnitedArabEmirates");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 184,
                column: "CountryName",
                value: "UnitedKingdom");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 185,
                column: "CountryName",
                value: "UnitedStates");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 189,
                column: "CountryName",
                value: "VaticanCity");
        }
    }
}
