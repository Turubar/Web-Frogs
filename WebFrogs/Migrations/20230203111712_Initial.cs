using Microsoft.EntityFrameworkCore.Migrations;

namespace WebFrogs.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frogs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    shortDesc = table.Column<string>(nullable: false),
                    fullDesc = table.Column<string>(nullable: false),
                    mainImg = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frogs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Toads",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    shortDesc = table.Column<string>(nullable: false),
                    fullDesc = table.Column<string>(nullable: false),
                    mainImg = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toads", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frogs");

            migrationBuilder.DropTable(
                name: "Toads");
        }
    }
}
