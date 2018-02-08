using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstTraining.Models
{
    public class Bolt : DbContext
    {
        public DbSet<Kategoria> Kategoriak { get; set; }
    }
}