using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen2daUnidad.Data.Migrations
{
    public partial class iniciooooo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskLists_TaskListTackListId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TaskListTackListId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TackList",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TaskListTackListId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "TaskLists");

            migrationBuilder.AlterColumn<int>(
                name: "TackListId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TackListId",
                table: "Tasks",
                column: "TackListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskLists_TackListId",
                table: "Tasks",
                column: "TackListId",
                principalTable: "TaskLists",
                principalColumn: "TackListId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskLists_TackListId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TackListId",
                table: "Tasks");

            migrationBuilder.AlterColumn<string>(
                name: "TackListId",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "TackList",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaskListTackListId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "TaskLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskListTackListId",
                table: "Tasks",
                column: "TaskListTackListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskLists_TaskListTackListId",
                table: "Tasks",
                column: "TaskListTackListId",
                principalTable: "TaskLists",
                principalColumn: "TackListId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
