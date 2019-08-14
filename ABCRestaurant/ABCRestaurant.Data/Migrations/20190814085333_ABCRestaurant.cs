using Microsoft.EntityFrameworkCore.Migrations;

namespace ABCRestaurant.Data.Migrations
{
    public partial class ABCRestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Menus_MenuItemId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_ProfileUserId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ProfileUserId",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "MenuItemId",
                table: "Orders",
                newName: "MenuId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ProfileUserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_MenuItemId",
                table: "Orders",
                newName: "IX_Orders_MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Menus_MenuId",
                table: "Orders",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Menus_MenuId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "ProfileUserId");

            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "Orders",
                newName: "MenuItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                newName: "IX_Orders_ProfileUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_MenuId",
                table: "Orders",
                newName: "IX_Orders_MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Menus_MenuItemId",
                table: "Orders",
                column: "MenuItemId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_ProfileUserId",
                table: "Orders",
                column: "ProfileUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
