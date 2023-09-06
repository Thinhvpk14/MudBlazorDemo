using Microsoft.EntityFrameworkCore;

namespace MudBlazor.Entities
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        
        public DbSet<User> Users {get; set;}
    }
}