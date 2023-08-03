using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adm1.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Dongvat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dongvat",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    ChungLoai = table.Column<string>(type: "TEXT", nullable: false),
                    XuatXu = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dongvat", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dongvat");
        }
    }
}
