using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Football2.MyDatabase
{
    public class FootballContext: DbContext

    {
        public DbSet<Team> Teams { get;set;}

    }
}
