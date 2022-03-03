﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TISklep.DAL;

namespace TISklep.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20220303144800_Add_Movies")]
    partial class Add_Movies
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TISklep.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Scary movies",
                            Name = "Horror"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Movies based on true stories",
                            Name = "Documentary"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Thrillers",
                            Name = "Thriller"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "Action movies",
                            Name = "Action"
                        },
                        new
                        {
                            CategoryId = 5,
                            Description = "Magical and supernatural elements",
                            Name = "Fantasy"
                        });
                });

            modelBuilder.Entity("TISklep.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Description = "20 sierpnia 1973 roku teksańska policja trafiła do stojącego na uboczu domu Thomasa Hewitta - byłego pracownika lokalnej rzeźni. Na miejscu odkryli rozkładające się zwłoki 33 osób, które zostały zamordowane przez psychopatycznego zabójcę noszącego na twarzy maskę z ludzkiej skóry i posługującego się piłą mechaniczną.",
                            Director = "Marcus Nispel",
                            Price = 10m,
                            ProductionDate = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Teksańska Masakra Piłą Mechaniczną"
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 3,
                            Description = "Mężczyzna dostaje obsesji na punkcie książki, która według niego Descriptionuje i przewiduje jego życie i przyszłość.",
                            Director = "Joel Schumacher",
                            Price = 14m,
                            ProductionDate = new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Numer 23"
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            Description = "Uznany pisarz przenosi się na prowincję, by w spokoju tworzyć kolejne książki. Wkrótce odwiedzi go tajemniczy mężczyzna, który oskarży Raineya o plagiat.",
                            Director = "David Koepp",
                            Price = 12m,
                            ProductionDate = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sekretne Okno"
                        },
                        new
                        {
                            MovieId = 4,
                            CategoryId = 5,
                            Description = "Podróż hobbita z Shire i jego ośmiu towarzyszy, której celem jest zniszczenie potężnego pierścienia pożądanego przez Czarnego Władcę - Saurona.",
                            Director = "Peter Jackson",
                            Price = 20m,
                            ProductionDate = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Władca Pierścieni: Drużyna Pierścienia"
                        },
                        new
                        {
                            MovieId = 5,
                            CategoryId = 4,
                            Description = "Emerytowani agenci specjalni CIA zostają wrobieni w zamach. By się ratować, muszą reaktywować stary zespół.",
                            Director = "Robert Schwentke",
                            Price = 11m,
                            ProductionDate = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Red"
                        },
                        new
                        {
                            MovieId = 6,
                            CategoryId = 2,
                            Description = "Dziennikarz śledczy rozmawia z dziewięcioma księżmi katolickimi, którzy dopuścili się zbrodni pedofilii i molestowania nieletnich, a także ich ofiarami.",
                            Director = "Tomasz Sekielski",
                            Price = 0m,
                            ProductionDate = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Tylko nie mów nikomu"
                        },
                        new
                        {
                            MovieId = 7,
                            CategoryId = 5,
                            Description = "Wiedeń u progu XX w. Syn rzemieślnika, iluzjonista Eisenheim, wykorzystuje niezwykłe umiejętności, by zdobyć miłość arystokratki, narzeczonej austro-węgierskiego księcia.",
                            Director = "Neil Burger",
                            Price = 13m,
                            ProductionDate = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Iluzjonista"
                        },
                        new
                        {
                            MovieId = 8,
                            CategoryId = 3,
                            Description = "Grupa osób budzi się w pełnym śmiertelnych pułapek sześcianie. Nieznajomi muszą zacząć współpracować ze sobą, by przeżyć.",
                            Director = "Vincenzo Natali",
                            Price = 15m,
                            ProductionDate = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Cube"
                        },
                        new
                        {
                            MovieId = 9,
                            CategoryId = 1,
                            Description = "Frank Cotton nabywa tajemniczą kostkę, za pomocą której można przywołać demony z piekła.",
                            Director = "Clive Barker",
                            Price = 16m,
                            ProductionDate = new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hellraiser: Wysłannik Piekieł"
                        },
                        new
                        {
                            MovieId = 10,
                            CategoryId = 3,
                            Description = "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary.",
                            Director = "Jonathan Demme",
                            Price = 17m,
                            ProductionDate = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Milczenie Owiec"
                        });
                });

            modelBuilder.Entity("TISklep.Models.Movie", b =>
                {
                    b.HasOne("TISklep.Models.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TISklep.Models.Category", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
