using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWork
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
            _productDal.Add(new Product
            {

                ProductName = txtProductName.Text,
                CategoryId = Convert.ToInt32(txtCategoryId.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                StockAmount = Convert.ToInt32(txtStockAmount.Text)

            });
            LoadProducts();
            MessageBox.Show("Added");
        }
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                ProductName = txtProductNameUpdate.Text,
                CategoryId = Convert.ToInt32(txtCategoryIdUpdate.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(txtStockAmountUpdate.Text)

            });
            LoadProducts();
            MessageBox.Show("uppeded");
        }

        private void dgwProducts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryIdUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtProductNameUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            txtStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
            }) ;
            LoadProducts();
            MessageBox.Show("deleted");
        }
    }
}
