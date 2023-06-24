using Microsoft.EntityFrameworkCore.Migrations;

namespace Emlak.App.Migrations
{
    public partial class InıtDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblEv",
                columns: table => new
                {
                    EvId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Semt = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    OdaSayi = table.Column<int>(type: "int", nullable: false),
                    MetreKare = table.Column<float>(type: "real", nullable: false),
                    Fiyat = table.Column<float>(type: "real", nullable: false),
                    Depozito = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEv", x => x.EvId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEv");
        }
    }
}
