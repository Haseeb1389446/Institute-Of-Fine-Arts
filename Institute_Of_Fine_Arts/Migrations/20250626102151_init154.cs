using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Institute_Of_Fine_Arts.Migrations
{
    /// <inheritdoc />
    public partial class init154 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Conditions",
                table: "Competitions",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Competitions",
                newName: "Conditions");
        }
    }
}
