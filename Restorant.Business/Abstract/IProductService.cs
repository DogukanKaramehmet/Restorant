using Restorant.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Business.Abstract
{
    public interface IProductService
    {
        void add(Product product);
        List<Product> GetAll();
    }
}
