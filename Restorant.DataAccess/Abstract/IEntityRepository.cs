using Restorant.Entites.Abstract;
using Restorant.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        void Add(T entitiy);
        void Delete(T entitiy);
        void Update(T entitiy);
    }
}
