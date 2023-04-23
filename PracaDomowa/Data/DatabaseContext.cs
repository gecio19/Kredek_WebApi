using Microsoft.EntityFrameworkCore;
using PracaDomowa.Models;

namespace PracaDomowa.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }


        public DbSet<Student> Students{ get; set; }







    }
}
