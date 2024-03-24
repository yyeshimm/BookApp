using Bookworm.Data;
using Bookworm.Data.Models;

namespace Bookworm.Business
{
    public class BusinessBook
    {
        private BookwormContext bookwormContext;
        public void Add(Book book) 
        {
            using (bookwormContext = new BookwormContext())
            {
                bookwormContext.Books.Add(book);
                bookwormContext.SaveChanges();
            }
        }
        public List<Book> ListAll()
        {
            using (bookwormContext = new BookwormContext())
            {
                return bookwormContext.Books.ToList();
            }
        }
        public void Remove(int id) 
        { 
            using (bookwormContext = new BookwormContext())
            {
                var book = bookwormContext.Books.Find(id);
                if (book != null)
                {
                    bookwormContext.Books.Remove(book);
                    bookwormContext.SaveChanges(); 
                }
            }
        }
    }
}
