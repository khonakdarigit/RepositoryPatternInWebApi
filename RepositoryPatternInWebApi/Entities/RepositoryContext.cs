using Microsoft.EntityFrameworkCore;
using RepositoryPatternInWebApi.Entities.Models;

namespace RepositoryPatternInWebApi.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Owner> Owner { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
