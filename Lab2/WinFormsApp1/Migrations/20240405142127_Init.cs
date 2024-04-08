using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    lon = table.Column<float>(type: "REAL", nullable: false),
                    lat = table.Column<float>(type: "REAL", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    temp = table.Column<float>(type: "REAL", nullable: true),
                    feels_like = table.Column<float>(type: "REAL", nullable: true),
                    pressure = table.Column<float>(type: "REAL", nullable: true),
                    humidity = table.Column<float>(type: "REAL", nullable: true),
                    speed = table.Column<float>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "description", "feels_like", "humidity", "lat", "lon", "name", "pressure", "speed", "temp" },
                values: new object[,]
                {
                    { 1, null, null, null, 0f, 0f, "Gorzow", null, null, null },
                    { 2, null, null, null, 0f, 0f, "Krakow", null, null, null },
                    { 3, null, null, null, 0f, 0f, "Gdansk", null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
