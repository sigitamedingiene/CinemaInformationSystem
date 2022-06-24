using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaInformationSystemRepository.Migrations
{
    public partial class InitialsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Movies_MovieId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_MovieId",
                table: "Clients");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "Movies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "Movies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ClientId1",
                table: "Movies",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Clients_ClientId1",
                table: "Movies",
                column: "ClientId1",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Clients_ClientId1",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ClientId1",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "Movies");

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
    }
}
