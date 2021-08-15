﻿// <auto-generated />
using System;
using CineMania.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CineMania.Migrations
{
    [DbContext(typeof(CinemaniaContext))]
    [Migration("20210811101230_tenphoto")]
    partial class tenphoto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("CineMania.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A film about Natasha Romanoff in her quests between the films Civil War and Infinity War.",
                            Genre = "Action",
                            ImageName = "black_widow.jpg",
                            ReleaseDate = new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Black Widow"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.",
                            Genre = "Sci-Fi",
                            ImageName = "the_tomorrow_war.jpg",
                            ReleaseDate = new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Tomorrow War"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Beca, a freshman at Barden University, is cajoled into joining The Bellas, her school's all-girls singing group. Injecting some much needed energy into their repertoire, The Bellas take on their male rivals in a campus competition",
                            Genre = "Comedy",
                            ImageName = "black_widow.jpg",
                            ReleaseDate = new DateTime(2013, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pitch Perfect"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A family falls victim to a group of mutated cannibals in a desert far away from civilization.",
                            Genre = "Horror",
                            ImageName = "hills_have_eyes.jpg",
                            ReleaseDate = new DateTime(2006, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Hills Have Eyes"
                        },
                        new
                        {
                            Id = 5,
                            Description = "78-year-old Carl Fredricksen travels to Paradise Falls in his house equipped with balloons, inadvertently taking a young stowaway",
                            Genre = "Animation",
                            ImageName = "up.jpg",
                            ReleaseDate = new DateTime(2009, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Up"
                        },
                        new
                        {
                            Id = 6,
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            Genre = "Crime",
                            ImageName = "pulp_fiction.jpg",
                            ReleaseDate = new DateTime(1994, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pulp Fiction"
                        },
                        new
                        {
                            Id = 7,
                            Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.",
                            Genre = "Drama",
                            ImageName = "rocky.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rocky"
                        },
                        new
                        {
                            Id = 8,
                            Description = "he Man in the Moon refers to any of several pareidolic images of a human face, head or body that certain traditions recognize in the disc of the full moon.",
                            Genre = "Sci-Fi",
                            ImageName = "image.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "man_moon"
                        },
                        new
                        {
                            Id = 9,
                            Description = "In Hinduism, the Vasus (Sanskrit: वसु) are attendant deities of Indra, and later Vishnu. The Ashta Vasus are described in the Ramayana as the children of Kasyapa and Aditi and in the Mahabharata as the sons of Manu or Brahma Prajapati.",
                            Genre = "comedy",
                            ImageName = "image1.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "vasu"
                        },
                        new
                        {
                            Id = 10,
                            Description = "AJackie Chan, originally Chan Kong-sang, (born April 7, 1954, Hong Kong), Hong Kong-born Chinese stuntman, actor, and director whose perilous acrobatic stunts and engaging physical humour made him an action-film.",
                            Genre = "action",
                            ImageName = "image2.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "jack"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Born in Beijing, China, on April 26, 1963, Jet Li is an actor and martial artist. At the age of 11, Li won his first national championship in wushu. Li retired from the.",
                            Genre = "action",
                            ImageName = "image3.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "jetli"
                        },
                        new
                        {
                            Id = 12,
                            Description = "A dragon is usually represented as a huge, bat-winged, fire-breathing, scaly lizard or snake with a barbed tail. The belief in these creatures apparently arose without the slightest knowledge",
                            Genre = "Horror",
                            ImageName = "image4.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "dragon"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Maria is a 2019 Filipino action film directed by Pedring Lopez and written by Pedring Lopez and Yz Carbonell. The plot revolves around Maria (Cristine Reyes), a former hired.",
                            Genre = "Animation",
                            ImageName = "image5.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "maria"
                        },
                        new
                        {
                            Id = 14,
                            Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.",
                            Genre = "comedy",
                            ImageName = "image6.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "lavi"
                        },
                        new
                        {
                            Id = 15,
                            Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.",
                            Genre = "Horror",
                            ImageName = "image7.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "jungo"
                        },
                        new
                        {
                            Id = 16,
                            Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.",
                            Genre = "Drama",
                            ImageName = "image8.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "vampaya"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Baahubali-The Beginning (2015) is essentially about a tribal warrior boy, Shivudu who learns his past and awaits his destiny..",
                            Genre = "romantic",
                            ImageName = "image9.jpg",
                            ReleaseDate = new DateTime(1976, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "indian"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}