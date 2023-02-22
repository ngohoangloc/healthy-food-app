using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asp_dotnet_core_api_healthy_food.Migrations
{
    public partial class AddPrivilegesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "privileges",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_privileges", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    rolesid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    usersid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.rolesid, x.usersid });
                    table.ForeignKey(
                        name: "FK_RoleUser_roles_rolesid",
                        column: x => x.rolesid,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_users_usersid",
                        column: x => x.usersid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrivilegesRole",
                columns: table => new
                {
                    privilegesid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    rolesid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivilegesRole", x => new { x.privilegesid, x.rolesid });
                    table.ForeignKey(
                        name: "FK_PrivilegesRole_privileges_privilegesid",
                        column: x => x.privilegesid,
                        principalTable: "privileges",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrivilegesRole_roles_rolesid",
                        column: x => x.rolesid,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegesRole_rolesid",
                table: "PrivilegesRole",
                column: "rolesid");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_usersid",
                table: "RoleUser",
                column: "usersid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrivilegesRole");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "privileges");
        }
    }
}
