using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleModels.Migrations
{
    public partial class AddContragents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contragents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LicenseID = table.Column<string>(nullable: false),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Code = table.Column<string>(maxLength: 15, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    IsFolder = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsPredefined = table.Column<bool>(nullable: false, defaultValue: false),
                    ParentID = table.Column<Guid>(nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contragents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contragents_Contragents_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Contragents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contragents_Code",
                table: "Contragents",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Contragents_IsDeleted",
                table: "Contragents",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Contragents_IsFolder",
                table: "Contragents",
                column: "IsFolder");

            migrationBuilder.CreateIndex(
                name: "IX_Contragents_IsPredefined",
                table: "Contragents",
                column: "IsPredefined");

            migrationBuilder.CreateIndex(
                name: "IX_Contragents_LicenseID",
                table: "Contragents",
                column: "LicenseID");

            migrationBuilder.CreateIndex(
                name: "IX_Contragents_Name",
                table: "Contragents",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Contragents_ParentID",
                table: "Contragents",
                column: "ParentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contragents");
        }
    }
}
