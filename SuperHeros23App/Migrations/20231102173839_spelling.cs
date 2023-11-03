using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeros23App.Migrations
{
    /// <inheritdoc />
    public partial class spelling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SecondaryAbility",
                table: "SuperHeros23",
                newName: "SecondaryAbility");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SecondaryAbility",
                table: "SuperHeros23",
                newName: "SecondaryAbility");
        }
    }
}
