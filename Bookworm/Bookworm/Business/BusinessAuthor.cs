using Bookworm.Data.Models;
using Bookworm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
