using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JsonToPdf.Model.Migrations
{
    public partial class _31072021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseDocumentsEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "VARCHAR(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseDocumentsEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActsOfReconciliation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActName = table.Column<string>(type: "VARCHAR(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActsOfReconciliation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActsOfReconciliation_BaseDocumentsEntity_Id",
                        column: x => x.Id,
                        principalTable: "BaseDocumentsEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsignmentsNotes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProdictId = table.Column<decimal>(type: "decimal(32,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsignmentsNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsignmentsNotes_BaseDocumentsEntity_Id",
                        column: x => x.Id,
                        principalTable: "BaseDocumentsEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfContract = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_BaseDocumentsEntity_Id",
                        column: x => x.Id,
                        principalTable: "BaseDocumentsEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneratedPdfs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PdfName = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    PdfStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneratedPdfs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneratedPdfs_BaseDocumentsEntity_Id",
                        column: x => x.Id,
                        principalTable: "BaseDocumentsEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActsOfReconciliation");

            migrationBuilder.DropTable(
                name: "ConsignmentsNotes");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "GeneratedPdfs");

            migrationBuilder.DropTable(
                name: "BaseDocumentsEntity");
        }
    }
}
