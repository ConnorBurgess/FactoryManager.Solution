using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class machineprops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Malfunctioning",
                table: "Machines",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Operational",
                table: "Machines",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Repaired",
                table: "Machines",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Malfunctioning",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "Operational",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "Repaired",
                table: "Machines");
        }
    }
}
