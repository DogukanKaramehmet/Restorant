using Restorant.Business.Abstract;
using Restorant.Business.Concrete;
using Restorant.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant.WebFormsUI
{
    public partial class MenuDuzen : Form
    {
        public MenuDuzen()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }
        private IProductService _productService;
        private void MenuDuzen_Load(object sender, EventArgs e)
        {
            
            dgwProduct.DataSource = _productService.GetAll();
        }
    }
}
