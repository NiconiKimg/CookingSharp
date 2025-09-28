using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingSharp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRelationToAppeal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Appeals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appeals_UserId",
                table: "Appeals",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appeals_Users_UserId",
                table: "Appeals",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appeals_Users_UserId",
                table: "Appeals");

            migrationBuilder.DropIndex(
                name: "IX_Appeals_UserId",
                table: "Appeals");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Appeals");
        }
    }
}
