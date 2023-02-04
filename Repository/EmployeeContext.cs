using DomainLayer.EntityMapper;
using DomainLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer;

public partial class EmployeeContext : IdentityDbContext
{
    public EmployeeContext()
    {
    }

    public EmployeeContext(DbContextOptions<EmployeeContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EmployeeMapper());
        modelBuilder.ApplyConfiguration(new DepartmentMapper());
        //modelBuilder.ApplyConfiguration(new RolesMapper());
        //modelBuilder.ApplyConfiguration(new UsersMapper());
        //modelBuilder.Entity<IdentityUser>().ToTable("Roles");
        //modelBuilder.Entity<IdentityRole>().ToTable("Users");
        modelBuilder.Entity<Users>(entity =>
        {
            entity.ToTable(name: "Users");
        });

        modelBuilder.Entity<Roles>(entity =>
        {
            entity.ToTable(name: "Roles");
        });
        base.OnModelCreating(modelBuilder);
    }
}
