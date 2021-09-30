using Microsoft.EntityFrameworkCore.Migrations;

namespace ReceptaBot.Server.Migrations
{
    public partial class addedAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Amount",
                table: "Ingrediant",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Ingrediant");
        }
    }
}
