using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Institute_Of_Fine_Arts.Migrations
{
    /// <inheritdoc />
    public partial class init125 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Competitions_AwardId",
                table: "Competitions");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Paintings",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Remarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaintingId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Creativity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Remarks_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Remarks_Paintings_PaintingId",
                        column: x => x.PaintingId,
                        principalTable: "Paintings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_StudentId",
                table: "Paintings",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_AwardId",
                table: "Competitions",
                column: "AwardId",
                unique: true,
                filter: "[AwardId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_AuthorId",
                table: "Remarks",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_PaintingId",
                table: "Remarks",
                column: "PaintingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_AspNetUsers_StudentId",
                table: "Paintings",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_AspNetUsers_StudentId",
                table: "Paintings");

            migrationBuilder.DropTable(
                name: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_StudentId",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Competitions_AwardId",
                table: "Competitions");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Paintings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_AwardId",
                table: "Competitions",
                column: "AwardId");
        }
    }
}
