using Microsoft.EntityFrameworkCore.Migrations;

namespace NovelFinder.Data.Migrations
{
    public partial class AddedNumberOfRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "numberOfRatings",
                table: "Novels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numberOfRatings",
                table: "Novels");
        }
    }
}
