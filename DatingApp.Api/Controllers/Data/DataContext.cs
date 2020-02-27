using DatingApp.Api.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Api.Controllers.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values { get; set; }

        
    }
}