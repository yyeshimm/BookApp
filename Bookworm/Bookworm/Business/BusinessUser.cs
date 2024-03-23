using Bookworm.Data.Models;
using Bookworm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookworm.Business
{
    internal class BusinessUser
    {
        private BookwormContext bookwormContext;
        public void Add(User user)
        {
            using (bookwormContext = new BookwormContext())
            {
                bookwormContext.Users.Add(user);
                bookwormContext.SaveChanges();
            }
        }
        public void Remove(int id)
        {
            using (bookwormContext = new BookwormContext())
            {
                var user = bookwormContext.Users.Find(id);
                if (user != null)
                {
                    bookwormContext.Users.Remove(user);
                    bookwormContext.SaveChanges();
                }
            }
        }
    }
}
