using Microsoft.EntityFrameworkCore;
using SimpleCrud.Models;

namespace Data.PostgreSQL
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
        }

        public DbSet<User> users { get; set; }

    }

}
