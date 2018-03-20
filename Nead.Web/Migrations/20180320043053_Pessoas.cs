using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Nead.Web.Migrations
{
    public partial class Pessoas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    Uf = table.Column<string>(maxLength: 2, nullable: true),
                    UsuarioAlteracao = table.Column<string>(maxLength: 14, nullable: true),
                    UsuarioCriacao = table.Column<string>(maxLength: 14, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Celular = table.Column<string>(maxLength: 30, nullable: false),
                    Cpf = table.Column<string>(maxLength: 14, nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Foto = table.Column<byte[]>(nullable: true),
                    MunicipioId = table.Column<long>(nullable: true),
                    Nome = table.Column<string>(maxLength: 256, nullable: false),
                    Perfil = table.Column<string>(maxLength: 100, nullable: true),
                    UsuarioAlteracao = table.Column<string>(maxLength: 14, nullable: true),
                    UsuarioCriacao = table.Column<string>(maxLength: 14, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_MunicipioId",
                table: "Pessoas",
                column: "MunicipioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Municipios");
        }
    }
}
