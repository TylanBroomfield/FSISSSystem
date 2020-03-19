using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //inheritance of DbContext from EntityFramework
using FSISSSystem.ENTITIES;

namespace FSISSSystem.DAL
{
    internal class FSISContext : DbContext
    {
        public FSISContext() : base("FSIS_db")
        {

        }
        public DbSet<Team> Teams { get; set; }

    }
}

