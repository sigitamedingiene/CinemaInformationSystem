using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaInformationSystemRepository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditoriumId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditoriumId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Auditoriums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceCount = table.Column<int>(type: "int", nullable: false),
                    RowsCount = table.Column<int>(type: "int", nullable: false),
                    RowSeatCount = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoriums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auditoriums_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auditoriums_MovieId",
                table: "Auditoriums",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AuditoriumId",
                table: "Clients",
                column: "AuditoriumId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_AuditoriumId",
                table: "Movies",
                column: "AuditoriumId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ClientId",
                table: "Movies",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Auditoriums_AuditoriumId",
                table: "Clients",
                column: "AuditoriumId",
                principalTable: "Auditoriums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Auditoriums_AuditoriumId",
                table: "Movies",
                column: "AuditoriumId",
                principalTable: "Auditoriums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auditoriums_Movies_MovieId",
                table: "Auditoriums");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Auditoriums");
        }
    }
}
