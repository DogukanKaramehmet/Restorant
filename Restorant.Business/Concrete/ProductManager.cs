using Restorant.Business.Abstract;
using Restorant.DataAccess.Abstract;
using Restorant.DataAccess.Concrete;
using Restorant.DataAccess.Concrete.EntityFramework;
using Restorant.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void add(Product product)
        {
            _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }


    }
}
