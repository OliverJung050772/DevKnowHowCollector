using Microsoft.EntityFrameworkCore.Migrations;

namespace DevCollApi.Migrations
{
    public partial class UpdatedTopic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CollId",
                table: "Topics",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollId",
                table: "Topics");
        }
    }
}
