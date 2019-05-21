using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsAppPlayer
{
    public class SoccerContext : DbContext
    {
        public SoccerContext()
            : base("myDB2")
        { }

        public DbSet<Player> Players { get; set; }
    }
}
