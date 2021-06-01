using Microsoft.EntityFrameworkCore.Migrations;

namespace Bootcamp.Migrations
{
    public partial class addedassesmentscores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssesmentScore_Assesments_AssesmentId",
                table: "AssesmentScore");

            migrationBuilder.DropForeignKey(
                name: "FK_AssesmentScore_Students_StudentId",
                table: "AssesmentScore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssesmentScore",
                table: "AssesmentScore");

            migrationBuilder.RenameTable(
                name: "AssesmentScore",
                newName: "AssesmentScores");

            migrationBuilder.RenameIndex(
                name: "IX_AssesmentScore_StudentId",
                table: "AssesmentScores",
                newName: "IX_AssesmentScores_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_AssesmentScore_AssesmentId",
                table: "AssesmentScores",
                newName: "IX_AssesmentScores_AssesmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssesmentScores",
                table: "AssesmentScores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssesmentScores_Assesments_AssesmentId",
                table: "AssesmentScores",
                column: "AssesmentId",
                principalTable: "Assesments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssesmentScores_Students_StudentId",
                table: "AssesmentScores",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssesmentScores_Assesments_AssesmentId",
                table: "AssesmentScores");

            migrationBuilder.DropForeignKey(
                name: "FK_AssesmentScores_Students_StudentId",
                table: "AssesmentScores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssesmentScores",
                table: "AssesmentScores");

            migrationBuilder.RenameTable(
                name: "AssesmentScores",
                newName: "AssesmentScore");

            migrationBuilder.RenameIndex(
                name: "IX_AssesmentScores_StudentId",
                table: "AssesmentScore",
                newName: "IX_AssesmentScore_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_AssesmentScores_AssesmentId",
                table: "AssesmentScore",
                newName: "IX_AssesmentScore_AssesmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssesmentScore",
                table: "AssesmentScore",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssesmentScore_Assesments_AssesmentId",
                table: "AssesmentScore",
                column: "AssesmentId",
                principalTable: "Assesments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssesmentScore_Students_StudentId",
                table: "AssesmentScore",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
