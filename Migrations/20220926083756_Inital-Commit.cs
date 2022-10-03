using Microsoft.EntityFrameworkCore.Migrations;

namespace RihalAssesment.Migrations
{
    public partial class InitalCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    class_name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    country_name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    country_id = table.Column<int>(type: "INTEGER", nullable: false),
                    class_id = table.Column<int>(type: "INTEGER", nullable: false),
                    date_of_birth = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "id", "class_name" },
                values: new object[] { 1, "First Standard" });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "id", "country_name" },
                values: new object[] { 101, "India" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "id", "class_id", "country_id", "date_of_birth", "name" },
                values: new object[] { 1001, 1, 1, "25-06-1991", "Anoob" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
