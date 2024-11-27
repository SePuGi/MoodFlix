using Microsoft.EntityFrameworkCore;
using MoodFlix.Model;

namespace MoodFlix
{
    public class ApplicationDbContext : DbContext
    {
        /*
         * Execute this command in the terminal to create the database:
         * 
         *       dotnet ef migrations add InitialCreate
         *       dotnet ef database update
         *       
         * Execute this command in the terminal to create the controllers
         * 
         *       dotnet aspnet-codegenerator controller -name UsersController -async -api -m User -dc ApplicationDbContext -outDir Controllers
         * 
         */

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Principal tables
        public DbSet<User> User { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Emotion> Emotion { get; set; }
        public DbSet<Platform> Platform { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Director> Director { get; set; }

        // Relational tables
        public DbSet<UserGenre> UserGenre { get; set; }
        public DbSet<UserPlatform> UserPlatform { get; set; }
        public DbSet<HistoryEmotion> HistoryEmotion { get; set; }
        public DbSet<Register> History { get; set; }
        public DbSet<GenreMovie> GenreMovie { get; set; }
        public DbSet<DirectorMovie> DirectorMovie { get; set; }
        public DbSet<CountryPlatform> CountryPlatform { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
             * ENUM TABLES
             */

            //This does not autoGenerate the Id
            modelBuilder.Entity<Country>()
                .Property(c => c.CountryId)
                .ValueGeneratedNever();
            //create a table named Country with the EnumCountry values
            modelBuilder.Entity<Country>().HasData(
            Enum.GetValues(typeof(EnumCountry))
                .Cast<EnumCountry>()
                .Select(e => new Country
                {
                    CountryId = (int)e,
                    CountryName = e.ToString()
                })
            );

            //This does not autoGenerate the Id
            modelBuilder.Entity<Genre>()
                .Property(g => g.GenreId)
                .ValueGeneratedNever();
            //create a table named Genre with the EnumGenre values
            modelBuilder.Entity<Genre>().HasData(
                Enum.GetValues(typeof(EnumGenre))
                .Cast<EnumGenre>()
                .Select(e => new Genre
                {
                    GenreId = (int)e,
                    GenreName = e.ToString()
                })
            );

            //This does not autoGenerate the Id
            modelBuilder.Entity<Emotion>()
                .Property(e => e.EmotionId)
                .ValueGeneratedNever();
            //create a table named Emotion with the EnumEmotion values
            modelBuilder.Entity<Emotion>().HasData(
                Enum.GetValues(typeof(EnumEmotion))
                .Cast<EnumEmotion>()
                .Select(e => new Emotion
                {
                    EmotionId = (int)e,
                    EmotionName = e.ToString()
                })
            );

            /*
             * RELATION TABLES
             */

            //UserGenre relation table
            modelBuilder.Entity<UserGenre>()
                .HasKey(ug => new { ug.UserId, ug.GenreId });

            //UserPlatform relation table
            modelBuilder.Entity<UserPlatform>()
                .HasKey(up => new { up.UserId, up.PlatformId });

            //HistoryEmotion relation table
            modelBuilder.Entity<HistoryEmotion>()
                .HasKey(he => new { he.HistoryEmotionId});

            //DirectorMovie relation table
            modelBuilder.Entity<DirectorMovie>()
                .HasKey(dm => new { dm.DirectorId, dm.MovieId });
            
            //GenreMovie relation table
            modelBuilder.Entity<GenreMovie>()
                .HasKey(gm => new { gm.GenreId, gm.MovieId });

            //CountryPlatform relation table
            modelBuilder.Entity<CountryPlatform>()
                .HasKey(cp => new { cp.CountryId, cp.PlatformId });

            /*
             * RELATIONSHIPS
             */

            //User-UserGenre relationship  1:N
            modelBuilder.Entity<UserGenre>()
                .HasOne(ug => ug.User)
                .WithMany(u => u.UserGenres)
                .HasForeignKey(ug => ug.UserId);

            //User-UserPlatform relationship  1:N
            modelBuilder.Entity<UserPlatform>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserPlatforms)
                .HasForeignKey(up => up.UserId);

            //User-History relationship  1:N
            modelBuilder.Entity<Register>()
                .HasOne(r => r.User)
                .WithMany(u => u.History)
                .HasForeignKey(r => r.UserId);

            //User-Country relationship  1:N
            modelBuilder.Entity<User>()
                .HasOne(u => u.Country)
                .WithMany(c => c.Users)
                .HasForeignKey(u => u.CountryId);

            //UserPlatform-Platform relationship  1:N
            modelBuilder.Entity<UserPlatform>()
                .HasOne(up => up.Platform)
                .WithMany(p => p.UserPlatforms)
                .HasForeignKey(up => up.PlatformId);

            //UserGenre-Genre relationship  1:N
            modelBuilder.Entity<UserGenre>()
                .HasOne(ug => ug.Genre)
                .WithMany(g => g.UserGenres)
                .HasForeignKey(ug => ug.GenreId);

            //Hstory-HistoryEmotion relationship  1:N
            modelBuilder.Entity<HistoryEmotion>()
                .HasOne(he => he.Register)
                .WithMany(r => r.HistoryEmotions)
                .HasForeignKey(he => he.RegisterId);

            //HistoryEmotion-Emotion relationship  1:N
            modelBuilder.Entity<HistoryEmotion>()
                .HasOne(he => he.Emotion)
                .WithMany(e => e.HistoryEmotions)
                .HasForeignKey(he => he.EmotionId);

            //History-Movie relationship  1:N
            modelBuilder.Entity<Register>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Registers)
                .HasForeignKey(r => r.MovieId);

            //Movie-GenreMovie relationship  1:N
            modelBuilder.Entity<GenreMovie>()
                .HasOne(gm => gm.Movie)
                .WithMany(m => m.GenreMovies)
                .HasForeignKey(gm => gm.MovieId);

            //Genre-GenreMovie relationship  1:N
            modelBuilder.Entity<GenreMovie>()
                .HasOne(gm => gm.Genre)
                .WithMany(g => g.GenreMovies)
                .HasForeignKey(gm => gm.GenreId);

            //Director-DirectorMovie relationship  1:N
            modelBuilder.Entity<DirectorMovie>()
                .HasOne(dm => dm.Director)
                .WithMany(d => d.DirectorMovies)
                .HasForeignKey(dm => dm.DirectorId);

            //Movie-DirectorMovie relationship  1:N
            modelBuilder.Entity<DirectorMovie>()
                .HasOne(dm => dm.Movie)
                .WithMany(m => m.DirectorMovie)
                .HasForeignKey(dm => dm.MovieId);

            //Country-CountryPlatform relationship  1:N
            modelBuilder.Entity<CountryPlatform>()
                .HasOne(cp => cp.Country)
                .WithMany(c => c.CountryPlatforms)
                .HasForeignKey(cp => cp.CountryId);

            //Platform-CountryPlatform relationship  1:N
            modelBuilder.Entity<CountryPlatform>()
                .HasOne(cp => cp.Platform)
                .WithMany(p => p.CountryPlatforms)
                .HasForeignKey(cp => cp.PlatformId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
