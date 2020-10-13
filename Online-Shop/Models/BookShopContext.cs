using Microsoft.EntityFrameworkCore;

namespace Online_Shop.Models
{
    public class BookShopContext: DbContext
    {
        public BookShopContext(DbContextOptions<BookShopContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Price)
                    .IsRequired();

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(int.MaxValue);

                entity.HasIndex(e => e.Id)
                    .IsUnique();
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(35);

                entity.Property(e => e.DateOfBirth)
                    .IsRequired();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasIndex(e => e.Id)
                    .IsUnique();
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderDate)
                    .IsRequired();

                entity.Property(e => e.Price)
                    .IsRequired();

                entity.HasIndex(e => e.Id)
                    .IsUnique();

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__CurrentPa__ProductId__00DF2177");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__CurrentPa__UserId__00DF2177");
            });
        }
    }
}
