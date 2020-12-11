using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnASP.Migrations
{
    public partial class khoitao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    IDTK = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    HinhAnh = table.Column<string>(nullable: true),
                    Quyen = table.Column<int>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.IDTK);
                });

            migrationBuilder.CreateTable(
                name: "Loais",
                columns: table => new
                {
                    IDLoai = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    IDNguoiTao = table.Column<int>(nullable: false),
                    IDTK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loais", x => x.IDLoai);
                    table.ForeignKey(
                        name: "FK_Loais_TaiKhoans_IDTK",
                        column: x => x.IDTK,
                        principalTable: "TaiKhoans",
                        principalColumn: "IDTK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    IDBlog = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(nullable: true),
                    HinhAnh = table.Column<string>(nullable: true),
                    TomTat = table.Column<string>(nullable: true),
                    NoiDung = table.Column<string>(nullable: true),
                    IDLoai = table.Column<int>(nullable: false),
                    IDNguoiTao = table.Column<int>(nullable: false),
                    IDTK = table.Column<int>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NgayDuyet = table.Column<DateTime>(nullable: false),
                    View = table.Column<int>(nullable: false),
                    IDNguoiDuyet = table.Column<int>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.IDBlog);
                    table.ForeignKey(
                        name: "FK_Blogs_Loais_IDLoai",
                        column: x => x.IDLoai,
                        principalTable: "Loais",
                        principalColumn: "IDLoai",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_TaiKhoans_IDTK",
                        column: x => x.IDTK,
                        principalTable: "TaiKhoans",
                        principalColumn: "IDTK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CauHois",
                columns: table => new
                {
                    IDBlog = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(nullable: true),
                    HinhAnh = table.Column<string>(nullable: true),
                    TomTat = table.Column<string>(nullable: true),
                    NoiDung = table.Column<string>(nullable: true),
                    IDLoai = table.Column<int>(nullable: false),
                    IDNguoiTao = table.Column<int>(nullable: false),
                    IDTK = table.Column<int>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NgayDuyet = table.Column<DateTime>(nullable: false),
                    View = table.Column<int>(nullable: false),
                    IDNguoiDuyet = table.Column<int>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauHois", x => x.IDBlog);
                    table.ForeignKey(
                        name: "FK_CauHois_Loais_IDLoai",
                        column: x => x.IDLoai,
                        principalTable: "Loais",
                        principalColumn: "IDLoai",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CauHois_TaiKhoans_IDTK",
                        column: x => x.IDTK,
                        principalTable: "TaiKhoans",
                        principalColumn: "IDTK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BinhLuans",
                columns: table => new
                {
                    IDBL = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTK = table.Column<int>(nullable: false),
                    IDBV = table.Column<int>(nullable: false),
                    IDBlog = table.Column<int>(nullable: true),
                    IDCH = table.Column<int>(nullable: false),
                    IDCauHoi = table.Column<int>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinhLuans", x => x.IDBL);
                    table.ForeignKey(
                        name: "FK_BinhLuans_Blogs_IDBlog",
                        column: x => x.IDBlog,
                        principalTable: "Blogs",
                        principalColumn: "IDBlog",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BinhLuans_CauHois_IDCauHoi",
                        column: x => x.IDCauHoi,
                        principalTable: "CauHois",
                        principalColumn: "IDBlog",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BinhLuans_TaiKhoans_IDTK",
                        column: x => x.IDTK,
                        principalTable: "TaiKhoans",
                        principalColumn: "IDTK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuans_IDBlog",
                table: "BinhLuans",
                column: "IDBlog");

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuans_IDCauHoi",
                table: "BinhLuans",
                column: "IDCauHoi");

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuans_IDTK",
                table: "BinhLuans",
                column: "IDTK");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_IDLoai",
                table: "Blogs",
                column: "IDLoai");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_IDTK",
                table: "Blogs",
                column: "IDTK");

            migrationBuilder.CreateIndex(
                name: "IX_CauHois_IDLoai",
                table: "CauHois",
                column: "IDLoai");

            migrationBuilder.CreateIndex(
                name: "IX_CauHois_IDTK",
                table: "CauHois",
                column: "IDTK");

            migrationBuilder.CreateIndex(
                name: "IX_Loais_IDTK",
                table: "Loais",
                column: "IDTK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BinhLuans");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "CauHois");

            migrationBuilder.DropTable(
                name: "Loais");

            migrationBuilder.DropTable(
                name: "TaiKhoans");
        }
    }
}
