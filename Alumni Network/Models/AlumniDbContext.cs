using Microsoft.EntityFrameworkCore;

namespace Alumni_Network.Models
{
    public class AlumniDbContext : DbContext
    {
        public AlumniDbContext(DbContextOptions<AlumniDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasOne(e => e.ReplyParent)
                .WithMany(e => e.Replies)
                .HasForeignKey(e => e.ReplyParentId)
                .IsRequired(false);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && 
            (
                e.State == EntityState.Added || e.State == EntityState.Modified)
            );

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
