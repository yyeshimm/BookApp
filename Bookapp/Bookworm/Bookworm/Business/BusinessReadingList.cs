using Bookworm.Data.Models;
using Bookworm.Data;

namespace Bookworm.Business
{
    public class BusinessReadingList
    {
        private BookwormContext bookwormContext;
        public void Add(ReadingList rl)
        {
            using (bookwormContext = new BookwormContext())
            {
                bookwormContext.ReadingLists.Add(rl);
                bookwormContext.SaveChanges();
            }
        }
        public List<ReadingList> ListAll()
        {
            using (bookwormContext = new BookwormContext())
            {
                return bookwormContext.ReadingLists.ToList();
            }
        }
        public void Remove(int id)
        {
            using (bookwormContext = new BookwormContext())
            {
                var rl = bookwormContext.ReadingLists.Find(id);
                if (rl != null)
                {
                    bookwormContext.ReadingLists.Remove(rl);
                    bookwormContext.SaveChanges();
                }
            }
        }
    }
}
