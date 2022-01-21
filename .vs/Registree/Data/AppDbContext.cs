using Registree.Models;
using Microsoft.EntityFrameworkCore;

namespace Registree.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students{get;set;}
    }
}