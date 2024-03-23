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

        
    }
}
