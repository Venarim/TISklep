using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TISklep.Migrations
{
    public partial class Add_Movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CategoryId", "Description", "Director", "Price", "ProductionDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "20 sierpnia 1973 roku teksańska policja trafiła do stojącego na uboczu domu Thomasa Hewitta - byłego pracownika lokalnej rzeźni. Na miejscu odkryli rozkładające się zwłoki 33 osób, które zostały zamordowane przez psychopatycznego zabójcę noszącego na twarzy maskę z ludzkiej skóry i posługującego się piłą mechaniczną.", "Marcus Nispel", 10m, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teksańska Masakra Piłą Mechaniczną" },
                    { 2, 3, "Mężczyzna dostaje obsesji na punkcie książki, która według niego Descriptionuje i przewiduje jego życie i przyszłość.", "Joel Schumacher", 14m, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numer 23" },
                    { 3, 3, "Uznany pisarz przenosi się na prowincję, by w spokoju tworzyć kolejne książki. Wkrótce odwiedzi go tajemniczy mężczyzna, który oskarży Raineya o plagiat.", "David Koepp", 12m, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sekretne Okno" },
                    { 4, 5, "Podróż hobbita z Shire i jego ośmiu towarzyszy, której celem jest zniszczenie potężnego pierścienia pożądanego przez Czarnego Władcę - Saurona.", "Peter Jackson", 20m, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Władca Pierścieni: Drużyna Pierścienia" },
                    { 5, 4, "Emerytowani agenci specjalni CIA zostają wrobieni w zamach. By się ratować, muszą reaktywować stary zespół.", "Robert Schwentke", 11m, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red" },
                    { 6, 2, "Dziennikarz śledczy rozmawia z dziewięcioma księżmi katolickimi, którzy dopuścili się zbrodni pedofilii i molestowania nieletnich, a także ich ofiarami.", "Tomasz Sekielski", 0m, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tylko nie mów nikomu" },
                    { 7, 5, "Wiedeń u progu XX w. Syn rzemieślnika, iluzjonista Eisenheim, wykorzystuje niezwykłe umiejętności, by zdobyć miłość arystokratki, narzeczonej austro-węgierskiego księcia.", "Neil Burger", 13m, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iluzjonista" },
                    { 8, 3, "Grupa osób budzi się w pełnym śmiertelnych pułapek sześcianie. Nieznajomi muszą zacząć współpracować ze sobą, by przeżyć.", "Vincenzo Natali", 15m, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cube" },
                    { 9, 1, "Frank Cotton nabywa tajemniczą kostkę, za pomocą której można przywołać demony z piekła.", "Clive Barker", 16m, new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hellraiser: Wysłannik Piekieł" },
                    { 10, 3, "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary.", "Jonathan Demme", 17m, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milczenie Owiec" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10);
        }
    }
}
