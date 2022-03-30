using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFWebApi.Migrations
{
    public partial class AccuracyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Accuracy",
                table: "WeatherForecasts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accuracy",
                table: "WeatherForecasts");
        }
    }
}
