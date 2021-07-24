using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen2daUnidad.Data.Migrations
{
    public partial class modfModeloss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskLists_TackListId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskLists");

            migrationBuilder.RenameColumn(
                name: "TackListId",
                table: "Tasks",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_TackListId",
                table: "Tasks",
                newName: "IX_Tasks_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Categories_CategoryId",
                table: "Tasks",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Categories_CategoryId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Tasks",
                newName: "TackListId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_CategoryId",
                table: "Tasks",
                newName: "IX_Tasks_TackListId");

            migrationBuilder.CreateTable(
                name: "TaskLists",
                columns: table => new
                {
                    TackListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskLists", x => x.TackListId);
                    table.ForeignKey(
                        name: "FK_TaskLists_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskLists_CategoryId",
                table: "TaskLists",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskLists_TackListId",
                table: "Tasks",
                column: "TackListId",
                principalTable: "TaskLists",
                principalColumn: "TackListId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
