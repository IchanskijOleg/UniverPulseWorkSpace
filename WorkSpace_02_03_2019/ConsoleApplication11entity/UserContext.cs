using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11entity
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DBconne")
        { }

        public DbSet<User> Users { get; set; }

    }
}
