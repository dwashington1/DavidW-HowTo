using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class Lightbulb
    {
        public int id { get; set; }
        public string TableName { get; set; }
        public int Step { get; set; }
        public string Description { get; set; }
    }

    public class HowTo : DbContext
    {
        public DbSet<Lightbulb> ALightBulb { get; set; }
    }
}
