using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.ChatABP.Migrations
{
    public partial class initial_message_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppBooks",
                table: "AppBooks");

            migrationBuilder.RenameTable(
                name: "AppBooks",
                newName: "AppMessages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppMessages",
                table: "AppMessages",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppMessages",
                table: "AppMessages");

            migrationBuilder.RenameTable(
                name: "AppMessages",
                newName: "AppBooks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppBooks",
                table: "AppBooks",
                column: "Id");
        }
    }
}
