using Microsoft.EntityFrameworkCore.Migrations;

namespace TISklep.Migrations
{
    public partial class dodanieplakatu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Plakat",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "Plakat",
                value: "teksanska-masakra-pila-mechaniczna.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "Plakat",
                value: "numer-23.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "Plakat",
                value: "sekretne-okno.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                column: "Plakat",
                value: "wladca-pierscieni-druzyna-pierscienia.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                column: "Plakat",
                value: "red.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                column: "Plakat",
                value: "tylko-nie-mow-nikomu.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7,
                column: "Plakat",
                value: "iluzjonista.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8,
                column: "Plakat",
                value: "cube.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 9,
                column: "Plakat",
                value: "hellriser.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 10,
                column: "Plakat",
                value: "milczenie-owiec.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plakat",
                table: "Movies");
        }
    }
}
