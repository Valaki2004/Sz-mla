using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Számla.Migrations
{
    public partial class teszt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class1",
                columns: table => new
                {
                    nev = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    kor = table.Column<int>(type: "int", nullable: false),
                    varos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    munka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bevetel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class1", x => x.nev);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class1");
        }
    }
}
