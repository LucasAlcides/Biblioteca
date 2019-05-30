﻿// <auto-generated />
using System;
using AlcidesMontadora.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlcidesMontadora.Migrations
{
    [DbContext(typeof(MontadoraContexto))]
    [Migration("20190529195411_Pronta")]
    partial class Pronta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlcidesMontadora.Models.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("CidadeId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("AlcidesMontadora.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CidadeId");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("OrgaoExpedidor");

                    b.Property<string>("Rg");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("AlcidesMontadora.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("AlcidesMontadora.Models.Montador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Salario");

                    b.HasKey("Id");

                    b.ToTable("Montador");
                });

            modelBuilder.Entity("AlcidesMontadora.Models.Peca", b =>
                {
                    b.Property<int>("PecaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFabricacao");

                    b.Property<string>("Descricao");

                    b.Property<int?>("FornecedorId");

                    b.Property<string>("NumeroSerie");

                    b.Property<decimal>("Valor");

                    b.HasKey("PecaId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Peca");
                });

            modelBuilder.Entity("AlcidesMontadora.Models.PecaDoVeiculo", b =>
                {
                    b.Property<int>("PecaDoVeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Desconto");

                    b.Property<int?>("ObjVeiculoVeiculoId");

                    b.Property<int?>("PecaId");

                    b.Property<int>("Quantidade");

                    b.HasKey("PecaDoVeiculoId");

                    b.HasIndex("ObjVeiculoVeiculoId");

                    b.HasIndex("PecaId");

                    b.ToTable("PecaDoVeiculo");
                });

            modelBuilder.Entity("AlcidesMontadora.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AlcidesMontadora.Models.Veiculo", b =>
                {
                    b.Property<int>("VeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria");

                    b.Property<int?>("ClienteId");

                    b.Property<string>("Marca");

                    b.Property<string>("Modelo");

                    b.Property<int?>("MontadorId");

                    b.HasKey("VeiculoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MontadorId");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("AlcidesMontadora.Models.Cliente", b =>
                {
                    b.HasOne("AlcidesMontadora.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId");
                });

            modelBuilder.Entity("AlcidesMontadora.Models.Peca", b =>
                {
                    b.HasOne("AlcidesMontadora.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");
                });

            modelBuilder.Entity("AlcidesMontadora.Models.PecaDoVeiculo", b =>
                {
                    b.HasOne("AlcidesMontadora.Models.Veiculo", "ObjVeiculo")
                        .WithMany("ListaPecaDoVeiculo")
                        .HasForeignKey("ObjVeiculoVeiculoId");

                    b.HasOne("AlcidesMontadora.Models.Peca", "Peca")
                        .WithMany()
                        .HasForeignKey("PecaId");
                });

            modelBuilder.Entity("AlcidesMontadora.Models.Veiculo", b =>
                {
                    b.HasOne("AlcidesMontadora.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("AlcidesMontadora.Models.Montador", "Montador")
                        .WithMany()
                        .HasForeignKey("MontadorId");
                });
#pragma warning restore 612, 618
        }
    }
}