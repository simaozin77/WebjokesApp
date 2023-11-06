using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebjokesApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class atualizarbd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "Jokes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Jokes");
        }
    }
}
