using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaInformationSystemRepository.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MovieId",
                table: "Clients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Movies_MovieId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_MovieId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Clients");
        }
    }
}
