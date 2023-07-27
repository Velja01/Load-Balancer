using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancer.DB
{
    [ExcludeFromCodeCoverage]
    public class ProjectDBContext : DbContext
    {
        [ExcludeFromCodeCoverage]
        public DbSet<ItemTable> One { get; set; }

        [ExcludeFromCodeCoverage]
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=desktop-2bu3u56;Initial Catalog=ERS;Integrated Security=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    [ExcludeFromCodeCoverage]
    public class ProjectDBContext2 : DbContext
    {
        [ExcludeFromCodeCoverage]
        public DbSet<ItemTable> Two { get; set; }
        [ExcludeFromCodeCoverage]
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=desktop-2bu3u56;Initial Catalog=ERS;Integrated Security=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    [ExcludeFromCodeCoverage]
    public class ProjectDBContext3 : DbContext
    {
        [ExcludeFromCodeCoverage]
        public DbSet<ItemTable> Three { get; set; }
        [ExcludeFromCodeCoverage]
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=desktop-2bu3u56;Initial Catalog=ERS;Integrated Security=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    [ExcludeFromCodeCoverage]
    public class ProjectDBContext4 : DbContext
    {
        [ExcludeFromCodeCoverage]
        public DbSet<ItemTable> Four { get; set; }
        [ExcludeFromCodeCoverage]
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=desktop-2bu3u56;Initial Catalog=ERS;Integrated Security=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

