using Restorant.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.DataAccess.Concrete.EntityFramework
{
    public class RestorantContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Masabir> Masabirs { get; set; }
    }
}
