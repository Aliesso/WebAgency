using Microsoft.EntityFrameworkCore.Migrations;

namespace K102AgencyWeb.Migrations
{
    public partial class DescriptionInTestimonial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Testimonials",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Testimonials");
        }
    }
}
