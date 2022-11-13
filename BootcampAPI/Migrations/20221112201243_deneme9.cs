using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcampAPI.Migrations
{
    public partial class deneme9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUri",
                table: "Products");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProductPicture",
                table: "Products",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductPicture",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "PictureUri",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
