using Microsoft.EntityFrameworkCore.Migrations;

namespace JsonToPdf.Model.Migrations
{
    public partial class _01082021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocumentType",
                table: "BaseDocumentsEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "BaseDocumentsEntity");
        }
    }
}
