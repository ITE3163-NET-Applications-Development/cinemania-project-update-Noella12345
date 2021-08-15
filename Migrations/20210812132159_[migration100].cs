using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineMania.Migrations
{
    public partial class migration100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false),
                    Message = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "The Evil Dead is a 1981 American supernatural horror film written and directed by Sam Raimi, ... The film's high-definition debut was in a 2010 Blu-ray", "action", "evildead.jpg", new DateTime(2014, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "evildead" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "hrithicshan  is the indian movies played by tiger sinopf and prity girl, drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "romantic", "hrithicshan.jpg", new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "hrithicshan" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "For many scholars, Revelation 1:14-15 offers a clue that Jesus's skin was a darker hue and that his hair was woolly in texture. The hairs of his head, it says, were white as white wool, white as snow", "drama", "jesus.jpg", new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "jesus" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "Kya Kehna (English: So well Said) is a 2000 Indian Hindi romantic drama film. ... Kya Kehna dealt with the taboo issue of pre-marital pregnancy and society views ", "hollow", "kykehna.jpg", new DateTime(1998, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "kykehna" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "A highly decorated ex-Marine sniper returns to action to foil an assassination plot targeting the president, but soon finds himself framed for murder.", "action", "shooter.jpg", new DateTime(2010, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "shooter" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "is a 2017 Philippine melodrama television series starring Beauty Gonzalez, ... ABS-CBN television drama filmed in high, is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "romantic", "pusongligaw.jpg", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "pusongligaw" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "Crocodiles have powerful jaws with many conical teeth and short legs with clawed webbed toes. They share a unique body form that allows the eyes, ears, and nostrils to be above the water surface while mos.", "drama", "crocodile.jpg", new DateTime(2011, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "crocodile" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "Superman is a fictional character and a superhero who first appeared in American comic books published by DC Comics. ... He was found and adopted by farmers ", "catoon", "superman.jpg", new DateTime(1899, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "superman" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "redemption a man from united state who fight with a thousand and thousand people ,is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "action", "anaconda.jpg", new DateTime(2000, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "anaconda" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "Zombies are the main antagonists of the World War Z franchise. They are the reanimated corpses of dead humans andare extremely violent beings that attack anything living to eat, kill, and infect..", "action", "war.jpg", new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "war" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "he Man in the Moon refers to any of several pareidolic images of a human face, head or body that certain traditions recognize in the disc of the full moon.", "Sci-Fi", "image.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "man_moon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "In Hinduism, the Vasus (Sanskrit: वसु) are attendant deities of Indra, and later Vishnu. The Ashta Vasus are described in the Ramayana as the children of Kasyapa and Aditi and in the Mahabharata as the sons of Manu or Brahma Prajapati.", "comedy", "image1.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "vasu" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "AJackie Chan, originally Chan Kong-sang, (born April 7, 1954, Hong Kong), Hong Kong-born Chinese stuntman, actor, and director whose perilous acrobatic stunts and engaging physical humour made him an action-film.", "action", "image2.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "Born in Beijing, China, on April 26, 1963, Jet Li is an actor and martial artist. At the age of 11, Li won his first national championship in wushu. Li retired from the.", "action", "image3.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "jetli" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "A dragon is usually represented as a huge, bat-winged, fire-breathing, scaly lizard or snake with a barbed tail. The belief in these creatures apparently arose without the slightest knowledge", "Horror", "image4.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "dragon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "Maria is a 2019 Filipino action film directed by Pedring Lopez and written by Pedring Lopez and Yz Carbonell. The plot revolves around Maria (Cristine Reyes), a former hired.", "Animation", "image5.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "maria" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "comedy", "image6.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "lavi" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Horror", "image7.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "jungo" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "image8.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "vampaya" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { "Baahubali-The Beginning (2015) is essentially about a tribal warrior boy, Shivudu who learns his past and awaits his destiny..", "romantic", "image9.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "indian" });
        }
    }
}
