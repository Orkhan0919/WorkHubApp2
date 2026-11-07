using System.Reflection;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorkHub.Application.Common.Interfaces;
using WorkHub.Domain.Entities;
using WorkHub.Domain.Enums;
using WorkHub.Infrastructure.Identity;

namespace WorkHub.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<TodoList> TodoLists => Set<TodoList>();
    public DbSet<Vacancy> Vacancies => Set<Vacancy>();
    public DbSet<Resume> Resumes => Set<Resume>();
    public DbSet<JobApplication> JobApplications => Set<JobApplication>();



    public DbSet<TodoItem> TodoItems => Set<TodoItem>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            
            optionsBuilder.UseNpgsql("User Id=postgres;Password=123456;Host=localhost;Port=5432;Database=WorkHubAPIDb;");
        }
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        builder.Entity<User>()
        .HasOne(u => u.Resume)
        .WithOne(r => r.User)
        .HasForeignKey<Resume>(r => r.UserId);
    }
}
