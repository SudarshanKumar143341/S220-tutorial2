using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCWebAppHWelloWorld.Migrations
{
    public partial class addedPublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublisherTitle",
                table: "Books_DB",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisherTitle",
                table: "Books_DB");
        }
    }
}
