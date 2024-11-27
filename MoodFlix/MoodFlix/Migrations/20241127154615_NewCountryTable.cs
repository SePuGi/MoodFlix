using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoodFlix.Migrations
{
    /// <inheritdoc />
    public partial class NewCountryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "History",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "CountryPlatform",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 0,
                column: "CountryName",
                value: "AF");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "CountryName",
                value: "AL");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 2,
                column: "CountryName",
                value: "DZ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 3,
                column: "CountryName",
                value: "AD");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 4,
                column: "CountryName",
                value: "AO");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 5,
                column: "CountryName",
                value: "AG");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 6,
                column: "CountryName",
                value: "AR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 7,
                column: "CountryName",
                value: "AM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 8,
                column: "CountryName",
                value: "AU");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 9,
                column: "CountryName",
                value: "AT");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 10,
                column: "CountryName",
                value: "AZ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 11,
                column: "CountryName",
                value: "BS");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 12,
                column: "CountryName",
                value: "BH");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 13,
                column: "CountryName",
                value: "BD");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 14,
                column: "CountryName",
                value: "BB");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 15,
                column: "CountryName",
                value: "BY");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 16,
                column: "CountryName",
                value: "BE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 17,
                column: "CountryName",
                value: "BZ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 18,
                column: "CountryName",
                value: "BJ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 19,
                column: "CountryName",
                value: "BT");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 20,
                column: "CountryName",
                value: "BO");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 21,
                column: "CountryName",
                value: "BA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 22,
                column: "CountryName",
                value: "BW");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 23,
                column: "CountryName",
                value: "BR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 24,
                column: "CountryName",
                value: "BN");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 25,
                column: "CountryName",
                value: "BG");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 26,
                column: "CountryName",
                value: "BF");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 27,
                column: "CountryName",
                value: "BI");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 28,
                column: "CountryName",
                value: "KH");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 29,
                column: "CountryName",
                value: "CM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 30,
                column: "CountryName",
                value: "CA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 31,
                column: "CountryName",
                value: "CV");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 32,
                column: "CountryName",
                value: "CF");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 33,
                column: "CountryName",
                value: "TD");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 34,
                column: "CountryName",
                value: "CL");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 35,
                column: "CountryName",
                value: "CN");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 36,
                column: "CountryName",
                value: "CO");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 37,
                column: "CountryName",
                value: "KM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 38,
                column: "CountryName",
                value: "CD");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 39,
                column: "CountryName",
                value: "CG");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 40,
                column: "CountryName",
                value: "CR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 41,
                column: "CountryName",
                value: "HR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 42,
                column: "CountryName",
                value: "CU");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 43,
                column: "CountryName",
                value: "CY");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 44,
                column: "CountryName",
                value: "CZ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 45,
                column: "CountryName",
                value: "DK");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 46,
                column: "CountryName",
                value: "DJ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 47,
                column: "CountryName",
                value: "DM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 48,
                column: "CountryName",
                value: "DO");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 49,
                column: "CountryName",
                value: "EC");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 50,
                column: "CountryName",
                value: "EG");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 51,
                column: "CountryName",
                value: "SV");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 52,
                column: "CountryName",
                value: "GQ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 53,
                column: "CountryName",
                value: "ER");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 54,
                column: "CountryName",
                value: "EE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 55,
                column: "CountryName",
                value: "SZ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 56,
                column: "CountryName",
                value: "ET");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 57,
                column: "CountryName",
                value: "FJ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 58,
                column: "CountryName",
                value: "FI");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 59,
                column: "CountryName",
                value: "FR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 60,
                column: "CountryName",
                value: "GA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 61,
                column: "CountryName",
                value: "GM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 62,
                column: "CountryName",
                value: "GE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 63,
                column: "CountryName",
                value: "DE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 64,
                column: "CountryName",
                value: "GH");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 65,
                column: "CountryName",
                value: "GR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 66,
                column: "CountryName",
                value: "GD");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 67,
                column: "CountryName",
                value: "GT");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 68,
                column: "CountryName",
                value: "GN");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 69,
                column: "CountryName",
                value: "GW");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 70,
                column: "CountryName",
                value: "GY");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 71,
                column: "CountryName",
                value: "HT");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 72,
                column: "CountryName",
                value: "HN");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 73,
                column: "CountryName",
                value: "HU");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 74,
                column: "CountryName",
                value: "IS");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 75,
                column: "CountryName",
                value: "IN");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 76,
                column: "CountryName",
                value: "ID");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 77,
                column: "CountryName",
                value: "IR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 78,
                column: "CountryName",
                value: "IQ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 79,
                column: "CountryName",
                value: "IE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 80,
                column: "CountryName",
                value: "IL");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 81,
                column: "CountryName",
                value: "IT");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 82,
                column: "CountryName",
                value: "JM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 83,
                column: "CountryName",
                value: "JP");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 84,
                column: "CountryName",
                value: "JO");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 85,
                column: "CountryName",
                value: "KZ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 86,
                column: "CountryName",
                value: "KE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 87,
                column: "CountryName",
                value: "KI");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 88,
                column: "CountryName",
                value: "KP");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 89,
                column: "CountryName",
                value: "KR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 90,
                column: "CountryName",
                value: "KW");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 91,
                column: "CountryName",
                value: "KG");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 92,
                column: "CountryName",
                value: "LA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 93,
                column: "CountryName",
                value: "LV");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 94,
                column: "CountryName",
                value: "LB");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 95,
                column: "CountryName",
                value: "LS");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 96,
                column: "CountryName",
                value: "LR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 97,
                column: "CountryName",
                value: "LY");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 98,
                column: "CountryName",
                value: "LI");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 99,
                column: "CountryName",
                value: "LT");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 100,
                column: "CountryName",
                value: "LU");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 101,
                column: "CountryName",
                value: "MG");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 102,
                column: "CountryName",
                value: "MW");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 103,
                column: "CountryName",
                value: "MY");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 104,
                column: "CountryName",
                value: "MV");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 105,
                column: "CountryName",
                value: "ML");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 106,
                column: "CountryName",
                value: "MT");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 107,
                column: "CountryName",
                value: "MH");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 108,
                column: "CountryName",
                value: "MR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 109,
                column: "CountryName",
                value: "MU");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 110,
                column: "CountryName",
                value: "MX");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 111,
                column: "CountryName",
                value: "FM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 112,
                column: "CountryName",
                value: "MD");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 113,
                column: "CountryName",
                value: "MC");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 114,
                column: "CountryName",
                value: "MN");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 115,
                column: "CountryName",
                value: "ME");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 116,
                column: "CountryName",
                value: "MA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 117,
                column: "CountryName",
                value: "MZ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 118,
                column: "CountryName",
                value: "MM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 119,
                column: "CountryName",
                value: "NA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 120,
                column: "CountryName",
                value: "NR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 121,
                column: "CountryName",
                value: "NP");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 122,
                column: "CountryName",
                value: "NL");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 123,
                column: "CountryName",
                value: "NZ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 124,
                column: "CountryName",
                value: "NI");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 125,
                column: "CountryName",
                value: "NE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 126,
                column: "CountryName",
                value: "NG");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 127,
                column: "CountryName",
                value: "MK");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 128,
                column: "CountryName",
                value: "NO");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 129,
                column: "CountryName",
                value: "OM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 130,
                column: "CountryName",
                value: "PK");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 131,
                column: "CountryName",
                value: "PW");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 132,
                column: "CountryName",
                value: "PS");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 133,
                column: "CountryName",
                value: "PA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 134,
                column: "CountryName",
                value: "PG");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 135,
                column: "CountryName",
                value: "PY");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 136,
                column: "CountryName",
                value: "PE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 137,
                column: "CountryName",
                value: "PH");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 138,
                column: "CountryName",
                value: "PL");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 139,
                column: "CountryName",
                value: "PT");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 140,
                column: "CountryName",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 141,
                column: "CountryName",
                value: "RO");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 142,
                column: "CountryName",
                value: "RU");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 143,
                column: "CountryName",
                value: "RW");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 144,
                column: "CountryName",
                value: "KN");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 145,
                column: "CountryName",
                value: "LC");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 146,
                column: "CountryName",
                value: "VC");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 147,
                column: "CountryName",
                value: "WS");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 148,
                column: "CountryName",
                value: "SM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 149,
                column: "CountryName",
                value: "ST");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 150,
                column: "CountryName",
                value: "SA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 151,
                column: "CountryName",
                value: "SN");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 152,
                column: "CountryName",
                value: "RS");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 153,
                column: "CountryName",
                value: "SC");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 154,
                column: "CountryName",
                value: "SL");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 155,
                column: "CountryName",
                value: "SG");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 156,
                column: "CountryName",
                value: "SK");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 157,
                column: "CountryName",
                value: "SI");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 158,
                column: "CountryName",
                value: "SB");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 159,
                column: "CountryName",
                value: "SO");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 160,
                column: "CountryName",
                value: "ZA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 161,
                column: "CountryName",
                value: "SS");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 162,
                column: "CountryName",
                value: "ES");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 163,
                column: "CountryName",
                value: "LK");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 164,
                column: "CountryName",
                value: "SD");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 165,
                column: "CountryName",
                value: "SR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 166,
                column: "CountryName",
                value: "SE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 167,
                column: "CountryName",
                value: "CH");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 168,
                column: "CountryName",
                value: "SY");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 169,
                column: "CountryName",
                value: "TW");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 170,
                column: "CountryName",
                value: "TJ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 171,
                column: "CountryName",
                value: "TZ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 172,
                column: "CountryName",
                value: "TH");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 173,
                column: "CountryName",
                value: "TL");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 174,
                column: "CountryName",
                value: "TG");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 175,
                column: "CountryName",
                value: "TO");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 176,
                column: "CountryName",
                value: "TT");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 177,
                column: "CountryName",
                value: "TN");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 178,
                column: "CountryName",
                value: "TR");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 179,
                column: "CountryName",
                value: "TM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 180,
                column: "CountryName",
                value: "TV");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 181,
                column: "CountryName",
                value: "UG");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 182,
                column: "CountryName",
                value: "UA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 183,
                column: "CountryName",
                value: "AE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 184,
                column: "CountryName",
                value: "GB");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 185,
                column: "CountryName",
                value: "US");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 186,
                column: "CountryName",
                value: "UY");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 187,
                column: "CountryName",
                value: "UZ");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 188,
                column: "CountryName",
                value: "VU");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 189,
                column: "CountryName",
                value: "VA");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 190,
                column: "CountryName",
                value: "VE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 191,
                column: "CountryName",
                value: "VN");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 192,
                column: "CountryName",
                value: "YE");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 193,
                column: "CountryName",
                value: "ZM");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 194,
                column: "CountryName",
                value: "ZW");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "CountryPlatform");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "History",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 0,
                column: "CountryName",
                value: "Afghanistan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "CountryName",
                value: "Albania");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 2,
                column: "CountryName",
                value: "Algeria");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 3,
                column: "CountryName",
                value: "Andorra");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 4,
                column: "CountryName",
                value: "Angola");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 5,
                column: "CountryName",
                value: "AntiguaAndBarbuda");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 6,
                column: "CountryName",
                value: "Argentina");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 7,
                column: "CountryName",
                value: "Armenia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 8,
                column: "CountryName",
                value: "Australia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 9,
                column: "CountryName",
                value: "Austria");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 10,
                column: "CountryName",
                value: "Azerbaijan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 11,
                column: "CountryName",
                value: "Bahamas");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 12,
                column: "CountryName",
                value: "Bahrain");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 13,
                column: "CountryName",
                value: "Bangladesh");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 14,
                column: "CountryName",
                value: "Barbados");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 15,
                column: "CountryName",
                value: "Belarus");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 16,
                column: "CountryName",
                value: "Belgium");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 17,
                column: "CountryName",
                value: "Belize");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 18,
                column: "CountryName",
                value: "Benin");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 19,
                column: "CountryName",
                value: "Bhutan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 20,
                column: "CountryName",
                value: "Bolivia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 21,
                column: "CountryName",
                value: "BosniaAndHerzegovina");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 22,
                column: "CountryName",
                value: "Botswana");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 23,
                column: "CountryName",
                value: "Brazil");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 24,
                column: "CountryName",
                value: "Brunei");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 25,
                column: "CountryName",
                value: "Bulgaria");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 26,
                column: "CountryName",
                value: "BurkinaFaso");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 27,
                column: "CountryName",
                value: "Burundi");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 28,
                column: "CountryName",
                value: "Cambodia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 29,
                column: "CountryName",
                value: "Cameroon");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 30,
                column: "CountryName",
                value: "Canada");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 31,
                column: "CountryName",
                value: "CapeVerde");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 32,
                column: "CountryName",
                value: "CentralAfricanRepublic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 33,
                column: "CountryName",
                value: "Chad");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 34,
                column: "CountryName",
                value: "Chile");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 35,
                column: "CountryName",
                value: "China");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 36,
                column: "CountryName",
                value: "Colombia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 37,
                column: "CountryName",
                value: "Comoros");

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
                keyValue: 40,
                column: "CountryName",
                value: "CostaRica");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 41,
                column: "CountryName",
                value: "Croatia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 42,
                column: "CountryName",
                value: "Cuba");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 43,
                column: "CountryName",
                value: "Cyprus");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 44,
                column: "CountryName",
                value: "CzechRepublic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 45,
                column: "CountryName",
                value: "Denmark");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 46,
                column: "CountryName",
                value: "Djibouti");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 47,
                column: "CountryName",
                value: "Dominica");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 48,
                column: "CountryName",
                value: "DominicanRepublic");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 49,
                column: "CountryName",
                value: "Ecuador");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 50,
                column: "CountryName",
                value: "Egypt");

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
                keyValue: 53,
                column: "CountryName",
                value: "Eritrea");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 54,
                column: "CountryName",
                value: "Estonia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 55,
                column: "CountryName",
                value: "Eswatini");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 56,
                column: "CountryName",
                value: "Ethiopia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 57,
                column: "CountryName",
                value: "Fiji");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 58,
                column: "CountryName",
                value: "Finland");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 59,
                column: "CountryName",
                value: "France");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 60,
                column: "CountryName",
                value: "Gabon");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 61,
                column: "CountryName",
                value: "Gambia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 62,
                column: "CountryName",
                value: "Georgia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 63,
                column: "CountryName",
                value: "Germany");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 64,
                column: "CountryName",
                value: "Ghana");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 65,
                column: "CountryName",
                value: "Greece");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 66,
                column: "CountryName",
                value: "Grenada");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 67,
                column: "CountryName",
                value: "Guatemala");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 68,
                column: "CountryName",
                value: "Guinea");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 69,
                column: "CountryName",
                value: "GuineaBissau");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 70,
                column: "CountryName",
                value: "Guyana");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 71,
                column: "CountryName",
                value: "Haiti");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 72,
                column: "CountryName",
                value: "Honduras");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 73,
                column: "CountryName",
                value: "Hungary");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 74,
                column: "CountryName",
                value: "Iceland");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 75,
                column: "CountryName",
                value: "India");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 76,
                column: "CountryName",
                value: "Indonesia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 77,
                column: "CountryName",
                value: "Iran");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 78,
                column: "CountryName",
                value: "Iraq");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 79,
                column: "CountryName",
                value: "Ireland");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 80,
                column: "CountryName",
                value: "Israel");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 81,
                column: "CountryName",
                value: "Italy");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 82,
                column: "CountryName",
                value: "Jamaica");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 83,
                column: "CountryName",
                value: "Japan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 84,
                column: "CountryName",
                value: "Jordan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 85,
                column: "CountryName",
                value: "Kazakhstan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 86,
                column: "CountryName",
                value: "Kenya");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 87,
                column: "CountryName",
                value: "Kiribati");

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
                keyValue: 90,
                column: "CountryName",
                value: "Kuwait");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 91,
                column: "CountryName",
                value: "Kyrgyzstan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 92,
                column: "CountryName",
                value: "Laos");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 93,
                column: "CountryName",
                value: "Latvia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 94,
                column: "CountryName",
                value: "Lebanon");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 95,
                column: "CountryName",
                value: "Lesotho");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 96,
                column: "CountryName",
                value: "Liberia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 97,
                column: "CountryName",
                value: "Libya");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 98,
                column: "CountryName",
                value: "Liechtenstein");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 99,
                column: "CountryName",
                value: "Lithuania");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 100,
                column: "CountryName",
                value: "Luxembourg");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 101,
                column: "CountryName",
                value: "Madagascar");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 102,
                column: "CountryName",
                value: "Malawi");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 103,
                column: "CountryName",
                value: "Malaysia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 104,
                column: "CountryName",
                value: "Maldives");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 105,
                column: "CountryName",
                value: "Mali");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 106,
                column: "CountryName",
                value: "Malta");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 107,
                column: "CountryName",
                value: "MarshallIslands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 108,
                column: "CountryName",
                value: "Mauritania");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 109,
                column: "CountryName",
                value: "Mauritius");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 110,
                column: "CountryName",
                value: "Mexico");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 111,
                column: "CountryName",
                value: "Micronesia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 112,
                column: "CountryName",
                value: "Moldova");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 113,
                column: "CountryName",
                value: "Monaco");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 114,
                column: "CountryName",
                value: "Mongolia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 115,
                column: "CountryName",
                value: "Montenegro");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 116,
                column: "CountryName",
                value: "Morocco");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 117,
                column: "CountryName",
                value: "Mozambique");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 118,
                column: "CountryName",
                value: "Myanmar");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 119,
                column: "CountryName",
                value: "Namibia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 120,
                column: "CountryName",
                value: "Nauru");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 121,
                column: "CountryName",
                value: "Nepal");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 122,
                column: "CountryName",
                value: "Netherlands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 123,
                column: "CountryName",
                value: "NewZealand");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 124,
                column: "CountryName",
                value: "Nicaragua");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 125,
                column: "CountryName",
                value: "Niger");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 126,
                column: "CountryName",
                value: "Nigeria");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 127,
                column: "CountryName",
                value: "NorthMacedonia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 128,
                column: "CountryName",
                value: "Norway");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 129,
                column: "CountryName",
                value: "Oman");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 130,
                column: "CountryName",
                value: "Pakistan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 131,
                column: "CountryName",
                value: "Palau");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 132,
                column: "CountryName",
                value: "Palestine");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 133,
                column: "CountryName",
                value: "Panama");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 134,
                column: "CountryName",
                value: "PapuaNewGuinea");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 135,
                column: "CountryName",
                value: "Paraguay");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 136,
                column: "CountryName",
                value: "Peru");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 137,
                column: "CountryName",
                value: "Philippines");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 138,
                column: "CountryName",
                value: "Poland");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 139,
                column: "CountryName",
                value: "Portugal");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 140,
                column: "CountryName",
                value: "Qatar");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 141,
                column: "CountryName",
                value: "Romania");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 142,
                column: "CountryName",
                value: "Russia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 143,
                column: "CountryName",
                value: "Rwanda");

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
                keyValue: 147,
                column: "CountryName",
                value: "Samoa");

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
                keyValue: 151,
                column: "CountryName",
                value: "Senegal");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 152,
                column: "CountryName",
                value: "Serbia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 153,
                column: "CountryName",
                value: "Seychelles");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 154,
                column: "CountryName",
                value: "SierraLeone");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 155,
                column: "CountryName",
                value: "Singapore");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 156,
                column: "CountryName",
                value: "Slovakia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 157,
                column: "CountryName",
                value: "Slovenia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 158,
                column: "CountryName",
                value: "SolomonIslands");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 159,
                column: "CountryName",
                value: "Somalia");

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
                keyValue: 162,
                column: "CountryName",
                value: "Spain");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 163,
                column: "CountryName",
                value: "SriLanka");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 164,
                column: "CountryName",
                value: "Sudan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 165,
                column: "CountryName",
                value: "Suriname");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 166,
                column: "CountryName",
                value: "Sweden");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 167,
                column: "CountryName",
                value: "Switzerland");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 168,
                column: "CountryName",
                value: "Syria");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 169,
                column: "CountryName",
                value: "Taiwan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 170,
                column: "CountryName",
                value: "Tajikistan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 171,
                column: "CountryName",
                value: "Tanzania");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 172,
                column: "CountryName",
                value: "Thailand");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 173,
                column: "CountryName",
                value: "TimorLeste");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 174,
                column: "CountryName",
                value: "Togo");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 175,
                column: "CountryName",
                value: "Tonga");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 176,
                column: "CountryName",
                value: "TrinidadAndTobago");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 177,
                column: "CountryName",
                value: "Tunisia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 178,
                column: "CountryName",
                value: "Turkey");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 179,
                column: "CountryName",
                value: "Turkmenistan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 180,
                column: "CountryName",
                value: "Tuvalu");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 181,
                column: "CountryName",
                value: "Uganda");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 182,
                column: "CountryName",
                value: "Ukraine");

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
                keyValue: 186,
                column: "CountryName",
                value: "Uruguay");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 187,
                column: "CountryName",
                value: "Uzbekistan");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 188,
                column: "CountryName",
                value: "Vanuatu");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 189,
                column: "CountryName",
                value: "VaticanCity");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 190,
                column: "CountryName",
                value: "Venezuela");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 191,
                column: "CountryName",
                value: "Vietnam");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 192,
                column: "CountryName",
                value: "Yemen");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 193,
                column: "CountryName",
                value: "Zambia");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 194,
                column: "CountryName",
                value: "Zimbabwe");
        }
    }
}
