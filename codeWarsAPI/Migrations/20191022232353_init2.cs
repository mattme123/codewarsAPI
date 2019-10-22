using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace codeWarsAPI.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Katas");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Katas",
                newName: "ProposedDate");

            migrationBuilder.AlterColumn<string>(
                name: "KataName",
                table: "Katas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "Katas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Katas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Katas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "KataLink",
                table: "Katas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Katas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
                table: "Katas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cohorts",
                columns: table => new
                {
                    CohortId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cohorts", x => x.CohortId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CohortFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Cohorts_CohortFK",
                        column: x => x.CohortFK,
                        principalTable: "Cohorts",
                        principalColumn: "CohortId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Katas_StudentId",
                table: "Katas",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Katas_StudentId1",
                table: "Katas",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CohortFK",
                table: "Students",
                column: "CohortFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Katas_Students_StudentId",
                table: "Katas",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Katas_Students_StudentId1",
                table: "Katas",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Katas_Students_StudentId",
                table: "Katas");

            migrationBuilder.DropForeignKey(
                name: "FK_Katas_Students_StudentId1",
                table: "Katas");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Cohorts");

            migrationBuilder.DropIndex(
                name: "IX_Katas_StudentId",
                table: "Katas");

            migrationBuilder.DropIndex(
                name: "IX_Katas_StudentId1",
                table: "Katas");

            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "Katas");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Katas");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Katas");

            migrationBuilder.DropColumn(
                name: "KataLink",
                table: "Katas");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Katas");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "Katas");

            migrationBuilder.RenameColumn(
                name: "ProposedDate",
                table: "Katas",
                newName: "Created");

            migrationBuilder.AlterColumn<string>(
                name: "KataName",
                table: "Katas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Katas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }
    }
}
