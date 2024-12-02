using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoodFlix.Migrations
{
    /// <inheritdoc />
    public partial class MySQLMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CountryCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountryName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DirectorName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.DirectorId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Emotion",
                columns: table => new
                {
                    EmotionId = table.Column<int>(type: "int", nullable: false),
                    EmotionName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emotion", x => x.EmotionId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    GenreName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Overview = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorizontalPosterw360 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorizontalPosterw480 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorizontalPosterw720 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlatformName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform", x => x.PlatformId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DirectorMovie",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorMovie", x => new { x.DirectorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_DirectorMovie_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "DirectorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectorMovie_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenreId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CountryPlatform",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false),
                    CountryCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    RegisterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.RegisterId);
                    table.ForeignKey(
                        name: "FK_History_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_History_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserGenre",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    IsPreferred = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGenre", x => new { x.UserId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_UserGenre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGenre_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserPlatform",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlatform", x => new { x.UserId, x.PlatformId });
                    table.ForeignKey(
                        name: "FK_UserPlatform_Platform_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platform",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPlatform_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HistoryEmotion",
                columns: table => new
                {
                    HistoryEmotionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RegisterId = table.Column<int>(type: "int", nullable: false),
                    EmotionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryEmotion", x => x.HistoryEmotionId);
                    table.ForeignKey(
                        name: "FK_HistoryEmotion_Emotion_EmotionId",
                        column: x => x.EmotionId,
                        principalTable: "Emotion",
                        principalColumn: "EmotionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryEmotion_History_RegisterId",
                        column: x => x.RegisterId,
                        principalTable: "History",
                        principalColumn: "RegisterId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "CountryCode", "CountryName" },
                values: new object[,]
                {
                    { 0, "AF", "Afghanistan" },
                    { 1, "AL", "Albania" },
                    { 2, "DZ", "Algeria" },
                    { 3, "AD", "Andorra" },
                    { 4, "AO", "Angola" },
                    { 5, "AG", "Antigua And Barbuda" },
                    { 6, "AR", "Argentina" },
                    { 7, "AM", "Armenia" },
                    { 8, "AU", "Australia" },
                    { 9, "AT", "Austria" },
                    { 10, "AZ", "Azerbaijan" },
                    { 11, "BS", "Bahamas" },
                    { 12, "BH", "Bahrain" },
                    { 13, "BD", "Bangladesh" },
                    { 14, "BB", "Barbados" },
                    { 15, "BY", "Belarus" },
                    { 16, "BE", "Belgium" },
                    { 17, "BZ", "Belize" },
                    { 18, "BJ", "Benin" },
                    { 19, "BT", "Bhutan" },
                    { 20, "BO", "Bolivia" },
                    { 21, "BA", "Bosnia And Herzegovina" },
                    { 22, "BW", "Botswana" },
                    { 23, "BR", "Brazil" },
                    { 24, "BN", "Brunei" },
                    { 25, "BG", "Bulgaria" },
                    { 26, "BF", "BurkinaFaso" },
                    { 27, "BI", "Burundi" },
                    { 28, "KH", "Cambodia" },
                    { 29, "CM", "Cameroon" },
                    { 30, "CA", "Canada" },
                    { 31, "CV", "CapeVerde" },
                    { 32, "CF", "Central African Republic" },
                    { 33, "TD", "Chad" },
                    { 34, "CL", "Chile" },
                    { 35, "CN", "China" },
                    { 36, "CO", "Colombia" },
                    { 37, "KM", "Comoros" },
                    { 38, "CD", "Congo Democratic Republic" },
                    { 39, "CG", "Congo Republic" },
                    { 40, "CR", "CostaRica" },
                    { 41, "HR", "Croatia" },
                    { 42, "CU", "Cuba" },
                    { 43, "CY", "Cyprus" },
                    { 44, "CZ", "Czech Republic" },
                    { 45, "DK", "Denmark" },
                    { 46, "DJ", "Djibouti" },
                    { 47, "DM", "Dominica" },
                    { 48, "DO", "Dominican Republic" },
                    { 49, "EC", "Ecuador" },
                    { 50, "EG", "Egypt" },
                    { 51, "SV", "El Salvador" },
                    { 52, "GQ", "Equatorial Guinea" },
                    { 53, "ER", "Eritrea" },
                    { 54, "EE", "Estonia" },
                    { 55, "SZ", "Eswatini" },
                    { 56, "ET", "Ethiopia" },
                    { 57, "FJ", "Fiji" },
                    { 58, "FI", "Finland" },
                    { 59, "FR", "France" },
                    { 60, "GA", "Gabon" },
                    { 61, "GM", "Gambia" },
                    { 62, "GE", "Georgia" },
                    { 63, "DE", "Germany" },
                    { 64, "GH", "Ghana" },
                    { 65, "GR", "Greece" },
                    { 66, "GD", "Grenada" },
                    { 67, "GT", "Guatemala" },
                    { 68, "GN", "Guinea" },
                    { 69, "GW", "Guinea Bissau" },
                    { 70, "GY", "Guyana" },
                    { 71, "HT", "Haiti" },
                    { 72, "HN", "Honduras" },
                    { 73, "HU", "Hungary" },
                    { 74, "IS", "Iceland" },
                    { 75, "IN", "India" },
                    { 76, "ID", "Indonesia" },
                    { 77, "IR", "Iran" },
                    { 78, "IQ", "Iraq" },
                    { 79, "IE", "Ireland" },
                    { 80, "IL", "Israel" },
                    { 81, "IT", "Italy" },
                    { 82, "JM", "Jamaica" },
                    { 83, "JP", "Japan" },
                    { 84, "JO", "Jordan" },
                    { 85, "KZ", "Kazakhstan" },
                    { 86, "KE", "Kenya" },
                    { 87, "KI", "Kiribati" },
                    { 88, "KP", "Korea North" },
                    { 89, "KR", "Korea South" },
                    { 90, "KW", "Kuwait" },
                    { 91, "KG", "Kyrgyzstan" },
                    { 92, "LA", "Laos" },
                    { 93, "LV", "Latvia" },
                    { 94, "LB", "Lebanon" },
                    { 95, "LS", "Lesotho" },
                    { 96, "LR", "Liberia" },
                    { 97, "LY", "Libya" },
                    { 98, "LI", "Liechtenstein" },
                    { 99, "LT", "Lithuania" },
                    { 100, "LU", "Luxembourg" },
                    { 101, "MG", "Madagascar" },
                    { 102, "MW", "Malawi" },
                    { 103, "MY", "Malaysia" },
                    { 104, "MV", "Maldives" },
                    { 105, "ML", "Mali" },
                    { 106, "MT", "Malta" },
                    { 107, "MH", "Marshall Islands" },
                    { 108, "MR", "Mauritania" },
                    { 109, "MU", "Mauritius" },
                    { 110, "MX", "Mexico" },
                    { 111, "FM", "Micronesia" },
                    { 112, "MD", "Moldova" },
                    { 113, "MC", "Monaco" },
                    { 114, "MN", "Mongolia" },
                    { 115, "ME", "Montenegro" },
                    { 116, "MA", "Morocco" },
                    { 117, "MZ", "Mozambique" },
                    { 118, "MM", "Myanmar" },
                    { 119, "NA", "Namibia" },
                    { 120, "NR", "Nauru" },
                    { 121, "NP", "Nepal" },
                    { 122, "NL", "Netherlands" },
                    { 123, "NZ", "New Zealand" },
                    { 124, "NI", "Nicaragua" },
                    { 125, "NE", "Niger" },
                    { 126, "NG", "Nigeria" },
                    { 127, "MK", "North Macedonia" },
                    { 128, "NO", "Norway" },
                    { 129, "OM", "Oman" },
                    { 130, "PK", "Pakistan" },
                    { 131, "PW", "Palau" },
                    { 132, "PS", "Palestine" },
                    { 133, "PA", "Panama" },
                    { 134, "PG", "Papua New Guinea" },
                    { 135, "PY", "Paraguay" },
                    { 136, "PE", "Peru" },
                    { 137, "PH", "Philippines" },
                    { 138, "PL", "Poland" },
                    { 139, "PT", "Portugal" },
                    { 140, "QA", "Qatar" },
                    { 141, "RO", "Romania" },
                    { 142, "RU", "Russia" },
                    { 143, "RW", "Rwanda" },
                    { 144, "KN", "SaintKitts And Nevis" },
                    { 145, "LC", "Saint Lucia" },
                    { 146, "VC", "Saint Vincent And The Grenadines" },
                    { 147, "WS", "Samoa" },
                    { 148, "SM", "San Marino" },
                    { 149, "ST", "Sao Tome And Principe" },
                    { 150, "SA", "Saudi Arabia" },
                    { 151, "SN", "Senegal" },
                    { 152, "RS", "Serbia" },
                    { 153, "SC", "Seychelles" },
                    { 154, "SL", "Sierra Leone" },
                    { 155, "SG", "Singapore" },
                    { 156, "SK", "Slovakia" },
                    { 157, "SI", "Slovenia" },
                    { 158, "SB", "Solomon Is lands" },
                    { 159, "SO", "Somalia" },
                    { 160, "ZA", "South Africa" },
                    { 161, "SS", "South Sudan" },
                    { 162, "ES", "Spain" },
                    { 163, "LK", "SriLanka" },
                    { 164, "SD", "Sudan" },
                    { 165, "SR", "Suriname" },
                    { 166, "SE", "Sweden" },
                    { 167, "CH", "Switzerland" },
                    { 168, "SY", "Syria" },
                    { 169, "TW", "Taiwan" },
                    { 170, "TJ", "Tajikistan" },
                    { 171, "TZ", "Tanzania" },
                    { 172, "TH", "Thailand" },
                    { 173, "TL", "Timor Leste" },
                    { 174, "TG", "Togo" },
                    { 175, "TO", "Tonga" },
                    { 176, "TT", "Trinidad And Tobago" },
                    { 177, "TN", "Tunisia" },
                    { 178, "TR", "Turkey" },
                    { 179, "TM", "Turkmenistan" },
                    { 180, "TV", "Tuvalu" },
                    { 181, "UG", "Uganda" },
                    { 182, "UA", "Ukraine" },
                    { 183, "AE", "United Arab Emirates" },
                    { 184, "GB", "United Kingdom" },
                    { 185, "US", "United States" },
                    { 186, "UY", "Uruguay" },
                    { 187, "UZ", "Uzbekistan" },
                    { 188, "VU", "Vanuatu" },
                    { 189, "VA", "Vatican City" },
                    { 190, "VE", "Venezuela" },
                    { 191, "VN", "Vietnam" },
                    { 192, "YE", "Yemen" },
                    { 193, "ZM", "Zambia" },
                    { 194, "ZW", "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                table: "Emotion",
                columns: new[] { "EmotionId", "EmotionName" },
                values: new object[,]
                {
                    { 0, "Boredom" },
                    { 1, "Admiration" },
                    { 2, "Adoration" },
                    { 3, "Joy" },
                    { 4, "Love" },
                    { 5, "Craving" },
                    { 6, "Anxiety" },
                    { 7, "AestheticAppreciation" },
                    { 8, "Amazement" },
                    { 9, "Calmness" },
                    { 10, "Confusion" },
                    { 11, "Lust" },
                    { 12, "Disgust" },
                    { 13, "Fun" },
                    { 14, "EmpathicPain" },
                    { 15, "Anger" },
                    { 16, "Envy" },
                    { 17, "Ecstasy" },
                    { 18, "Horror" },
                    { 19, "Interest" },
                    { 20, "Fear" },
                    { 21, "Nostalgia" },
                    { 22, "Satisfaction" },
                    { 23, "Sympathy" },
                    { 24, "Sadness" },
                    { 25, "Triumph" },
                    { 26, "Shame" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[,]
                {
                    { 0, "Action" },
                    { 1, "Adventure" },
                    { 2, "Animation" },
                    { 3, "Comedy" },
                    { 4, "Crime" },
                    { 5, "Documentary" },
                    { 6, "Drama" },
                    { 7, "Family" },
                    { 8, "Fantasy" },
                    { 9, "History" },
                    { 10, "Horror" },
                    { 11, "Music" },
                    { 12, "Mystery" },
                    { 13, "News" },
                    { 14, "Reality" },
                    { 15, "Romance" },
                    { 16, "ScienceFiction" },
                    { 17, "TalkShow" },
                    { 18, "Thriller" },
                    { 19, "War" },
                    { 20, "Western" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryPlatform_PlatformId",
                table: "CountryPlatform",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorMovie_MovieId",
                table: "DirectorMovie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MovieId",
                table: "GenreMovie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_History_MovieId",
                table: "History",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_History_UserId",
                table: "History",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryEmotion_EmotionId",
                table: "HistoryEmotion",
                column: "EmotionId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryEmotion_RegisterId",
                table: "HistoryEmotion",
                column: "RegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CountryId",
                table: "User",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGenre_GenreId",
                table: "UserGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlatform_PlatformId",
                table: "UserPlatform",
                column: "PlatformId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryPlatform");

            migrationBuilder.DropTable(
                name: "DirectorMovie");

            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.DropTable(
                name: "HistoryEmotion");

            migrationBuilder.DropTable(
                name: "UserGenre");

            migrationBuilder.DropTable(
                name: "UserPlatform");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropTable(
                name: "Emotion");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
