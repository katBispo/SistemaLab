using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SQLitePCL;

namespace SistemaLab.DAO.DB
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<LabContext>
    {
        public LabContext CreateDbContext(string[] args)
        {
            Batteries.Init(); 

            var optionsBuilder = new DbContextOptionsBuilder<LabContext>();
            optionsBuilder.UseSqlite("Data Source=labQuimica.db");

            return new LabContext(optionsBuilder.Options);
        }
    }
}
