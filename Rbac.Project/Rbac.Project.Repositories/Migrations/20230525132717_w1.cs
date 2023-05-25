using Microsoft.EntityFrameworkCore.Migrations;

namespace Rbac.Project.Repositories.Migrations
{
    public partial class w1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "U_Avatar",
                table: "UserTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "U_Remark",
                table: "UserTable",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "U_Avatar",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "U_Remark",
                table: "UserTable");
        }
    }
}
