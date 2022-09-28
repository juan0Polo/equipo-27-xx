using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyectos.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "formador",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vigente = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formador", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tutor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vigente = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tutor", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "formador");

            migrationBuilder.DropTable(
                name: "tutor");
        }
    }
}
