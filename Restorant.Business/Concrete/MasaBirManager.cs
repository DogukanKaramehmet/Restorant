using Restorant.Business.Abstract;
using Restorant.DataAccess.Abstract;
using Restorant.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Business.Concrete
{
    public class MasaBirManager : IMasaBirSevrice
    {
        private IMasaBirDal _masaBirDal;
        public MasaBirManager(IMasaBirDal masaBirDal)
        {
            _masaBirDal = masaBirDal;
        }
        public List<Masabir> GetAll()
        {
            return _masaBirDal.GetAll();
        }
    }
}
