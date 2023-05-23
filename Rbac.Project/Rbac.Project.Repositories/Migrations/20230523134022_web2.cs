using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rbac.Project.Repositories.Migrations
{
    public partial class web2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeleteName",
                table: "UserTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "UserTable",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserTable",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeleteName",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Role",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DeleteName",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "Menu",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Menu",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteName",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "DeleteName",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DeleteName",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Menu");
        }
    }
}
