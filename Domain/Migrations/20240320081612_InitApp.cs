using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Sku = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    DiscountPrice = table.Column<double>(type: "float", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(255)", nullable: true),
                    ImageList = table.Column<string>(type: "varchar(255)", nullable: true),
                    ViewCount = table.Column<int>(type: "int", nullable: true),
                    SeoAlias = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    SeoKeyword = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    SeoDescription = table.Column<string>(type: "varchar(255)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    RateTotal = table.Column<int>(type: "int", nullable: true),
                    RateCount = table.Column<int>(type: "int", nullable: true),
                    ObjId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
