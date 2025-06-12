using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRGorman.Demo.SpeedrunData.Migrations
{
    /// <inheritdoc />
    public partial class ActNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActNumber",
                table: "Acts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActNumber",
                table: "Acts");
        }
    }
}
