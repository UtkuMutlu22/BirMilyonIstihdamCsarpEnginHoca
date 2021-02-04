using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();

        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product { CategoryId =Convert.ToInt32(txtCategoryId.Text),ProductName=txtProductName.Text,
            UnitPrice=Convert.ToDecimal(txtUnitPrice.Text),StockAmount=Convert.ToInt32(txtStockAmount.Text)});
            LoadProducts();
            MessageBox.Show("Added now");
        }

     

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryIdUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtProductNameUpdate.Text= dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtUnitPriceUpdate.Text=dgwProducts.CurrentRow.Cells[3].Value.ToString();
            txtStockAmountUpdate.Text= dgwProducts.CurrentRow.Cells[4].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(txtCategoryIdUpdate.Text),
                ProductName = txtProductNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(txtStockAmountUpdate.Text)
            };
            _productDal.Updated(product);
            LoadProducts();
            MessageBox.Show("uppdet now");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("delete now");
        }
    }
}
