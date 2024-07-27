﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaLab.DAO.DB;

#nullable disable

namespace SistemaLab.Migrations
{
    [DbContext(typeof(LabContext))]
    [Migration("20240727154751_v4")]
    partial class v4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("SistemaLab.Model.CategoriaReagente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nomeCategoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("CategoriaReagentes");
                });

            modelBuilder.Entity("SistemaLab.Model.CategoriaResiduo", b =>
                {
                    b.Property<int>("idCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idCategoria");

                    b.ToTable("CategoriaResiduos");
                });

            modelBuilder.Entity("SistemaLab.Model.Equipamento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nomeEquipamento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("statusEquipamento")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Equipamentos");
                });

            modelBuilder.Entity("SistemaLab.Model.Reagente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoriaReagenteid")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dataVencimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("fabricante")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("lote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("CategoriaReagenteid");

                    b.ToTable("Reagentes");
                });

            modelBuilder.Entity("SistemaLab.Model.ReservaEquipamento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EquipamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("EquipamentoId");

                    b.ToTable("ReservaEquipamentos");
                });

            modelBuilder.Entity("SistemaLab.Model.Residuo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("categoriaResiduoidCategoria")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dataGeracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("statusResiduo")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("categoriaResiduoidCategoria");

                    b.ToTable("Residuos");
                });

            modelBuilder.Entity("SistemaLab.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("SistemaLab.Model.Aluno", b =>
                {
                    b.HasBaseType("SistemaLab.Model.Usuario");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Alunos", (string)null);
                });

            modelBuilder.Entity("SistemaLab.Model.Tecnico", b =>
                {
                    b.HasBaseType("SistemaLab.Model.Usuario");

                    b.Property<string>("registroProfissional")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Tecnicos", (string)null);
                });

            modelBuilder.Entity("SistemaLab.Model.Reagente", b =>
                {
                    b.HasOne("SistemaLab.Model.CategoriaReagente", null)
                        .WithMany("reagentes")
                        .HasForeignKey("CategoriaReagenteid");
                });

            modelBuilder.Entity("SistemaLab.Model.ReservaEquipamento", b =>
                {
                    b.HasOne("SistemaLab.Model.Aluno", "reservista")
                        .WithMany("Reservas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaLab.Model.Equipamento", "equipamento")
                        .WithMany("reservaEquipamentos")
                        .HasForeignKey("EquipamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("equipamento");

                    b.Navigation("reservista");
                });

            modelBuilder.Entity("SistemaLab.Model.Residuo", b =>
                {
                    b.HasOne("SistemaLab.Model.CategoriaResiduo", "categoriaResiduo")
                        .WithMany("residuos")
                        .HasForeignKey("categoriaResiduoidCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoriaResiduo");
                });

            modelBuilder.Entity("SistemaLab.Model.Aluno", b =>
                {
                    b.HasOne("SistemaLab.Model.Usuario", null)
                        .WithOne()
                        .HasForeignKey("SistemaLab.Model.Aluno", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaLab.Model.Tecnico", b =>
                {
                    b.HasOne("SistemaLab.Model.Usuario", null)
                        .WithOne()
                        .HasForeignKey("SistemaLab.Model.Tecnico", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaLab.Model.CategoriaReagente", b =>
                {
                    b.Navigation("reagentes");
                });

            modelBuilder.Entity("SistemaLab.Model.CategoriaResiduo", b =>
                {
                    b.Navigation("residuos");
                });

            modelBuilder.Entity("SistemaLab.Model.Equipamento", b =>
                {
                    b.Navigation("reservaEquipamentos");
                });

            modelBuilder.Entity("SistemaLab.Model.Aluno", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}