using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.Bookstore.Migrations
{
    public partial class Added_AuthorId_To_Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "AppBook",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AppBook_AuthorId",
                table: "AppBook",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppBook_AppAuthors_AuthorId",
                table: "AppBook",
                column: "AuthorId",
                principalTable: "AppAuthors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppBook_AppAuthors_AuthorId",
                table: "AppBook");

            migrationBuilder.DropIndex(
                name: "IX_AppBook_AuthorId",
                table: "AppBook");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "AppBook");
        }
    }
}
