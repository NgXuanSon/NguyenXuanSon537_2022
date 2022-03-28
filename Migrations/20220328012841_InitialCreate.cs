using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenXuanSon2022537.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NXS537",
                columns: table => new
                {
                    NXSID = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NXSName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NXSGender = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NXS537", x => x.NXSID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NXS537");
        }
    }
}
