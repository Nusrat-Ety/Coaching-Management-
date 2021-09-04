using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CAC_Management.Migrations
{
    public partial class AddGuardianTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Result",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Result");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Result",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Result",
                table: "Result",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Result",
                table: "Result");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Result",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Result",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Result",
                table: "Result",
                column: "Id");
        }
    }
}
