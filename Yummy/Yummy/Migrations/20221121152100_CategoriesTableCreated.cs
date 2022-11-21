using Microsoft.EntityFrameworkCore.Migrations;

namespace Yummy.Migrations
{
    public partial class CategoriesTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Meals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meals_CategoriesId",
                table: "Meals",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Categories_CategoriesId",
                table: "Meals",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Categories_CategoriesId",
                table: "Meals");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Meals_CategoriesId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Meals");
        }
    }
}
