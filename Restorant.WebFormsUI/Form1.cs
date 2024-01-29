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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnMasa1_Click(object sender, EventArgs e)
        {
            Masa1 M1 = new Masa1();
            M1.Show();
            
        }
        private void btnMenuDuzen_Click(object sender, EventArgs e)
        {
            MenuDuzen menuDuzen = new MenuDuzen();
            menuDuzen.Show();
        }

        private void BtnMasa2_Click(object sender, EventArgs e)
        {
            Masa2 M2 = new Masa2();
            M2.Show();
        }
    }
}
