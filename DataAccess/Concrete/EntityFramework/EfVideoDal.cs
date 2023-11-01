using DataAccess.Abstract;
using PixSelectStaj.Concrete;
using PixSelectStaj.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfVideoDal:EfEntityRepository<Video,Context> ,IVideoDal
    {
    }
}
