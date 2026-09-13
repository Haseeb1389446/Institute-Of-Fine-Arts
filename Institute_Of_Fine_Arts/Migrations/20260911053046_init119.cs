using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Institute_Of_Fine_Arts.Migrations
{
    /// <inheritdoc />
    public partial class init119 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
