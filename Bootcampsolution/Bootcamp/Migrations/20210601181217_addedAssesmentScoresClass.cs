using Microsoft.EntityFrameworkCore.Migrations;

namespace Bootcamp.Migrations
{
    public partial class addedAssesmentScoresClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssesmentScore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActualScore = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    AssesmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssesmentScore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssesmentScore_Assesments_AssesmentId",
                        column: x => x.AssesmentId,
                        principalTable: "Assesments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssesmentScore_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssesmentScore_AssesmentId",
                table: "AssesmentScore",
                column: "AssesmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssesmentScore_StudentId",
                table: "AssesmentScore",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssesmentScore");
        }
    }
}
