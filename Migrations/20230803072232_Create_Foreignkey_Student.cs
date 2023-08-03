using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adm1.Migrations
{
    /// <inheritdoc />
    public partial class Create_Foreignkey_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FaID",
                table: "Student",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Student_FaID",
                table: "Student",
                column: "FaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Faculty_FaID",
                table: "Student",
                column: "FaID",
                principalTable: "Faculty",
                principalColumn: "FaID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Faculty_FaID",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_FaID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "FaID",
                table: "Student");
        }
    }
}
