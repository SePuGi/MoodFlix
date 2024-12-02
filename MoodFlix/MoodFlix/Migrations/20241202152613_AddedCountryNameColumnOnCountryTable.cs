using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoodFlix.Migrations
{
    /// <inheritdoc />
    public partial class AddedCountryNameColumnOnCountryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "Country",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 0,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "AF", "Afghanistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "AL", "Albania" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 2,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "DZ", "Algeria" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 3,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "AD", "Andorra" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 4,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "AO", "Angola" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 5,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "AG", "AntiguaAndBarbuda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 6,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "AR", "Argentina" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 7,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "AM", "Armenia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 8,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "AU", "Australia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 9,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "AT", "Austria" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 10,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "AZ", "Azerbaijan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 11,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BS", "Bahamas" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 12,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BH", "Bahrain" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 13,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BD", "Bangladesh" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 14,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BB", "Barbados" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 15,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BY", "Belarus" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 16,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BE", "Belgium" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 17,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BZ", "Belize" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 18,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BJ", "Benin" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 19,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BT", "Bhutan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 20,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BO", "Bolivia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 21,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BA", "BosniaAndHerzegovina" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 22,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BW", "Botswana" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 23,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BR", "Brazil" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 24,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BN", "Brunei" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 25,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BG", "Bulgaria" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 26,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BF", "BurkinaFaso" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 27,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "BI", "Burundi" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 28,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "KH", "Cambodia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 29,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CM", "Cameroon" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 30,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CA", "Canada" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 31,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CV", "CapeVerde" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 32,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CF", "CentralAfricanRepublic" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 33,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TD", "Chad" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 34,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CL", "Chile" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 35,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CN", "China" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 36,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CO", "Colombia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 37,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "KM", "Comoros" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 38,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CD", "CongoDemocraticRepublic" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 39,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CG", "CongoRepublic" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 40,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CR", "CostaRica" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 41,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "HR", "Croatia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 42,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CU", "Cuba" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 43,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CY", "Cyprus" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 44,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CZ", "CzechRepublic" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 45,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "DK", "Denmark" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 46,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "DJ", "Djibouti" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 47,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "DM", "Dominica" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 48,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "DO", "DominicanRepublic" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 49,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "EC", "Ecuador" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 50,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "EG", "Egypt" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 51,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SV", "ElSalvador" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 52,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GQ", "EquatorialGuinea" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 53,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "ER", "Eritrea" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 54,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "EE", "Estonia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 55,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SZ", "Eswatini" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 56,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "ET", "Ethiopia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 57,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "FJ", "Fiji" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 58,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "FI", "Finland" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 59,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "FR", "France" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 60,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GA", "Gabon" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 61,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GM", "Gambia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 62,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GE", "Georgia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 63,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "DE", "Germany" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 64,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GH", "Ghana" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 65,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GR", "Greece" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 66,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GD", "Grenada" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 67,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GT", "Guatemala" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 68,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GN", "Guinea" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 69,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GW", "GuineaBissau" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 70,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GY", "Guyana" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 71,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "HT", "Haiti" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 72,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "HN", "Honduras" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 73,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "HU", "Hungary" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 74,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "IS", "Iceland" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 75,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "IN", "India" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 76,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "ID", "Indonesia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 77,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "IR", "Iran" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 78,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "IQ", "Iraq" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 79,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "IE", "Ireland" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 80,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "IL", "Israel" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 81,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "IT", "Italy" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 82,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "JM", "Jamaica" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 83,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "JP", "Japan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 84,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "JO", "Jordan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 85,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "KZ", "Kazakhstan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 86,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "KE", "Kenya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 87,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "KI", "Kiribati" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 88,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "KP", "KoreaNorth" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 89,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "KR", "KoreaSouth" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 90,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "KW", "Kuwait" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 91,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "KG", "Kyrgyzstan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 92,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "LA", "Laos" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 93,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "LV", "Latvia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 94,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "LB", "Lebanon" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 95,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "LS", "Lesotho" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 96,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "LR", "Liberia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 97,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "LY", "Libya" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 98,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "LI", "Liechtenstein" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 99,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "LT", "Lithuania" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 100,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "LU", "Luxembourg" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 101,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MG", "Madagascar" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 102,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MW", "Malawi" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 103,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MY", "Malaysia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 104,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MV", "Maldives" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 105,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "ML", "Mali" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 106,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MT", "Malta" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 107,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MH", "MarshallIslands" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 108,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MR", "Mauritania" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 109,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MU", "Mauritius" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 110,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MX", "Mexico" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 111,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "FM", "Micronesia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 112,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MD", "Moldova" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 113,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MC", "Monaco" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 114,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MN", "Mongolia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 115,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "ME", "Montenegro" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 116,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MA", "Morocco" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 117,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MZ", "Mozambique" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 118,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MM", "Myanmar" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 119,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "NA", "Namibia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 120,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "NR", "Nauru" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 121,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "NP", "Nepal" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 122,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "NL", "Netherlands" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 123,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "NZ", "NewZealand" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 124,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "NI", "Nicaragua" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 125,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "NE", "Niger" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 126,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "NG", "Nigeria" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 127,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "MK", "NorthMacedonia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 128,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "NO", "Norway" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 129,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "OM", "Oman" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 130,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "PK", "Pakistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 131,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "PW", "Palau" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 132,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "PS", "Palestine" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 133,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "PA", "Panama" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 134,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "PG", "PapuaNewGuinea" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 135,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "PY", "Paraguay" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 136,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "PE", "Peru" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 137,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "PH", "Philippines" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 138,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "PL", "Poland" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 139,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "PT", "Portugal" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 140,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "QA", "Qatar" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 141,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "RO", "Romania" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 142,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "RU", "Russia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 143,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "RW", "Rwanda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 144,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "KN", "SaintKittsAndNevis" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 145,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "LC", "SaintLucia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 146,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "VC", "SaintVincentAndTheGrenadines" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 147,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "WS", "Samoa" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 148,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SM", "SanMarino" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 149,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "ST", "SaoTomeAndPrincipe" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 150,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SA", "SaudiArabia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 151,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SN", "Senegal" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 152,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "RS", "Serbia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 153,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SC", "Seychelles" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 154,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SL", "SierraLeone" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 155,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SG", "Singapore" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 156,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SK", "Slovakia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 157,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SI", "Slovenia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 158,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SB", "SolomonIslands" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 159,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SO", "Somalia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 160,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "ZA", "SouthAfrica" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 161,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SS", "SouthSudan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 162,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "ES", "Spain" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 163,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "LK", "SriLanka" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 164,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SD", "Sudan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 165,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SR", "Suriname" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 166,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SE", "Sweden" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 167,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "CH", "Switzerland" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 168,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "SY", "Syria" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 169,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TW", "Taiwan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 170,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TJ", "Tajikistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 171,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TZ", "Tanzania" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 172,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TH", "Thailand" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 173,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TL", "TimorLeste" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 174,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TG", "Togo" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 175,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TO", "Tonga" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 176,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TT", "TrinidadAndTobago" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 177,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TN", "Tunisia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 178,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TR", "Turkey" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 179,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TM", "Turkmenistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 180,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "TV", "Tuvalu" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 181,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "UG", "Uganda" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 182,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "UA", "Ukraine" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 183,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "AE", "UnitedArabEmirates" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 184,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "GB", "UnitedKingdom" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 185,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "US", "UnitedStates" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 186,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "UY", "Uruguay" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 187,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "UZ", "Uzbekistan" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 188,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "VU", "Vanuatu" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 189,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "VA", "VaticanCity" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 190,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "VE", "Venezuela" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 191,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "VN", "Vietnam" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 192,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "YE", "Yemen" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 193,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "ZM", "Zambia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 194,
                columns: new[] { "CountryCode", "CountryName" },
                values: new object[] { "ZW", "Zimbabwe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "Country");

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
    }
}
