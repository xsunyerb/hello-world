using HelloWorldApi;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldApi
{
    class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options) { }

        public DbSet<User> Users => Set<User>();
    }
}