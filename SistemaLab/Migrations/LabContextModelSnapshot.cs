﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaLab.DAO.DB;

#nullable disable

namespace SistemaLab.Migrations
{
    [DbContext(typeof(LabContext))]
    partial class LabContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("CategoriaReagenteId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_categoria");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_usuario");

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

                    b.HasIndex("CategoriaReagenteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Reagentes");
                });

            modelBuilder.Entity("SistemaLab.Model.ReservaEquipamento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_aluno");

                    b.Property<int>("EquipamentoId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_equipamento");

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

                    b.Property<int>("CategoriaResiduoId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_categoria");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_usuario");

                    b.Property<DateTime>("dataGeracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("statusResiduo")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("CategoriaResiduoId");

                    b.HasIndex("UsuarioId");

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
                    b.HasOne("SistemaLab.Model.CategoriaReagente", "categoriaReagente")
                        .WithMany("reagentes")
                        .HasForeignKey("CategoriaReagenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaLab.Model.Usuario", "Usuario")
                        .WithMany("Reagentes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");

                    b.Navigation("categoriaReagente");
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
                        .HasForeignKey("CategoriaResiduoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaLab.Model.Usuario", "usuario")
                        .WithMany("Residuos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoriaResiduo");

                    b.Navigation("usuario");
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

            modelBuilder.Entity("SistemaLab.Model.Usuario", b =>
                {
                    b.Navigation("Reagentes");

                    b.Navigation("Residuos");
                });

            modelBuilder.Entity("SistemaLab.Model.Aluno", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
