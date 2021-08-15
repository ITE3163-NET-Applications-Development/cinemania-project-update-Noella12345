using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineMania.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 8, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 9, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 10, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 11, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 12, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 13, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 14, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 15, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 16, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 17, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "image9.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
