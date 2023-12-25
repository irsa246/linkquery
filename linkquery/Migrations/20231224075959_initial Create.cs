using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace linkquery.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    f_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dept_id = table.Column<int>(type: "int", maxLength: 25, nullable: false),
                    f_standing = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.f_id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    S_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Standing = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.S_id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    C_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Romm_num = table.Column<int>(type: "int", nullable: false),
                    f_id = table.Column<int>(type: "int", nullable: false),
                    Facultyf_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.C_id);
                    table.ForeignKey(
                        name: "FK_Classes_Faculty_Facultyf_id",
                        column: x => x.Facultyf_id,
                        principalTable: "Faculty",
                        principalColumn: "f_id");
                });

            migrationBuilder.CreateTable(
                name: "Enrolled",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_id = table.Column<int>(type: "int", nullable: false),
                    C_id = table.Column<int>(type: "int", nullable: false),
                    ClassC_id = table.Column<int>(type: "int", nullable: true),
                    StudentS_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolled", x => x.id);
                    table.ForeignKey(
                        name: "FK_Enrolled_Classes_ClassC_id",
                        column: x => x.ClassC_id,
                        principalTable: "Classes",
                        principalColumn: "C_id");
                    table.ForeignKey(
                        name: "FK_Enrolled_Students_StudentS_id",
                        column: x => x.StudentS_id,
                        principalTable: "Students",
                        principalColumn: "S_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Facultyf_id",
                table: "Classes",
                column: "Facultyf_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolled_ClassC_id",
                table: "Enrolled",
                column: "ClassC_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolled_StudentS_id",
                table: "Enrolled",
                column: "StudentS_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Enrolled");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Faculty");
        }
    }
}
