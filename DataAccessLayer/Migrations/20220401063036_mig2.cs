using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Students",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Staffs",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Members",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Students",
                newName: "PersonID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Staffs",
                newName: "PersonID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Members",
                newName: "PersonID");
        }
    }
}
