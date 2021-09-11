using System;
using CineMania.Models;
using Microsoft.EntityFrameworkCore;

namespace CineMania.Data
{
    public class CinemaniaContext : DbContext
    {
        public CinemaniaContext(DbContextOptions<CinemaniaContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             var movies = new Movie[]
            {
                new Movie
                {
                    Id = 1,
                    Title = "Black Widow",
                    Description = "A film about Natasha Romanoff in her quests " +
                                  "between the films Civil War and Infinity War.",
                    ImageName = "black_widow.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2021-07-09")
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Tomorrow War",
                    Description = "A family man is drafted to fight in a future war where " +
                                  "the fate of humanity relies on his ability to confront the past.",
                    ImageName = "the_tomorrow_war.jpg",
                    Genre = "Sci-Fi",
                    ReleaseDate = DateTime.Parse("2021-07-02")
                },
                new Movie
                {
                    Id = 3,
                    Title = "Pitch Perfect",
                    Description = "Beca, a freshman at Barden University, is cajoled into joining The Bellas, " +
                                  "her school's all-girls singing group. Injecting some much needed energy into " +
                                  "their repertoire, The Bellas take on their male rivals in a campus competition",
                    ImageName = "black_widow.jpg",
                    Genre = "Comedy",
                    ReleaseDate = DateTime.Parse("2013-09-24")
                },
                new Movie
                {
                    Id = 4,
                    Title = "The Hills Have Eyes",
                    Description = "A family falls victim to a group of mutated cannibals " +
                                  "in a desert far away from civilization.",
                    ImageName = "hills_have_eyes.jpg",
                    Genre = "Horror",
                    ReleaseDate = DateTime.Parse("2006-11-11")
                },
                new Movie
                {
                    Id = 5,
                    Title = "Up",
                    Description = "78-year-old Carl Fredricksen travels to Paradise Falls in his house " +
                                  "equipped with balloons, inadvertently taking a young stowaway",
                    ImageName = "up.jpg",
                    Genre = "Animation",
                    ReleaseDate = DateTime.Parse("2009-03-01")
                },
                new Movie
                {
                    Id = 6,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of " +
                                  "diner bandits intertwine in four tales of violence and redemption.",
                    ImageName = "pulp_fiction.jpg",
                    Genre = "Crime",
                    ReleaseDate = DateTime.Parse("1994-12-05")
                },
                new Movie
                {
                    Id = 7,
                    Title = "Rocky",
                    Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion " +
                                  "in a bout in which he strives to go the distance for his self-respect.",
                    ImageName = "rocky.jpg",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                
                 new Movie
                {
                    Id = 8,
                    Title = "evildead",
                    Description = "The Evil Dead is a 1981 American supernatural horror film written and directed by" +
                                  " Sam Raimi, ... The film's high-definition debut was in a 2010 Blu-ray",
                    ImageName = "image.jpg",
                    Genre = "action",
                    ReleaseDate = DateTime.Parse("2014-02-06")
                },
                new Movie
                {
                    Id = 9,
                    Title = "hrithicshan",
                    Description = "hrithicshan  is the indian movies played by tiger sinopf and prity girl, drafted to fight in a future war where " +
                                  "the fate of humanity relies on his ability to confront the past.",
                    ImageName = "image1.jpg",
                    Genre = "romantic",
                    ReleaseDate = DateTime.Parse("2020-05-07")
                },
                new Movie
                {
                    Id = 10,
                    Title = "jesus",
                    Description = "For many scholars, Revelation 1:14-15 offers a clue that Jesus's skin was a darker hue and that his hair was woolly in texture. " +
                                  "The hairs of his head, it says, were white as white wool, white as snow",
                    ImageName = "image2.jpg",
                    Genre = "drama",
                    ReleaseDate = DateTime.Parse("2015-07-05")
                },
                new Movie
                {
                    Id = 11,
                    Title = "kykehna",
                    Description = "Kya Kehna (English: So well Said) is a 2000 Indian Hindi " +
                                  "romantic drama film. ... Kya Kehna dealt with" +
                                  " the taboo issue of pre-marital pregnancy and society views ",
                    ImageName = "image3.jpg",
                    Genre = "hollow",
                    ReleaseDate = DateTime.Parse("1998-12-05")
                },
                new Movie
                {
                    Id = 12,
                    Title = "shooter",
                    Description = "A highly decorated ex-Marine sniper returns to action " +
                                  "to foil an assassination plot targeting the president," +
                                  " but soon finds himself framed for murder.",
                    ImageName = "image4.jpg",
                    Genre = "action",
                    ReleaseDate = DateTime.Parse("2010-01-24")
                },
                new Movie
                {
                    Id = 13,
                    Title = "pusongligaw",
                    Description = "is a 2017 Philippine melodrama television series " +
                                  "starring Beauty Gonzalez, ... ABS-CBN television drama filmed in high, " +
                                  "is drafted to fight in a future war where " +
                                  "the fate of humanity relies on his ability to confront the past.",
                    ImageName = "image5.jpg",
                    Genre = "romantic",
                    ReleaseDate = DateTime.Parse("2022-06-12")
                },
                new Movie
                {
                    Id = 14,
                    Title = "crocodile",
                    Description = "Crocodiles have powerful jaws with many conical teeth and short legs with clawed webbed toes. They share a unique body " +
                                  "form that allows the eyes, ears, and nostrils to be above the water surface while mos.",
                    ImageName = "image7.jpg",
                    Genre = "drama",
                    ReleaseDate = DateTime.Parse("2011-01-03")
                },
                new Movie
                {
                    Id = 15,
                    Title = "superman",
                    Description = "Superman is a fictional character and a superhero who first appeared " +
                                  "in American comic books published by DC Comics. ... He was found and adopted by farmers ",
                    ImageName = "image8.jpg",
                    Genre = "catoon",
                    ReleaseDate = DateTime.Parse("1899-04-30")
                },
                new Movie
                {
                    Id = 16,
                    Title = "anaconda",
                    Description = "redemption a man from united state who fight with a thousand and thousand people ,is drafted to fight in a future war where " +
                                  "the fate of humanity relies on his ability to confront the past.",
                    ImageName = "up.jpg",
                    Genre = "action",
                    ReleaseDate = DateTime.Parse("2000-04-06")
                },
                new Movie
                {
                    Id = 17,
                    Title = "war",
                    Description = "Zombies are the main antagonists of the World War Z franchise. " +
                                  "They are the reanimated corpses of dead humans and" +
                                  "are extremely violent beings that attack anything living to eat, kill, and infect..",
                    ImageName = "image9.jpg",
                    Genre = "action",
                    ReleaseDate = DateTime.Parse("2021-08-13")
                },
            };
          
            modelBuilder.Entity<Movie>().HasData(movies);
            base.OnModelCreating(modelBuilder);
        }
    }
}