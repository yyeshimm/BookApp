using Bookworm.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookworm.Data
{
    public class BookwormContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ReadingList> ReadingLists { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Bookworm;Integrated Security=true; Encrypt=false;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReadingList>()
            .HasOne(e => e.User)
            .WithMany(e => e.ReadingLists)
            .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Book>()
                .HasOne(e => e.Author)
                .WithMany(e => e.Books)
                .HasForeignKey(e => e.AuthorId);
        }
    }
}
