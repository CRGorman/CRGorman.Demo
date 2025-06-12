using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRGorman.Demo.SpeedrunData.Migrations
{
    /// <inheritdoc />
    public partial class VanityURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VanityURL",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VanityURL",
                table: "Games");
        }
    }
}
