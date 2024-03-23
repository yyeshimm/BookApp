using Bookworm.Data.Models;
using Bookworm.Data;

namespace Bookworm.Business
{
    public class BusinessAuthor
    {
        private BookwormContext bookwormContext;
        public void Add(Author author)
        {
            using (bookwormContext = new BookwormContext())
            {
                bookwormContext.Authors.Add(author);
                bookwormContext.SaveChanges();
            }
        }
        public List<Author> ListAll()
        {
            using (bookwormContext = new BookwormContext())
            {
                return bookwormContext.Authors.ToList();
            }
        }
        public void Remove(int id)
        {
            using (bookwormContext = new BookwormContext())
            {
                var author = bookwormContext.Authors.Find(id);
                if (author != null)
                {
                    bookwormContext.Authors.Remove(author);
                    bookwormContext.SaveChanges();
                }
            }
        }
    }
}
