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
            //optionsBuilder.UseSqlServer("Server=testfundacion.mysql.database.azure.com,3306;Database=MoodFlixDB;User=carlos;Password=$nqbAgY1Kzsyk0$Z;SslMode=Required;TrustServerCertificate=true;");
            optionsBuilder.UseMySql(
                "Server=testfundacion.mysql.database.azure.com;Port=3306;Database=MoodFlixDB;User=carlos;;SslMode=Required;",
                new MySqlServerVersion(new Version(8, 0, 39))
            );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
