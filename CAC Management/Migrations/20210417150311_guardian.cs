using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CAC_Management.Migrations
{
    public partial class guardian : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Guardian",
                columns: table => new
                {
                    GuardianId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GuardianName = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guardian", x => x.GuardianId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Contact = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "student_routine",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    day = table.Column<string>(nullable: false),
                    time = table.Column<string>(nullable: false),
                    sub = table.Column<string>(nullable: false),
                    instructor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student_routine", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeacherName = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Guardian");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "student_routine");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
