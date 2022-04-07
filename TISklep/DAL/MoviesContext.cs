using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.Models;

namespace TISklep.DAL
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() 
                { 
                    CategoryId = 1,
                    Name="Horror",
                    Description = "Scary movies",
                },
                new Category()
                {
                    CategoryId = 2,
                    Name = "Documentary",
                    Description = "Movies based on true stories"
                }, 
                new Category()
                {
                    CategoryId = 3,
                    Name = "Thriller",
                    Description = "Thrillers"
                }, 
                new Category()
                {
                    CategoryId = 4,
                    Name = "Action",
                    Description = "Action movies"
                }, 
                new Category()
                {
                    CategoryId = 5,
                    Name = "Fantasy",
                    Description = "Magical and supernatural elements"
                }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Teksańska Masakra Piłą Mechaniczną",
                    Director = "Marcus Nispel",
                    Description = "20 sierpnia 1973 roku teksańska policja trafiła do stojącego na uboczu domu Thomasa Hewitta - byłego pracownika lokalnej rzeźni. Na miejscu odkryli rozkładające się zwłoki 33 osób, które zostały zamordowane przez psychopatycznego zabójcę noszącego na twarzy maskę z ludzkiej skóry i posługującego się piłą mechaniczną.",
                    Price = 10,
                    DataDodania = new DateTime(2020, 5, 4),
                    Plakat= "teksanska-masakra-pila-mechaniczna.jpg"
                },
                new Movie()
                {
                    MovieId = 2,
                    CategoryId = 3,
                    Title = "Numer 23",
                    Director = "Joel Schumacher",
                    Description = "Mężczyzna dostaje obsesji na punkcie książki, która według niego Descriptionuje i przewiduje jego życie i przyszłość.",
                    Price = 14,
                    DataDodania = new DateTime(2021, 3, 16),
                    Plakat = "numer-23.jpg"
                },
                new Movie()
                {
                    MovieId = 3,
                    CategoryId = 3,
                    Title = "Sekretne Okno",
                    Director = "David Koepp",
                    Description = "Uznany pisarz przenosi się na prowincję, by w spokoju tworzyć kolejne książki. Wkrótce odwiedzi go tajemniczy mężczyzna, który oskarży Raineya o plagiat.",
                    Price = 12,
                    DataDodania = new DateTime(2020, 5, 4),
                    Plakat = "sekretne-okno.jpg"
                },
                new Movie()
                {
                    MovieId = 4,
                    CategoryId = 5,
                    Title = "Władca Pierścieni: Drużyna Pierścienia",
                    Director = "Peter Jackson",
                    Description = "Podróż hobbita z Shire i jego ośmiu towarzyszy, której celem jest zniszczenie potężnego pierścienia pożądanego przez Czarnego Władcę - Saurona.",
                    Price = 20,
                    DataDodania = new DateTime(2020, 5, 4),
                    Plakat = "wladca-pierscieni-druzyna-pierscienia.jpg"
                },
                new Movie()
                {
                    MovieId = 5,
                    CategoryId = 4,
                    Title = "Red",
                    Director = "Robert Schwentke",
                    Description = "Emerytowani agenci specjalni CIA zostają wrobieni w zamach. By się ratować, muszą reaktywować stary zespół.",
                    Price = 11,
                    DataDodania = new DateTime(2020, 5, 4),
                    Plakat = "red.jpg"
                },
                new Movie()
                {
                    MovieId = 6,
                    CategoryId = 2,
                    Title = "Tylko nie mów nikomu",
                    Director = "Tomasz Sekielski",
                    Description = "Dziennikarz śledczy rozmawia z dziewięcioma księżmi katolickimi, którzy dopuścili się zbrodni pedofilii i molestowania nieletnich, a także ich ofiarami.",
                    Price = 0,
                    DataDodania = new DateTime(2021, 4, 4),
                    Plakat = "tylko-nie-mow-nikomu.jpg"
                },
                new Movie()
                {
                    MovieId = 7,
                    CategoryId = 5,
                    Title = "Iluzjonista",
                    Director = "Neil Burger",
                    Description = "Wiedeń u progu XX w. Syn rzemieślnika, iluzjonista Eisenheim, wykorzystuje niezwykłe umiejętności, by zdobyć miłość arystokratki, narzeczonej austro-węgierskiego księcia.",
                    Price = 13,
                    DataDodania = new DateTime(2020, 5, 4),
                    Plakat = "iluzjonista.jpg"
                },
                new Movie()
                {
                    MovieId = 8,
                    CategoryId = 3,
                    Title = "Cube",
                    Director = "Vincenzo Natali",
                    Description = "Grupa osób budzi się w pełnym śmiertelnych pułapek sześcianie. Nieznajomi muszą zacząć współpracować ze sobą, by przeżyć.",
                    Price = 15,
                    DataDodania = new DateTime(2021, 2, 1),
                    Plakat = "cube.jpg"
                },
                new Movie()
                {
                    MovieId = 9,
                    CategoryId = 1,
                    Title = "Hellraiser: Wysłannik Piekieł",
                    Director = "Clive Barker",
                    Description = "Frank Cotton nabywa tajemniczą kostkę, za pomocą której można przywołać demony z piekła.",
                    Price = 16,
                    DataDodania = new DateTime(2020, 6, 21),
                    Plakat = "hellriser.jpg"
                },
                new Movie()
                {
                    MovieId = 10,
                    CategoryId = 3,
                    Title = "Milczenie Owiec",
                    Director = "Jonathan Demme",
                    Description = "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary.",
                    Price = 17,
                    DataDodania = new DateTime(2020, 10, 10),
                    Plakat = "milczenie-owiec.jpg"
                }
                );
        }
    }
}
