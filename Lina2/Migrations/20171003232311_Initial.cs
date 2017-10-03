using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lina2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Method = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Season = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    SubscriberId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Birthday = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Zip = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.SubscriberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Subscribers");
        }
    }
}
