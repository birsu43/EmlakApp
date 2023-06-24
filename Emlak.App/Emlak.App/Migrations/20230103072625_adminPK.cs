using Microsoft.EntityFrameworkCore.Migrations;

namespace Emlak.App.Migrations
{
    public partial class adminPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAdmin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sifre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    KullaniciAd = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAdmin", x => x.AdminId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblAdmin_KullaniciAd",
                table: "tblAdmin",
                column: "KullaniciAd",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAdmin");
        }
    }
}
