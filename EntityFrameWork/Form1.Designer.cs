
namespace EntityFrameWork
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateProduct = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.txtStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.txtProductNameUpdate = new System.Windows.Forms.TextBox();
            this.txtCategoryIdUpdate = new System.Windows.Forms.TextBox();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.txtUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblCatgoryId = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.UpdateProduct.SuspendLayout();
            this.add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(939, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 251);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 31);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 31);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 31);
            this.textBox3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stock Amount";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(232, 31);
            this.textBox4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unit Price";
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Controls.Add(this.UpdateButton);
            this.UpdateProduct.Controls.Add(this.txtStockAmountUpdate);
            this.UpdateProduct.Controls.Add(this.lblProductNameUpdate);
            this.UpdateProduct.Controls.Add(this.txtProductNameUpdate);
            this.UpdateProduct.Controls.Add(this.txtCategoryIdUpdate);
            this.UpdateProduct.Controls.Add(this.lblStockAmountUpdate);
            this.UpdateProduct.Controls.Add(this.txtUnitPriceUpdate);
            this.UpdateProduct.Controls.Add(this.lblCategoryUpdate);
            this.UpdateProduct.Controls.Add(this.lblUnitPriceUpdate);
            this.UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProduct.Location = new System.Drawing.Point(471, 12);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(438, 251);
            this.UpdateProduct.TabIndex = 15;
            this.UpdateProduct.TabStop = false;
            this.UpdateProduct.Text = "Update Product";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(240, 205);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(160, 40);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // txtStockAmountUpdate
            // 
            this.txtStockAmountUpdate.Location = new System.Drawing.Point(200, 153);
            this.txtStockAmountUpdate.Name = "txtStockAmountUpdate";
            this.txtStockAmountUpdate.Size = new System.Drawing.Size(232, 31);
            this.txtStockAmountUpdate.TabIndex = 9;
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(16, 78);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(160, 25);
            this.lblProductNameUpdate.TabIndex = 1;
            this.lblProductNameUpdate.Text = "Product Name";
            // 
            // txtProductNameUpdate
            // 
            this.txtProductNameUpdate.Location = new System.Drawing.Point(200, 78);
            this.txtProductNameUpdate.Name = "txtProductNameUpdate";
            this.txtProductNameUpdate.Size = new System.Drawing.Size(232, 31);
            this.txtProductNameUpdate.TabIndex = 2;
            // 
            // txtCategoryIdUpdate
            // 
            this.txtCategoryIdUpdate.Location = new System.Drawing.Point(200, 39);
            this.txtCategoryIdUpdate.Name = "txtCategoryIdUpdate";
            this.txtCategoryIdUpdate.Size = new System.Drawing.Size(232, 31);
            this.txtCategoryIdUpdate.TabIndex = 5;
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(16, 159);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(157, 25);
            this.lblStockAmountUpdate.TabIndex = 8;
            this.lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // txtUnitPriceUpdate
            // 
            this.txtUnitPriceUpdate.Location = new System.Drawing.Point(200, 115);
            this.txtUnitPriceUpdate.Name = "txtUnitPriceUpdate";
            this.txtUnitPriceUpdate.Size = new System.Drawing.Size(232, 31);
            this.txtUnitPriceUpdate.TabIndex = 7;
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(16, 42);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(133, 25);
            this.lblCategoryUpdate.TabIndex = 4;
            this.lblCategoryUpdate.Text = "Category Id";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(16, 121);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(115, 25);
            this.lblUnitPriceUpdate.TabIndex = 6;
            this.lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // add
            // 
            this.add.Controls.Add(this.btnAdd);
            this.add.Controls.Add(this.txtStockAmount);
            this.add.Controls.Add(this.lblProductName);
            this.add.Controls.Add(this.txtCategoryId);
            this.add.Controls.Add(this.txtProductName);
            this.add.Controls.Add(this.lblStockAmount);
            this.add.Controls.Add(this.txtUnitPrice);
            this.add.Controls.Add(this.lblCatgoryId);
            this.add.Controls.Add(this.lblUnitPrice);
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(12, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(438, 251);
            this.add.TabIndex = 14;
            this.add.TabStop = false;
            this.add.Text = "Add Product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(240, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 40);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStockAmount
            // 
            this.txtStockAmount.Location = new System.Drawing.Point(200, 153);
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.Size = new System.Drawing.Size(232, 31);
            this.txtStockAmount.TabIndex = 9;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(16, 78);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(160, 25);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(200, 36);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(232, 31);
            this.txtCategoryId.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(200, 78);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(232, 31);
            this.txtProductName.TabIndex = 2;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(16, 159);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(157, 25);
            this.lblStockAmount.TabIndex = 8;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(200, 115);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(232, 31);
            this.txtUnitPrice.TabIndex = 7;
            // 
            // lblCatgoryId
            // 
            this.lblCatgoryId.AutoSize = true;
            this.lblCatgoryId.Location = new System.Drawing.Point(16, 42);
            this.lblCatgoryId.Name = "lblCatgoryId";
            this.lblCatgoryId.Size = new System.Drawing.Size(133, 25);
            this.lblCatgoryId.TabIndex = 4;
            this.lblCatgoryId.Text = "Category Id";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(16, 121);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(115, 25);
            this.lblUnitPrice.TabIndex = 6;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(-1, 279);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(1378, 159);
            this.dgwProducts.TabIndex = 13;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateProduct);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.UpdateProduct.ResumeLayout(false);
            this.UpdateProduct.PerformLayout();
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox UpdateProduct;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox txtStockAmountUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.TextBox txtProductNameUpdate;
        private System.Windows.Forms.TextBox txtCategoryIdUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.TextBox txtUnitPriceUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.GroupBox add;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblCatgoryId;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.DataGridView dgwProducts;
    }
}

