using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleModels.Migrations
{
    public partial class AddGoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LicenseID = table.Column<string>(nullable: false),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Code = table.Column<string>(maxLength: 15, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    IsFolder = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    IsPredefined = table.Column<bool>(nullable: false, defaultValue: false),
                    ParentID = table.Column<Guid>(nullable: false),
                    GoodsType = table.Column<int>(nullable: false, defaultValue: 0),
                    UnitOfSale = table.Column<int>(nullable: false, defaultValue: 1),
                    UnitOfStore = table.Column<int>(nullable: false, defaultValue: 1),
                    UnitOfConsist = table.Column<int>(nullable: false, defaultValue: 1),
                    QuantityOnConsist = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goods_Goods_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Goods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RcordOfGoodConsist",
                columns: table => new
                {
                    GoodID = table.Column<Guid>(nullable: false),
                    Id = table.Column<byte>(nullable: false),
                    Unit = table.Column<int>(nullable: false, defaultValue: 1),
                    Brutto = table.Column<int>(nullable: false, defaultValue: 0),
                    Netto = table.Column<int>(nullable: false, defaultValue: 0),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RcordOfGoodConsist", x => new { x.Id, x.GoodID });
                    table.ForeignKey(
                        name: "FK_RcordOfGoodConsist_Goods_GoodID",
                        column: x => x.GoodID,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Goods_Code",
                table: "Goods",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_IsDeleted",
                table: "Goods",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_IsFolder",
                table: "Goods",
                column: "IsFolder");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_IsPredefined",
                table: "Goods",
                column: "IsPredefined");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_LicenseID",
                table: "Goods",
                column: "LicenseID");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_Name",
                table: "Goods",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_ParentID",
                table: "Goods",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_RcordOfGoodConsist_GoodID",
                table: "RcordOfGoodConsist",
                column: "GoodID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RcordOfGoodConsist");

            migrationBuilder.DropTable(
                name: "Goods");
        }
    }
}
