using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleModels.Migrations
{
    public partial class AddStoreges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Storeges",
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
                    ParentID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storeges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storeges_Storeges_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Storeges",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Storeges_Code",
                table: "Storeges",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Storeges_IsDeleted",
                table: "Storeges",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Storeges_IsFolder",
                table: "Storeges",
                column: "IsFolder");

            migrationBuilder.CreateIndex(
                name: "IX_Storeges_IsPredefined",
                table: "Storeges",
                column: "IsPredefined");

            migrationBuilder.CreateIndex(
                name: "IX_Storeges_LicenseID",
                table: "Storeges",
                column: "LicenseID");

            migrationBuilder.CreateIndex(
                name: "IX_Storeges_Name",
                table: "Storeges",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Storeges_ParentID",
                table: "Storeges",
                column: "ParentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Storeges");
        }
    }
}
