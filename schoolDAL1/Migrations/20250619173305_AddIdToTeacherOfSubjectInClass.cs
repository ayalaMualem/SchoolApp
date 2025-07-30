using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace schoolDAL.Migrations
{
    /// <inheritdoc />
    public partial class AddIdToTeacherOfSubjectInClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeroomTeacherOfClass",
                columns: table => new
                {
                    IdTeacher = table.Column<int>(type: "INT", nullable: true),
                    Class = table.Column<string>(type: "VARCHAR(10)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    HomePhone = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    BirthdayYear = table.Column<int>(type: "INT", nullable: true),
                    Class = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    Address = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false),
                    SubjectName = table.Column<string>(type: "VARCHAR(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeacherOfSubjectInClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    IdTeacher = table.Column<int>(type: "INT", nullable: true),
                    IdSubject = table.Column<int>(type: "INT", nullable: true),
                    Class = table.Column<string>(type: "VARCHAR(10)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    LastName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Phone = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    MailAddress = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeroomTeacherOfClass");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "TeacherOfSubjectInClass");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
