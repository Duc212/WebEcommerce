using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class create_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Soluong = table.Column<int>(type: "int", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HDCTs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idsp = table.Column<int>(type: "int", nullable: true),
                    Idhd = table.Column<int>(type: "int", nullable: true),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Soluong = table.Column<int>(type: "int", nullable: true),
                    Trangthai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDCTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HDCTs_HoaDons_Idhd",
                        column: x => x.Idhd,
                        principalTable: "HoaDons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HDCTs_SanPhams_Idsp",
                        column: x => x.Idsp,
                        principalTable: "SanPhams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HDCTs_Idhd",
                table: "HDCTs",
                column: "Idhd");

            migrationBuilder.CreateIndex(
                name: "IX_HDCTs_Idsp",
                table: "HDCTs",
                column: "Idsp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HDCTs");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "SanPhams");
        }
    }
}
