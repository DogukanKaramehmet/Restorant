using Restorant.DataAccess.Abstract;
using Restorant.DataAccess.Concrete.EntityFramework;
using Restorant.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.DataAccess.Concrete.Entity_Framework
{
    public class EfMasaBirDal:EfEntityRepositoryBase<Masabir,RestorantContext>,IMasaBirDal
    {
    }
}
