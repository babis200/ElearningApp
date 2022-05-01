using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElearningData.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Teachers = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FreeFormQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Question = table.Column<string>(type: "TEXT", nullable: true),
                    Answer = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreeFormQs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Question = table.Column<string>(type: "TEXT", nullable: true),
                    Choices = table.Column<string>(type: "TEXT", nullable: true),
                    Answers = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchQs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MultipleChoiceQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Question = table.Column<string>(type: "TEXT", nullable: true),
                    Choices = table.Column<string>(type: "TEXT", nullable: true),
                    Answer = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultipleChoiceQs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrueFalseQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Question = table.Column<string>(type: "TEXT", nullable: false),
                    Answer = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrueFalseQs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Resources = table.Column<string>(type: "TEXT", nullable: true),
                    CourseModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Courses_CourseModelId",
                        column: x => x.CourseModelId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Grades = table.Column<string>(type: "TEXT", nullable: true),
                    CourseModelId = table.Column<int>(type: "INTEGER", nullable: true),
                    SubjectModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_Courses_CourseModelId",
                        column: x => x.CourseModelId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exams_Subjects_SubjectModelId",
                        column: x => x.SubjectModelId,
                        principalTable: "Subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QType = table.Column<int>(type: "INTEGER", nullable: false),
                    FreeFormId = table.Column<int>(type: "INTEGER", nullable: true),
                    MatchId = table.Column<int>(type: "INTEGER", nullable: true),
                    MultipleChoiceId = table.Column<int>(type: "INTEGER", nullable: true),
                    TrueFalseId = table.Column<int>(type: "INTEGER", nullable: true),
                    ExamModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Exams_ExamModelId",
                        column: x => x.ExamModelId,
                        principalTable: "Exams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Question_FreeFormQs_FreeFormId",
                        column: x => x.FreeFormId,
                        principalTable: "FreeFormQs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Question_MatchQs_MatchId",
                        column: x => x.MatchId,
                        principalTable: "MatchQs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Question_MultipleChoiceQs_MultipleChoiceId",
                        column: x => x.MultipleChoiceId,
                        principalTable: "MultipleChoiceQs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Question_TrueFalseQs_TrueFalseId",
                        column: x => x.TrueFalseId,
                        principalTable: "TrueFalseQs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CourseModelId",
                table: "Exams",
                column: "CourseModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SubjectModelId",
                table: "Exams",
                column: "SubjectModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_ExamModelId",
                table: "Question",
                column: "ExamModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_FreeFormId",
                table: "Question",
                column: "FreeFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_MatchId",
                table: "Question",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_MultipleChoiceId",
                table: "Question",
                column: "MultipleChoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_TrueFalseId",
                table: "Question",
                column: "TrueFalseId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CourseModelId",
                table: "Subjects",
                column: "CourseModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "FreeFormQs");

            migrationBuilder.DropTable(
                name: "MatchQs");

            migrationBuilder.DropTable(
                name: "MultipleChoiceQs");

            migrationBuilder.DropTable(
                name: "TrueFalseQs");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
