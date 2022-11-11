using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcampAPI.Migrations
{
    public partial class deneme4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeaturedProductId",
                table: "FeaturedProducts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FeaturedProducts",
                table: "FeaturedProducts",
                column: "FeaturedProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FeaturedProducts",
                table: "FeaturedProducts");

            migrationBuilder.DropColumn(
                name: "FeaturedProductId",
                table: "FeaturedProducts");
        }
    }
}
