using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CP2.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrationDois : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_vendedores",
                table: "tb_vendedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_fornecedores",
                table: "tb_fornecedores");

            migrationBuilder.AlterColumn<decimal>(
                name: "MetaMensal",
                table: "tb_vendedores",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ComissaoPercentual",
                table: "tb_vendedores",
                type: "DECIMAL(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "tb_vendedores",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "tb_vendedores",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "tb_fornecedores",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "tb_fornecedores",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0)
                .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_vendedores",
                table: "tb_vendedores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_fornecedores",
                table: "tb_fornecedores",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_vendedores",
                table: "tb_vendedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_fornecedores",
                table: "tb_fornecedores");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "tb_vendedores");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "tb_fornecedores");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "tb_vendedores",
                type: "NVARCHAR2(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MetaMensal",
                table: "tb_vendedores",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ComissaoPercentual",
                table: "tb_vendedores",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "tb_fornecedores",
                type: "NVARCHAR2(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_vendedores",
                table: "tb_vendedores",
                column: "Nome");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_fornecedores",
                table: "tb_fornecedores",
                column: "Nome");
        }
    }
}
