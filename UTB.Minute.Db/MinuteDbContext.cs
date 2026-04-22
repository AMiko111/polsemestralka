using Microsoft.EntityFrameworkCore;
using UTB.Minute.Db.Entities;
using UTB.Minute.Db.Enums;

namespace UTB.Minute.Db;

public class MinuteDbContext(DbContextOptions<MinuteDbContext> options) : DbContext(options)
{
    public DbSet<Meal> Meals => Set<Meal>();
    public DbSet<MenuItem> MenuItems => Set<MenuItem>();
    public DbSet<Order> Orders => Set<Order>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Meal>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Price).HasColumnType("decimal(10,2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(e => e.Meal)
                  .WithMany(m => m.MenuItems)
                  .HasForeignKey(e => e.MealId)
                  .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Status)
                  .HasConversion<string>()
                  .HasDefaultValue(OrderStatus.Preparing);
            entity.Property(e => e.StudentId).IsRequired().HasMaxLength(100);
            entity.HasOne(e => e.MenuItem)
                  .WithMany(m => m.Orders)
                  .HasForeignKey(e => e.MenuItemId)
                  .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
