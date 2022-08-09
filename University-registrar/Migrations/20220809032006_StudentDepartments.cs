using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityRegistrar.Migrations
{
    public partial class StudentDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Courses_CourseId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Students_StudentId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentCourse_Courses_CourseId",
                table: "DepartmentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentCourse_Departments_DepartmentId",
                table: "DepartmentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentCourse",
                table: "DepartmentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseStudent",
                table: "CourseStudent");

            migrationBuilder.RenameTable(
                name: "DepartmentCourse",
                newName: "DepartmentCourses");

            migrationBuilder.RenameTable(
                name: "CourseStudent",
                newName: "CourseStudents");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentCourse_DepartmentId",
                table: "DepartmentCourses",
                newName: "IX_DepartmentCourses_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentCourse_CourseId",
                table: "DepartmentCourses",
                newName: "IX_DepartmentCourses_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudent_StudentId",
                table: "CourseStudents",
                newName: "IX_CourseStudents_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudent_CourseId",
                table: "CourseStudents",
                newName: "IX_CourseStudents_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses",
                column: "DepartmentCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseStudents",
                table: "CourseStudents",
                column: "CourseStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudents_Courses_CourseId",
                table: "CourseStudents",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudents_Students_StudentId",
                table: "CourseStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentCourses_Courses_CourseId",
                table: "DepartmentCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentCourses_Departments_DepartmentId",
                table: "DepartmentCourses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudents_Courses_CourseId",
                table: "CourseStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudents_Students_StudentId",
                table: "CourseStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentCourses_Courses_CourseId",
                table: "DepartmentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentCourses_Departments_DepartmentId",
                table: "DepartmentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseStudents",
                table: "CourseStudents");

            migrationBuilder.RenameTable(
                name: "DepartmentCourses",
                newName: "DepartmentCourse");

            migrationBuilder.RenameTable(
                name: "CourseStudents",
                newName: "CourseStudent");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentCourses_DepartmentId",
                table: "DepartmentCourse",
                newName: "IX_DepartmentCourse_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentCourses_CourseId",
                table: "DepartmentCourse",
                newName: "IX_DepartmentCourse_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudents_StudentId",
                table: "CourseStudent",
                newName: "IX_CourseStudent_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudents_CourseId",
                table: "CourseStudent",
                newName: "IX_CourseStudent_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentCourse",
                table: "DepartmentCourse",
                column: "DepartmentCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseStudent",
                table: "CourseStudent",
                column: "CourseStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Courses_CourseId",
                table: "CourseStudent",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Students_StudentId",
                table: "CourseStudent",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentCourse_Courses_CourseId",
                table: "DepartmentCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentCourse_Departments_DepartmentId",
                table: "DepartmentCourse",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
