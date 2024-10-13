using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CP2.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrationUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_fornecedores",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    CNPJ = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_fornecedores", x => x.Nome);
                });

            migrationBuilder.CreateTable(
                name: "tb_vendedores",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DataContratacao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ComissaoPercentual = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    MetaMensal = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_vendedores", x => x.Nome);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_fornecedores");

            migrationBuilder.DropTable(
                name: "tb_vendedores");
        }
    }
}
