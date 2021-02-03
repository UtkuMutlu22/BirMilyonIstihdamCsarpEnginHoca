
namespace AdoNetDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.unitPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.categoryId = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.stokAmount = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.addProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 302);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(1243, 229);
            this.dgwProducts.TabIndex = 0;
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSize = true;
            this.unitPrice.Location = new System.Drawing.Point(48, 36);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(160, 25);
            this.unitPrice.TabIndex = 1;
            this.unitPrice.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(238, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(259, 31);
            this.txtProductName.TabIndex = 2;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(238, 78);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(259, 31);
            this.txtCategory.TabIndex = 4;
            // 
            // categoryId
            // 
            this.categoryId.AutoSize = true;
            this.categoryId.Location = new System.Drawing.Point(48, 84);
            this.categoryId.Name = "categoryId";
            this.categoryId.Size = new System.Drawing.Size(133, 25);
            this.categoryId.TabIndex = 3;
            this.categoryId.Text = "Category Id";
            this.categoryId.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(238, 128);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(259, 31);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unit Price";
            // 
            // txtStockAmount
            // 
            this.txtStockAmount.Location = new System.Drawing.Point(238, 178);
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.Size = new System.Drawing.Size(259, 31);
            this.txtStockAmount.TabIndex = 8;
            // 
            // stokAmount
            // 
            this.stokAmount.AutoSize = true;
            this.stokAmount.Location = new System.Drawing.Point(48, 184);
            this.stokAmount.Name = "stokAmount";
            this.stokAmount.Size = new System.Drawing.Size(157, 25);
            this.stokAmount.TabIndex = 7;
            this.stokAmount.Text = "Stock Amount";
            this.stokAmount.Click += new System.EventHandler(this.label4_Click);
            // 
            // addProduct
            // 
            this.addProduct.Controls.Add(this.btnAdd);
            this.addProduct.Controls.Add(this.txtProductName);
            this.addProduct.Controls.Add(this.txtStockAmount);
            this.addProduct.Controls.Add(this.unitPrice);
            this.addProduct.Controls.Add(this.stokAmount);
            this.addProduct.Controls.Add(this.categoryId);
            this.addProduct.Controls.Add(this.txtUnitPrice);
            this.addProduct.Controls.Add(this.txtCategory);
            this.addProduct.Controls.Add(this.label3);
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.Location = new System.Drawing.Point(304, 12);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(512, 284);
            this.addProduct.TabIndex = 9;
            this.addProduct.TabStop = false;
            this.addProduct.Text = "Add Product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(288, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 39);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 543);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.addProduct.ResumeLayout(false);
            this.addProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label unitPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label categoryId;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.Label stokAmount;
        private System.Windows.Forms.GroupBox addProduct;
        private System.Windows.Forms.Button btnAdd;
    }
}

