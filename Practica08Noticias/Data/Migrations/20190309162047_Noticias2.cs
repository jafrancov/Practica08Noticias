using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica08Noticias.Data.Migrations
{
    public partial class Noticias2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Noticias_Categorias_CategoriaID1",
                table: "Noticias");

            migrationBuilder.DropIndex(
                name: "IX_Noticias_CategoriaID1",
                table: "Noticias");

            migrationBuilder.DropColumn(
                name: "CategoriaID1",
                table: "Noticias");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaID",
                table: "Noticias",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Noticias_CategoriaID",
                table: "Noticias",
                column: "CategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Noticias_Categorias_CategoriaID",
                table: "Noticias",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "CategoriaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Noticias_Categorias_CategoriaID",
                table: "Noticias");

            migrationBuilder.DropIndex(
                name: "IX_Noticias_CategoriaID",
                table: "Noticias");

            migrationBuilder.DropColumn(
                name: "CategoriaID",
                table: "Noticias");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaID1",
                table: "Noticias",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Noticias_CategoriaID1",
                table: "Noticias",
                column: "CategoriaID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Noticias_Categorias_CategoriaID1",
                table: "Noticias",
                column: "CategoriaID1",
                principalTable: "Categorias",
                principalColumn: "CategoriaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
