using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoodFlix.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.DirectorId);
                });

            migrationBuilder.CreateTable(
                name: "Emotion",
                columns: table => new
                {
                    EmotionId = table.Column<int>(type: "int", nullable: false),
                    EmotionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emotion", x => x.EmotionId);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorizontalPosterw360 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorizontalPosterw480 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorizontalPosterw720 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform", x => x.PlatformId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                });

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
                });

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
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    RegisterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "UserGenre",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    IsPreferred = table.Column<bool>(type: "bit", nullable: false)
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
                });

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
                });

            migrationBuilder.CreateTable(
                name: "HistoryEmotion",
                columns: table => new
                {
                    HistoryEmotionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { 0, "Afghanistan" },
                    { 1, "Albania" },
                    { 2, "Algeria" },
                    { 3, "Andorra" },
                    { 4, "Angola" },
                    { 5, "AntiguaAndBarbuda" },
                    { 6, "Argentina" },
                    { 7, "Armenia" },
                    { 8, "Australia" },
                    { 9, "Austria" },
                    { 10, "Azerbaijan" },
                    { 11, "Bahamas" },
                    { 12, "Bahrain" },
                    { 13, "Bangladesh" },
                    { 14, "Barbados" },
                    { 15, "Belarus" },
                    { 16, "Belgium" },
                    { 17, "Belize" },
                    { 18, "Benin" },
                    { 19, "Bhutan" },
                    { 20, "Bolivia" },
                    { 21, "BosniaAndHerzegovina" },
                    { 22, "Botswana" },
                    { 23, "Brazil" },
                    { 24, "Brunei" },
                    { 25, "Bulgaria" },
                    { 26, "BurkinaFaso" },
                    { 27, "Burundi" },
                    { 28, "Cambodia" },
                    { 29, "Cameroon" },
                    { 30, "Canada" },
                    { 31, "CapeVerde" },
                    { 32, "CentralAfricanRepublic" },
                    { 33, "Chad" },
                    { 34, "Chile" },
                    { 35, "China" },
                    { 36, "Colombia" },
                    { 37, "Comoros" },
                    { 38, "CongoDemocraticRepublic" },
                    { 39, "CongoRepublic" },
                    { 40, "CostaRica" },
                    { 41, "Croatia" },
                    { 42, "Cuba" },
                    { 43, "Cyprus" },
                    { 44, "CzechRepublic" },
                    { 45, "Denmark" },
                    { 46, "Djibouti" },
                    { 47, "Dominica" },
                    { 48, "DominicanRepublic" },
                    { 49, "Ecuador" },
                    { 50, "Egypt" },
                    { 51, "ElSalvador" },
                    { 52, "EquatorialGuinea" },
                    { 53, "Eritrea" },
                    { 54, "Estonia" },
                    { 55, "Eswatini" },
                    { 56, "Ethiopia" },
                    { 57, "Fiji" },
                    { 58, "Finland" },
                    { 59, "France" },
                    { 60, "Gabon" },
                    { 61, "Gambia" },
                    { 62, "Georgia" },
                    { 63, "Germany" },
                    { 64, "Ghana" },
                    { 65, "Greece" },
                    { 66, "Grenada" },
                    { 67, "Guatemala" },
                    { 68, "Guinea" },
                    { 69, "GuineaBissau" },
                    { 70, "Guyana" },
                    { 71, "Haiti" },
                    { 72, "Honduras" },
                    { 73, "Hungary" },
                    { 74, "Iceland" },
                    { 75, "India" },
                    { 76, "Indonesia" },
                    { 77, "Iran" },
                    { 78, "Iraq" },
                    { 79, "Ireland" },
                    { 80, "Israel" },
                    { 81, "Italy" },
                    { 82, "Jamaica" },
                    { 83, "Japan" },
                    { 84, "Jordan" },
                    { 85, "Kazakhstan" },
                    { 86, "Kenya" },
                    { 87, "Kiribati" },
                    { 88, "KoreaNorth" },
                    { 89, "KoreaSouth" },
                    { 90, "Kuwait" },
                    { 91, "Kyrgyzstan" },
                    { 92, "Laos" },
                    { 93, "Latvia" },
                    { 94, "Lebanon" },
                    { 95, "Lesotho" },
                    { 96, "Liberia" },
                    { 97, "Libya" },
                    { 98, "Liechtenstein" },
                    { 99, "Lithuania" },
                    { 100, "Luxembourg" },
                    { 101, "Madagascar" },
                    { 102, "Malawi" },
                    { 103, "Malaysia" },
                    { 104, "Maldives" },
                    { 105, "Mali" },
                    { 106, "Malta" },
                    { 107, "MarshallIslands" },
                    { 108, "Mauritania" },
                    { 109, "Mauritius" },
                    { 110, "Mexico" },
                    { 111, "Micronesia" },
                    { 112, "Moldova" },
                    { 113, "Monaco" },
                    { 114, "Mongolia" },
                    { 115, "Montenegro" },
                    { 116, "Morocco" },
                    { 117, "Mozambique" },
                    { 118, "Myanmar" },
                    { 119, "Namibia" },
                    { 120, "Nauru" },
                    { 121, "Nepal" },
                    { 122, "Netherlands" },
                    { 123, "NewZealand" },
                    { 124, "Nicaragua" },
                    { 125, "Niger" },
                    { 126, "Nigeria" },
                    { 127, "NorthMacedonia" },
                    { 128, "Norway" },
                    { 129, "Oman" },
                    { 130, "Pakistan" },
                    { 131, "Palau" },
                    { 132, "Palestine" },
                    { 133, "Panama" },
                    { 134, "PapuaNewGuinea" },
                    { 135, "Paraguay" },
                    { 136, "Peru" },
                    { 137, "Philippines" },
                    { 138, "Poland" },
                    { 139, "Portugal" },
                    { 140, "Qatar" },
                    { 141, "Romania" },
                    { 142, "Russia" },
                    { 143, "Rwanda" },
                    { 144, "SaintKittsAndNevis" },
                    { 145, "SaintLucia" },
                    { 146, "SaintVincentAndTheGrenadines" },
                    { 147, "Samoa" },
                    { 148, "SanMarino" },
                    { 149, "SaoTomeAndPrincipe" },
                    { 150, "SaudiArabia" },
                    { 151, "Senegal" },
                    { 152, "Serbia" },
                    { 153, "Seychelles" },
                    { 154, "SierraLeone" },
                    { 155, "Singapore" },
                    { 156, "Slovakia" },
                    { 157, "Slovenia" },
                    { 158, "SolomonIslands" },
                    { 159, "Somalia" },
                    { 160, "SouthAfrica" },
                    { 161, "SouthSudan" },
                    { 162, "Spain" },
                    { 163, "SriLanka" },
                    { 164, "Sudan" },
                    { 165, "Suriname" },
                    { 166, "Sweden" },
                    { 167, "Switzerland" },
                    { 168, "Syria" },
                    { 169, "Taiwan" },
                    { 170, "Tajikistan" },
                    { 171, "Tanzania" },
                    { 172, "Thailand" },
                    { 173, "TimorLeste" },
                    { 174, "Togo" },
                    { 175, "Tonga" },
                    { 176, "TrinidadAndTobago" },
                    { 177, "Tunisia" },
                    { 178, "Turkey" },
                    { 179, "Turkmenistan" },
                    { 180, "Tuvalu" },
                    { 181, "Uganda" },
                    { 182, "Ukraine" },
                    { 183, "UnitedArabEmirates" },
                    { 184, "UnitedKingdom" },
                    { 185, "UnitedStates" },
                    { 186, "Uruguay" },
                    { 187, "Uzbekistan" },
                    { 188, "Vanuatu" },
                    { 189, "VaticanCity" },
                    { 190, "Venezuela" },
                    { 191, "Vietnam" },
                    { 192, "Yemen" },
                    { 193, "Zambia" },
                    { 194, "Zimbabwe" }
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
