using Restorant.DataAccess.Abstract;
using Restorant.DataAccess.Concrete.Entity_Framework;
using Restorant.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,RestorantContext>,IProductDal
    {

    }
}
