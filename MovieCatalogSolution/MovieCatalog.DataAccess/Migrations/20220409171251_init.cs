using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCatalog.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Age = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FavoriteGenre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    RoleType = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    GenreType = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genre_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoviePerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoviePerson_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviePerson_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "Biography", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 29, "asdasdasda", "Jon", "Doe" },
                    { 2, 29, "asdasdasda", "Jane", "Doe" },
                    { 3, 29, "asdasdasda", "Yo", "What up" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "FavoriteGenre", "FirstName", "LastName", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "Street 01", 2, "Pero", "Blazevski", null, "Pero123" },
                    { 2, "Street 02", 2, "Blazo", "Ristovski", null, "Blazo123" },
                    { 4, "Street 04", 1, "User4", "4ski", null, "4-123" },
                    { 5, "Street 05", 4, "User5", "5ski", null, "1235" },
                    { 3, "Street 03", 3, "Risto", "Petkovski", null, "Risto123" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ReleaseDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "A man with short-term memory loss attempts to track down his wife's murderer.", new DateTime(2001, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Memento", 1 },
                    { 2, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", new DateTime(1994, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction", 2 },
                    { 3, "After being kidnapped and imprisoned for fifteen years, Oh Dae-Su is released, only to find that he must find his captor in five days.", new DateTime(2003, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oldboy", 3 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "PersonId", "RoleType" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 1, 1 },
                    { 2, 2, 2 },
                    { 4, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "GenreType", "MovieId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 3, 1, 1 },
                    { 2, 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "MoviePerson",
                columns: new[] { "Id", "MovieId", "PersonId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genre_MovieId",
                table: "Genre",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePerson_MovieId",
                table: "MoviePerson",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePerson_PersonId",
                table: "MoviePerson",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_UserId",
                table: "Movies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_PersonId",
                table: "Role",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "MoviePerson");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
