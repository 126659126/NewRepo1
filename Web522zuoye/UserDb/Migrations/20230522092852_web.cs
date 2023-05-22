using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserDb.Migrations
{
    public partial class web : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModulerodeTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Module_Id = table.Column<int>(type: "int", nullable: false),
                    Rode_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulerodeTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModuleTable",
                columns: table => new
                {
                    Module_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Module_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent_code = table.Column<int>(type: "int", nullable: false),
                    Module_level = table.Column<int>(type: "int", nullable: false),
                    AddName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChangeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangeTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleTable", x => x.Module_Id);
                });

            migrationBuilder.CreateTable(
                name: "RodeUserTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Rode_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RodeUserTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role_db",
                columns: table => new
                {
                    Rode_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rode_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rode_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChangeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangeTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role_db", x => x.Rode_id);
                });

            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_pwd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_full_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChangeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangeTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTable", x => x.User_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModulerodeTable");

            migrationBuilder.DropTable(
                name: "ModuleTable");

            migrationBuilder.DropTable(
                name: "RodeUserTable");

            migrationBuilder.DropTable(
                name: "Role_db");

            migrationBuilder.DropTable(
                name: "UserTable");
        }
    }
}
