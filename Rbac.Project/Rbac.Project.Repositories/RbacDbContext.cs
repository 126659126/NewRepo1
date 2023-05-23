using Microsoft.EntityFrameworkCore;
using Rbac.Project.Domain;
using System;

namespace Rbac.Project.Repositories
{
    public class RbacDbContext : DbContext
    {
        public RbacDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Menu> Menu { get;set;}
        public DbSet<Role> Role { get;set;}
        public DbSet<RoleMenu> RoleMenu { get;set;}
        public DbSet<UserRole> UserRole { get;set;}
        public DbSet<UserTable> UserTable { get;set;}
}
}
