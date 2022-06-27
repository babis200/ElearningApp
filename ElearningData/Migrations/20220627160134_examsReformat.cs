using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElearningData.Migrations
{
    public partial class examsReformat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Courses_CourseModelId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subjects_SubjectModelId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_CourseModelId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_SubjectModelId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "CourseModelId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "SubjectModelId",
                table: "Exams");

            migrationBuilder.AddColumn<Guid>(
                name: "ExamId",
                table: "Subjects",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExamId",
                table: "Courses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ExamId",
                table: "Subjects",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ExamId",
                table: "Courses",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Exams_ExamId",
                table: "Courses",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Exams_ExamId",
                table: "Subjects",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Exams_ExamId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Exams_ExamId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_ExamId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ExamId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "Courses");

            migrationBuilder.AddColumn<Guid>(
                name: "CourseModelId",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SubjectModelId",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CourseModelId",
                table: "Exams",
                column: "CourseModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SubjectModelId",
                table: "Exams",
                column: "SubjectModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Courses_CourseModelId",
                table: "Exams",
                column: "CourseModelId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subjects_SubjectModelId",
                table: "Exams",
                column: "SubjectModelId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }
    }
}
