using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCMockDemo.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Action", "Tune in to Action peak movies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Drama", "Tune in to Action peak movies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Thriller", "Tune in to Action peak movies" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cast", "CategoryId", "IsMovieOfTheWeek", "Price", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "Robert", 2, true, 599m, 4.8f, "Avengers" },
                    { 2, "Robert", 2, true, 599m, 4.8f, "12 Angry Men" },
                    { 3, "Robert", 1, false, 599m, 4.8f, "Pulp Fiction" },
                    { 4, "Robert", 2, true, 599m, 4.8f, "Fight Club" },
                    { 5, "Robert", 2, true, 599m, 4.8f, "Avengers" },
                    { 6, "Robert", 1, true, 599m, 4.8f, "Avengers" },
                    { 7, "Robert", 2, false, 599m, 4.8f, "The Godfather" },
                    { 8, "Leo", 3, true, 599m, 4.8f, "Inception" },
                    { 9, "Miles", 2, true, 599m, 4.8f, "Spiderverse" },
                    { 10, "Chris", 3, true, 599m, 4.8f, "Endgame" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
