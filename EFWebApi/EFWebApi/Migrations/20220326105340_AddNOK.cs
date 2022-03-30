using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFWebApi.Migrations
{
    public partial class AddNOK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casters");

            migrationBuilder.CreateTable(
                name: "NOKs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number1 = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Number2 = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Result = table.Column<decimal>(type: "decimal(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOKs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NOKs");

            migrationBuilder.CreateTable(
                name: "Casters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casters", x => x.Id);
                });
        }
    }
}
