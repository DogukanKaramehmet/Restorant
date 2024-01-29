using Restorant.Business.Abstract;
using Restorant.Business.Concrete;
using Restorant.DataAccess.Abstract;
using Restorant.DataAccess.Concrete.Entity_Framework;
using Restorant.DataAccess.Concrete.EntityFramework;
using Restorant.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Restorant.WebFormsUI
{
    public partial class Masa2 : Form
    {
        public Masa2()
        {
            InitializeComponent();

            _productService = new ProductManager(new EfProductDal());
            _masaBirSevrice = new MasaBirManager(new EfMasaBirDal());

        }


        private IProductService _productService;
        private IMasaBirSevrice _masaBirSevrice;
        private void Masa2_Load(object sender, EventArgs e)
        {

            //var data = _productService.GetAll();
            //AddButton(data);
            ProductLoad();
            //LoadMasaBir();

        }

        private void ProductLoad()
        {
            dgwProduct.DataSource= _productService.GetAll();
        }

        private void LoadMasaBir()
        {
            cbxMasabir.DataSource = _masaBirSevrice.GetAll();
            cbxMasabir.DisplayMember = "ProductName";
            cbxMasabir.ValueMember = "MasaID";
        }

        private void AddButton(List<Product> data)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int index = i * 3 + j;
                    if (index < data.Count)
                    {

                        Product entity = data[index];
                        Button button = new Button
                        {
                            Text = $" {entity.ProductName}",
                            Tag = index,
                        };

                        button.Size = new Size(100, 50);
                        button.Location = new Point(105 * (j), 55 * (i));
                        button.Click += Button_Click;
                        gpbMenu.Controls.Add(button);
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            int index = (int)clickedButton.Tag;
            Product clickedEntity = _productService.GetAll()[index];


            //DataTable dt = new DataTable();
            //dt.Columns.Add("ProductName", typeof(string));
            //dt.Columns.Add("UnitPrice", typeof(decimal));
            //dt.Rows.Add(clickedEntity.ProductName, clickedEntity.UnitPrice);
            //dgwProduct.DataSource = dt;
        }

        private void LoadProduct()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }
        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnkahvaltı_Click(object sender, EventArgs e)
        {
        }
    }
}
