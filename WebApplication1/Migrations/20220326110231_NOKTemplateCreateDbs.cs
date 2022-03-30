using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class NOKTemplateCreateDbs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NOKTemplateCreateDb",
                table: "NOKTemplateCreateDb");

            migrationBuilder.RenameTable(
                name: "NOKTemplateCreateDb",
                newName: "NOKTemplateCreateDbs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NOKTemplateCreateDbs",
                table: "NOKTemplateCreateDbs",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NOKTemplateCreateDbs",
                table: "NOKTemplateCreateDbs");

            migrationBuilder.RenameTable(
                name: "NOKTemplateCreateDbs",
                newName: "NOKTemplateCreateDb");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NOKTemplateCreateDb",
                table: "NOKTemplateCreateDb",
                column: "Id");
        }
    }
}
