﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Migrations
{
    [DbContext(typeof(VideolocadoraContext))]
    [Migration("20201015161438_Start")]
    partial class Start
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrunoTragl.Inovation.Videolocadora.Domain.Model.Aluguel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Devolucao")
                        .HasColumnType("datetime2");

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<decimal>("Multa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.HasIndex("FilmeId")
                        .IsUnique();

                    b.HasIndex("FuncionarioId")
                        .IsUnique();

                    b.ToTable("aluguel");
                });

            modelBuilder.Entity("BrunoTragl.Inovation.Videolocadora.Domain.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(300)");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(300)");

                    b.Property<string>("Telefone")
                        .HasColumnType("VARCHAR(15)");

                    b.HasKey("Id");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("BrunoTragl.Inovation.Videolocadora.Domain.Model.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(1000)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(300)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("filme");
                });

            modelBuilder.Entity("BrunoTragl.Inovation.Videolocadora.Domain.Model.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Cadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(300)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(300)");

                    b.HasKey("Id");

                    b.ToTable("funcionario");
                });

            modelBuilder.Entity("BrunoTragl.Inovation.Videolocadora.Domain.Model.Aluguel", b =>
                {
                    b.HasOne("BrunoTragl.Inovation.Videolocadora.Domain.Model.Cliente", "Cliente")
                        .WithOne("Aluguel")
                        .HasForeignKey("BrunoTragl.Inovation.Videolocadora.Domain.Model.Aluguel", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BrunoTragl.Inovation.Videolocadora.Domain.Model.Filme", "Filme")
                        .WithOne("Aluguel")
                        .HasForeignKey("BrunoTragl.Inovation.Videolocadora.Domain.Model.Aluguel", "FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BrunoTragl.Inovation.Videolocadora.Domain.Model.Funcionario", "Funcionario")
                        .WithOne("Aluguel")
                        .HasForeignKey("BrunoTragl.Inovation.Videolocadora.Domain.Model.Aluguel", "FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
