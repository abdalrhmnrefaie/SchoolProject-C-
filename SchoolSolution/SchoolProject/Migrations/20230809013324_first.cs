using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolProject.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    room_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    room_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.room_Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    student_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    student_Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.student_Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    teacher_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacher_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    teacher_Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.teacher_Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    course_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    course_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    teacher_Id = table.Column<int>(type: "int", nullable: false),
                    teacher_Id1 = table.Column<int>(type: "int", nullable: true),
                    course_Capicity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.course_Id);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_teacher_Id1",
                        column: x => x.teacher_Id1,
                        principalTable: "Teachers",
                        principalColumn: "teacher_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    studentCourse_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_Id = table.Column<int>(type: "int", nullable: false),
                    student_Id1 = table.Column<int>(type: "int", nullable: true),
                    course_Id = table.Column<int>(type: "int", nullable: false),
                    course_Id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => x.studentCourse_Id);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_course_Id1",
                        column: x => x.course_Id1,
                        principalTable: "Courses",
                        principalColumn: "course_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_student_Id1",
                        column: x => x.student_Id1,
                        principalTable: "Students",
                        principalColumn: "student_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_teacher_Id1",
                table: "Courses",
                column: "teacher_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_course_Id1",
                table: "StudentCourses",
                column: "course_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_student_Id1",
                table: "StudentCourses",
                column: "student_Id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
