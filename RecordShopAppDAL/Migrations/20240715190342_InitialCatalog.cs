using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordShopAppDAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCatalog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DropDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Artist = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DisctountRate = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DropDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreateDate", "DropDate", "Password", "UserName" },
                values: new object[] { 1, new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2314), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BC4A26B5A4ABEDFD6D1A3F78E5AADA2162C4B1A908DE7A70E1B3A0B26E27E6E6", "admin" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumName", "Artist", "CreateDate", "DisctountRate", "DropDate", "Genre", "Price", "ReleaseDate", "Status" },
                values: new object[,]
                {
                    { 1, "Thriller", "Michael Jackson", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2424), 10m, null, 0, 29.99m, new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 2, "Back in Black", "AC/DC", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2429), 15m, null, 1, 24.99m, new DateTime(1980, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 3, "The Dark Side of the Moon", "Pink Floyd", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2431), 20m, null, 1, 19.99m, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discontunied" },
                    { 4, "The Wall", "Pink Floyd", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2432), 5m, null, 1, 22.99m, new DateTime(1979, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 5, "Abbey Road", "The Beatles", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2434), 12m, null, 1, 27.99m, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 6, "Hotel California", "Eagles", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2436), 15m, null, 1, 25.99m, new DateTime(1976, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 7, "Led Zeppelin IV", "Led Zeppelin", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2465), 10m, null, 1, 21.99m, new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 8, "Born to Run", "Bruce Springsteen", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2466), 8m, null, 1, 23.99m, new DateTime(1975, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 9, "Rumours", "Fleetwood Mac", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2468), 10m, null, 1, 24.99m, new DateTime(1977, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discontunied" },
                    { 10, "Nevermind", "Nirvana", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2469), 5m, null, 1, 19.99m, new DateTime(1991, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 11, "Sgt. Pepper's Lonely Hearts Club Band", "The Beatles", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2471), 10m, null, 1, 26.99m, new DateTime(1967, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 12, "A Night at the Opera", "Queen", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2472), 7m, null, 1, 22.99m, new DateTime(1975, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 13, "The Joshua Tree", "U2", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2474), 12m, null, 1, 24.99m, new DateTime(1987, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 14, "Who's Next", "The Who", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2476), 10m, null, 1, 21.99m, new DateTime(1971, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discontunied" },
                    { 15, "Purple Rain", "Prince", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2478), 8m, null, 0, 22.99m, new DateTime(1984, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 16, "The Rise and Fall of Ziggy Stardust and the Spiders from Mars", "David Bowie", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2480), 15m, null, 1, 20.99m, new DateTime(1972, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 17, "Sticky Fingers", "The Rolling Stones", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2481), 10m, null, 1, 23.99m, new DateTime(1971, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 18, "The Velvet Underground & Nico", "The Velvet Underground", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2483), 12m, null, 1, 21.99m, new DateTime(1967, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discontunied" },
                    { 19, "OK Computer", "Radiohead", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2484), 8m, null, 1, 22.99m, new DateTime(1997, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" },
                    { 20, "The Miseducation of Lauryn Hill", "Lauryn Hill", new DateTime(2024, 7, 15, 22, 3, 41, 870, DateTimeKind.Local).AddTicks(2486), 10m, null, 0, 24.99m, new DateTime(1998, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnSale" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_Password",
                table: "Admins",
                column: "Password",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
