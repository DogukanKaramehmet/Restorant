using Restorant.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Entites.Concrete
{
    public class Masabir:IEntity
    {
        public int MasaID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitePrice { get; set; }
    }
}
