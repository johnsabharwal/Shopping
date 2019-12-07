using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class propertchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductRating_Product_ProductId",
                table: "ProductRating");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductRating_Users_userId",
                table: "ProductRating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductRating",
                table: "ProductRating");

            migrationBuilder.RenameTable(
                name: "ProductRating",
                newName: "ProductRatings");

            migrationBuilder.RenameIndex(
                name: "IX_ProductRating_userId",
                table: "ProductRatings",
                newName: "IX_ProductRatings_userId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductRating_ProductId",
                table: "ProductRatings",
                newName: "IX_ProductRatings_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductRatings",
                table: "ProductRatings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRatings_Product_ProductId",
                table: "ProductRatings",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRatings_Users_userId",
                table: "ProductRatings",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductRatings_Product_ProductId",
                table: "ProductRatings");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductRatings_Users_userId",
                table: "ProductRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductRatings",
                table: "ProductRatings");

            migrationBuilder.RenameTable(
                name: "ProductRatings",
                newName: "ProductRating");

            migrationBuilder.RenameIndex(
                name: "IX_ProductRatings_userId",
                table: "ProductRating",
                newName: "IX_ProductRating_userId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductRatings_ProductId",
                table: "ProductRating",
                newName: "IX_ProductRating_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductRating",
                table: "ProductRating",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRating_Product_ProductId",
                table: "ProductRating",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRating_Users_userId",
                table: "ProductRating",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
