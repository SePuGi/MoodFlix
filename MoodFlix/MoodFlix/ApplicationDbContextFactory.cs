using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MoodFlix
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseMySql(
                Utilities.Utils.GetConnectionString(),
                new MySqlServerVersion(new Version(8, 0, 39))
            );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
