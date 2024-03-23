using Bookworm.Data.Models;
using Bookworm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookworm.Business
{
    internal class BusinessReadingList
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
