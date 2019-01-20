using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        //ctor + tab gets you a constructor
        //dbcontext must have an INSTANCE of dbcontext options in order for them to work; we pass them up to the base constructor
        public DataContext(DbContextOptions<DataContext> options) : base (options){ }

        public DbSet<Value> Values { get; set; }
    }
}