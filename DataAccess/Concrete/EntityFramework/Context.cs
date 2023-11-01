using PixSelectStaj.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixSelectStaj.Concrete
{
    public class Context:DbContext
    {
        public DbSet<Video> Videos { get; set; }
        
    }
}
