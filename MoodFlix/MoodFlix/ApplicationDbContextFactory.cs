using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MoodFlix
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Proporciona aquí tu cadena de conexión explícitamente
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=MoodFlixDB;User=sa;Password=Passw0rd!;TrustServerCertificate=true;MultipleActiveResultSets =true");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
