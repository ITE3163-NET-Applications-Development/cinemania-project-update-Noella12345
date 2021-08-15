using Microsoft.EntityFrameworkCore.Migrations;

namespace CineMania.Migrations
{
    public partial class migration101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "he Man in the Moon refers to any of several pareidolic images of a human face, head or body that certain traditions recognize in the disc of the full moon.", "Sci-Fi" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "In Hinduism, the Vasus (Sanskrit: वसु) are attendant deities of Indra, and later Vishnu. The Ashta Vasus are described in the Ramayana as the children of Kasyapa and Aditi and in the Mahabharata as the sons of Manu or Brahma Prajapati.", "comedy" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "AJackie Chan, originally Chan Kong-sang, (born April 7, 1954, Hong Kong), Hong Kong-born Chinese stuntman, actor, and director whose perilous acrobatic stunts and engaging physical humour made him an action-film.", "action" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "Born in Beijing, China, on April 26, 1963, Jet Li is an actor and martial artist. At the age of 11, Li won his first national championship in wushu. Li retired from the.", "action" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "A dragon is usually represented as a huge, bat-winged, fire-breathing, scaly lizard or snake with a barbed tail. The belief in these creatures apparently arose without the slightest knowledge", "Horror" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "Maria is a 2019 Filipino action film directed by Pedring Lopez and written by Pedring Lopez and Yz Carbonell. The plot revolves around Maria (Cristine Reyes), a former hired.", "Animation" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Genre",
                value: "comedy");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "Genre",
                value: "Horror");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "Baahubali-The Beginning (2015) is essentially about a tribal warrior boy, Shivudu who learns his past and awaits his destiny..", "romantic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Genre",
                value: "Drama");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "Genre",
                value: "Drama");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Genre" },
                values: new object[] { "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama" });
        }
    }
}
