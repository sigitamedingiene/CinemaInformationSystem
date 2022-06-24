using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaInformationSystemRepository.Migrations
{
    public partial class UpdateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Clients_ClientId1",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ClientId1",
                table: "Movies",
                newName: "AuditoriumId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ClientId1",
                table: "Movies",
                newName: "IX_Movies_AuditoriumId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ClientId",
                table: "Movies",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_MovieId",
                table: "Clients",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Movies_MovieId",
                table: "Clients",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Auditoriums_AuditoriumId",
                table: "Movies",
                column: "AuditoriumId",
                principalTable: "Auditoriums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Clients_ClientId",
                table: "Movies",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Movies_MovieId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Auditoriums_AuditoriumId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Clients_ClientId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ClientId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Clients_MovieId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "AuditoriumId",
                table: "Movies",
                newName: "ClientId1");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_AuditoriumId",
                table: "Movies",
                newName: "IX_Movies_ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Clients_ClientId1",
                table: "Movies",
                column: "ClientId1",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
