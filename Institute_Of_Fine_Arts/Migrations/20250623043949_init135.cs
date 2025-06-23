using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Institute_Of_Fine_Arts.Migrations
{
    /// <inheritdoc />
    public partial class init135 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_Competitions_CompetitionId",
                table: "Awards");

            migrationBuilder.DropIndex(
                name: "IX_Awards_CompetitionId",
                table: "Awards");

            migrationBuilder.DropColumn(
                name: "CompetitionId",
                table: "Awards");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Awards");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Awards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Awards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompetitionId",
                table: "Awards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Awards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Awards_CompetitionId",
                table: "Awards",
                column: "CompetitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_Competitions_CompetitionId",
                table: "Awards",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
