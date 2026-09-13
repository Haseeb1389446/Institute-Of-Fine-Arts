using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Institute_Of_Fine_Arts.Migrations
{
    /// <inheritdoc />
    public partial class init124 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_Competitions_CompetitionId1",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_CompetitionId1",
                table: "Paintings");

            migrationBuilder.DropColumn(
                name: "CompetitionId1",
                table: "Paintings");

            migrationBuilder.AlterColumn<int>(
                name: "CompetitionId",
                table: "Paintings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_CompetitionId",
                table: "Paintings",
                column: "CompetitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_Competitions_CompetitionId",
                table: "Paintings",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_Competitions_CompetitionId",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_CompetitionId",
                table: "Paintings");

            migrationBuilder.AlterColumn<string>(
                name: "CompetitionId",
                table: "Paintings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompetitionId1",
                table: "Paintings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_CompetitionId1",
                table: "Paintings",
                column: "CompetitionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_Competitions_CompetitionId1",
                table: "Paintings",
                column: "CompetitionId1",
                principalTable: "Competitions",
                principalColumn: "Id");
        }
    }
}
