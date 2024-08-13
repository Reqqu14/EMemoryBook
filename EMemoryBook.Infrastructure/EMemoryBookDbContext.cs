using EMemoryBook.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EMemoryBook.Infrastructure;

public class EMemoryBookDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Template> Templates { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Payment> Payments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasKey(u => u.Id);
        modelBuilder.Entity<User>()
            .HasMany(u => u.Events)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId);

        modelBuilder.Entity<Event>()
            .HasKey(e => e.Id);
        modelBuilder.Entity<Event>()
            .HasOne(e => e.User)
            .WithMany(u => u.Events)
            .HasForeignKey(e => e.UserId);
        modelBuilder.Entity<Event>()
            .HasOne(e => e.Template)
            .WithMany(t => t.Events)
            .HasForeignKey(e => e.TemplateId);
        modelBuilder.Entity<Event>()
            .HasMany(e => e.Messages)
            .WithOne(m => m.Event)
            .HasForeignKey(m => m.EventId);

        modelBuilder.Entity<Template>()
            .HasKey(t => t.Id);
        modelBuilder.Entity<Template>()
            .HasMany(t => t.Events)
            .WithOne(e => e.Template)
            .HasForeignKey(e => e.TemplateId);

        modelBuilder.Entity<Message>()
            .HasKey(m => m.Id);
        modelBuilder.Entity<Message>()
            .HasOne(m => m.Event)
            .WithMany(e => e.Messages)
            .HasForeignKey(m => m.EventId);

        modelBuilder.Entity<Payment>()
            .HasKey(p => p.Id);
        modelBuilder.Entity<Payment>()
            .HasOne(p => p.Event)
            .WithOne(e => e.Payment)
            .HasForeignKey<Payment>(p => p.EventId);
    }
}
