using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CAC_Management.Migrations
{
    public partial class result : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Teacher",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Guardian",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Marks = table.Column<int>(nullable: false),
                    Performance = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.StudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Teacher",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Guardian",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
