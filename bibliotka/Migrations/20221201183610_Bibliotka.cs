using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bibliotka.Migrations
{
    /// <inheritdoc />
    public partial class Bibliotka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Knigas",
                columns: table => new
                {
                    KnigaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pisatel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stranici = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knigas", x => x.KnigaID);
                });

            migrationBuilder.CreateTable(
                name: "KnigiMqstos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KnigaId = table.Column<int>(type: "int", nullable: false),
                    OtdelPisatel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Red = table.Column<int>(type: "int", nullable: false),
                    Nomer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnigiMqstos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KnigaKnigiMqsto",
                columns: table => new
                {
                    KnigiRaftoveId = table.Column<int>(type: "int", nullable: false),
                    knigiKnigaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnigaKnigiMqsto", x => new { x.KnigiRaftoveId, x.knigiKnigaID });
                    table.ForeignKey(
                        name: "FK_KnigaKnigiMqsto_Knigas_knigiKnigaID",
                        column: x => x.knigiKnigaID,
                        principalTable: "Knigas",
                        principalColumn: "KnigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnigaKnigiMqsto_KnigiMqstos_KnigiRaftoveId",
                        column: x => x.KnigiRaftoveId,
                        principalTable: "KnigiMqstos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KnigaKnigiMqsto_knigiKnigaID",
                table: "KnigaKnigiMqsto",
                column: "knigiKnigaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KnigaKnigiMqsto");

            migrationBuilder.DropTable(
                name: "Knigas");

            migrationBuilder.DropTable(
                name: "KnigiMqstos");
        }
    }
}
