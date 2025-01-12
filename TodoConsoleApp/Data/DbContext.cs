using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TodoConsoleApp.Data
{

    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        // Define the connection string to your database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true);
            IConfiguration configuration = builder.Build();
            string? connectionString = configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("Error: Connection string not found!");
                Environment.Exit(0);
            }
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
