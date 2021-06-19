using Microsoft.EntityFrameworkCore.Migrations;

namespace Hosted_Blazor_WASM_Identity.Server.Data.Migrations
{
    public partial class RemoveAddedRoleField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);
        }
    }
}
