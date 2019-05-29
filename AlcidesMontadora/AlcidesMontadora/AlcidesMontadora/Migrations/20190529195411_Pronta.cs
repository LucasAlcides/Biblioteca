using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlcidesMontadora.Migrations
{
    public partial class Pronta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peca_Pessoa_FornecedorId",
                table: "Peca");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Cidade_CidadeId",
                table: "Pessoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Pessoa_ClienteId",
                table: "Veiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Pessoa_MontadorId",
                table: "Veiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_CidadeId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "CidadeId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "OrgaoExpedidor",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Rg",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Fornecedor_Endereco",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Montador");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salario",
                table: "Montador",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Montador",
                table: "Montador",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    OrgaoExpedidor = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    CidadeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "CidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CidadeId",
                table: "Cliente",
                column: "CidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peca_Fornecedor_FornecedorId",
                table: "Peca",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Cliente_ClienteId",
                table: "Veiculo",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Montador_MontadorId",
                table: "Veiculo",
                column: "MontadorId",
                principalTable: "Montador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peca_Fornecedor_FornecedorId",
                table: "Peca");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Cliente_ClienteId",
                table: "Veiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Montador_MontadorId",
                table: "Veiculo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Montador",
                table: "Montador");

            migrationBuilder.RenameTable(
                name: "Montador",
                newName: "Pessoa");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salario",
                table: "Pessoa",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<int>(
                name: "CidadeId",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrgaoExpedidor",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rg",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fornecedor_Endereco",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Pessoa",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_CidadeId",
                table: "Pessoa",
                column: "CidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peca_Pessoa_FornecedorId",
                table: "Peca",
                column: "FornecedorId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Cidade_CidadeId",
                table: "Pessoa",
                column: "CidadeId",
                principalTable: "Cidade",
                principalColumn: "CidadeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Pessoa_ClienteId",
                table: "Veiculo",
                column: "ClienteId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Pessoa_MontadorId",
                table: "Veiculo",
                column: "MontadorId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
