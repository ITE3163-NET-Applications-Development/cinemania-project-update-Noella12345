using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineMania.Migrations
{
    public partial class initialcreation : Migration
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

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ImageName = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 1, "A film about Natasha Romanoff in her quests between the films Civil War and Infinity War.", "Action", "black_widow.jpg", new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Widow" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 15, "Superman is a fictional character and a superhero who first appeared in American comic books published by DC Comics. ... He was found and adopted by farmers ", "catoon", "superman.jpg", new DateTime(1899, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "superman" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 14, "Crocodiles have powerful jaws with many conical teeth and short legs with clawed webbed toes. They share a unique body form that allows the eyes, ears, and nostrils to be above the water surface while mos.", "drama", "crocodile.jpg", new DateTime(2011, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "crocodile" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 13, "is a 2017 Philippine melodrama television series starring Beauty Gonzalez, ... ABS-CBN television drama filmed in high, is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "romantic", "pusongligaw.jpg", new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "pusongligaw" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 12, "A highly decorated ex-Marine sniper returns to action to foil an assassination plot targeting the president, but soon finds himself framed for murder.", "action", "shooter.jpg", new DateTime(2010, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "shooter" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 11, "Kya Kehna (English: So well Said) is a 2000 Indian Hindi romantic drama film. ... Kya Kehna dealt with the taboo issue of pre-marital pregnancy and society views ", "hollow", "kykehna.jpg", new DateTime(1998, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "kykehna" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 10, "For many scholars, Revelation 1:14-15 offers a clue that Jesus's skin was a darker hue and that his hair was woolly in texture. The hairs of his head, it says, were white as white wool, white as snow", "drama", "jesus.jpg", new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "jesus" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 16, "redemption a man from united state who fight with a thousand and thousand people ,is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "action", "anaconda.jpg", new DateTime(2000, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "anaconda" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 9, "hrithicshan  is the indian movies played by tiger sinopf and prity girl, drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "romantic", "hrithicshan.jpg", new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "hrithicshan" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 7, "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.", "Drama", "rocky.jpg", new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 6, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Crime", "pulp_fiction.jpg", new DateTime(1994, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 5, "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway", "Animation", "up.jpg", new DateTime(2009, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Up" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 4, "A family falls victim to a group of mutated cannibals in a desert far away from civilization.", "Horror", "hills_have_eyes.jpg", new DateTime(2006, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hills Have Eyes" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 3, "Beca, a freshman at Barden University, is cajoled into joining The Bellas, her school's all-girls singing group. Injecting some much needed energy into their repertoire, The Bellas take on their male rivals in a campus competition", "Comedy", "black_widow.jpg", new DateTime(2013, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pitch Perfect" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 2, "A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.", "Sci-Fi", "the_tomorrow_war.jpg", new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Tomorrow War" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 8, "The Evil Dead is a 1981 American supernatural horror film written and directed by Sam Raimi, ... The film's high-definition debut was in a 2010 Blu-ray", "action", "evildead.jpg", new DateTime(2014, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "evildead" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Genre", "ImageName", "ReleaseDate", "Title" },
                values: new object[] { 17, "Zombies are the main antagonists of the World War Z franchise. They are the reanimated corpses of dead humans andare extremely violent beings that attack anything living to eat, kill, and infect..", "action", "war.jpg", new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "war" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
