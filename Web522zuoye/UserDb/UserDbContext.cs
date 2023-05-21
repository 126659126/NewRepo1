using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace UserDb
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<ModulerodeTable> ModulerodeTable { get; set; }
        public DbSet<ModuleTable> ModuleTable { get; set; }
        public DbSet<RodeUserTable> RodeUserTable { get; set; }
        public DbSet<Role_db> Role_db { get; set; }
        public DbSet<UserTable> UserTable { get; set; }
    }
}
