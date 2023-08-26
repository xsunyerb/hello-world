using HelloWorldApi;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldApi
{
    class UserDb : DbContext
    {
        public UserDb(DbContextOptions<UserDb> options)
            : base(options) { }

        public DbSet<User> Users => Set<User>();
    }
}