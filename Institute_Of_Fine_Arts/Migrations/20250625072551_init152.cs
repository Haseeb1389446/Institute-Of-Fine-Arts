using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Institute_Of_Fine_Arts.Migrations
{
    /// <inheritdoc />
    public partial class init152 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Competitions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Competitions");
        }
    }
}
