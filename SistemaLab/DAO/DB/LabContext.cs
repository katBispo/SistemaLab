using Microsoft.EntityFrameworkCore;
using SistemaLab.Model;

namespace SistemaLab.DAO.DB
{
    public class LabContext : DbContext
    {
        public LabContext(DbContextOptions<LabContext> options) : base(options)
        {
            SQLitePCL.Batteries.Init();
        }

        public DbSet<Reagente> Reagentes { get; set; }
        public DbSet<CategoriaReagente> CategoriaReagentes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Residuo> Residuos { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<ReservaEquipamento> ReservaEquipamentos { get; set; }
        public DbSet<CategoriaResiduo> CategoriaResiduos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=lab.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                    .HasDiscriminator<string>("UserType")
                    .HasValue<Usuario>("Usuario")
                    .HasValue<Aluno>("Aluno")
                    .HasValue<Tecnico>("Tecnico");




            modelBuilder.Entity<ReservaEquipamento>()
                .HasOne(r => r.Reservista)
                .WithMany(a => a.Reservas)
                .HasForeignKey(r => r.AlunoId);

            modelBuilder.Entity<ReservaEquipamento>()
                .HasOne(r => r.Equipamento)
                .WithMany()
                .HasForeignKey(r => r.EquipamentoId);

            modelBuilder.Entity<Equipamento>().HasMany(e => e.reservaEquipamentos).WithOne(r => r.Equipamento);

        }
    }
}
