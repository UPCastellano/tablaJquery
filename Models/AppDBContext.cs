using Microsoft.EntityFrameworkCore;

namespace tablaJquery.Models
{
    public class AppDBContext: DbContext 
    {
        private readonly DbContextOptions _options;

        public AppDBContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }
        public DbSet<User> users { get; set; }
    }
}
