using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixSelectStaj.Entities
{
    public class Context:DbContext
    {
        public DbSet<Video> Videos { get; set; }
        
    }
}
