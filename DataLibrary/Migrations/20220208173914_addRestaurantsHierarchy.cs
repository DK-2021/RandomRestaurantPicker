using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class addRestaurantsHierarchy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conveniences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conveniences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuisines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuisines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CuisineId = table.Column<int>(type: "int", nullable: false),
                    ConvenienceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_Conveniences_ConvenienceId",
                        column: x => x.ConvenienceId,
                        principalTable: "Conveniences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restaurants_Cuisines_CuisineId",
                        column: x => x.CuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Conveniences",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Sit Down" },
                    { 2, "Take Out" },
                    { 3, "Fast Food" }
                });

            migrationBuilder.InsertData(
                table: "Cuisines",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Italian" },
                    { 2, "American" },
                    { 3, "Mexican" },
                    { 4, "Korean" },
                    { 5, "Chinese" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "ConvenienceId", "CuisineId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, 1, "Olive Garden", 2 },
                    { 2, 3, 3, "Taco Bell", 1 },
                    { 3, 1, 2, "Ruth's Chriss", 3 },
                    { 4, 2, 2, "Cookout", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_ConvenienceId",
                table: "Restaurants",
                column: "ConvenienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_CuisineId",
                table: "Restaurants",
                column: "CuisineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Conveniences");

            migrationBuilder.DropTable(
                name: "Cuisines");
        }
    }
}
