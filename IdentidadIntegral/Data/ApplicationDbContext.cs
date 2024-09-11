using IdentidadIntegral.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentidadIntegral.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Models.Action> Actions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProject>()
                .HasKey(up => new { up.UserId, up.ProjectId });

            modelBuilder.Entity<UserProject>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserProjects)
                .HasForeignKey(up => up.UserId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserProject>()
                .HasOne(up => up.Project)
                .WithMany(p => p.UserProjects)
                .HasForeignKey(up => up.ProjectId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RoleAction>()
        .HasKey(ra => new { ra.RoleId, ra.ActionId });

            modelBuilder.Entity<RoleAction>()
                .HasOne(ra => ra.Role)
                .WithMany(r => r.RoleActions)
                .HasForeignKey(ra => ra.RoleId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RoleAction>()
                .HasOne(ra => ra.Action)
                .WithMany(a => a.RoleActions)
                .HasForeignKey(ra => ra.ActionId).OnDelete(DeleteBehavior.NoAction);
        }
    }

}
