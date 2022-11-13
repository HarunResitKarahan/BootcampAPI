using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcampAPI.Migrations
{
    public partial class deneme8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeaturedProducts_Products_ProductId",
                table: "FeaturedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategorys_Categorys_CategoryId",
                table: "SubCategorys");

            migrationBuilder.DropIndex(
                name: "IX_SubCategorys_CategoryId",
                table: "SubCategorys");

            migrationBuilder.DropIndex(
                name: "IX_FeaturedProducts_ProductId",
                table: "FeaturedProducts");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserLoginName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserLoginName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorys_CategoryId",
                table: "SubCategorys",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FeaturedProducts_ProductId",
                table: "FeaturedProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeaturedProducts_Products_ProductId",
                table: "FeaturedProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategorys_Categorys_CategoryId",
                table: "SubCategorys",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
