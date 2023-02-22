using Microsoft.EntityFrameworkCore;

namespace asp_dotnet_core_api_healthy_food.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region DbSet
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion
    }
}
