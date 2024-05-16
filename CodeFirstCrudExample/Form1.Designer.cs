namespace CodeFirstCrudExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnGetProduct = new Button();
            cmbFilterCategory = new ComboBox();
            label6 = new Label();
            btnDelete = new Button();
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            txtProductName = new TextBox();
            label5 = new Label();
            lstProductLists = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnAdd = new Button();
            cmbCategoryName = new ComboBox();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetProduct);
            groupBox1.Controls.Add(cmbFilterCategory);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(lstProductLists);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cmbCategoryName);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(75, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1021, 558);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Create";
            // 
            // btnGetProduct
            // 
            btnGetProduct.Location = new Point(911, 97);
            btnGetProduct.Name = "btnGetProduct";
            btnGetProduct.Size = new Size(99, 30);
            btnGetProduct.TabIndex = 17;
            btnGetProduct.Text = "GetProducts";
            btnGetProduct.UseVisualStyleBackColor = true;
            btnGetProduct.Click += btnGetProduct_Click;
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Location = new Point(836, 45);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(174, 28);
            cmbFilterCategory.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(718, 45);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 15;
            label6.Text = "CategoryName:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(627, 350);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 42);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(379, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 267);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product Update";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(182, 99);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 37);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(126, 57);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(164, 27);
            txtProductName.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 57);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 10;
            label5.Text = "ProductName:";
            // 
            // lstProductLists
            // 
            lstProductLists.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstProductLists.FullRowSelect = true;
            lstProductLists.Location = new Point(6, 350);
            lstProductLists.Name = "lstProductLists";
            lstProductLists.Size = new Size(600, 147);
            lstProductLists.TabIndex = 9;
            lstProductLists.UseCompatibleStateImageBehavior = false;
            lstProductLists.View = View.Details;
            lstProductLists.SelectedIndexChanged += lstProductLists_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ProductName";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "CategoryName";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Stock";
            columnHeader4.Width = 100;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(234, 273);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 39);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbCategoryName
            // 
            cmbCategoryName.FormattingEnabled = true;
            cmbCategoryName.Location = new Point(143, 214);
            cmbCategoryName.Name = "cmbCategoryName";
            cmbCategoryName.Size = new Size(218, 28);
            cmbCategoryName.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(143, 153);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(218, 27);
            txtStock.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(143, 100);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(218, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(143, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 27);
            txtName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 217);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 3;
            label4.Text = "CategoryName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 160);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 103);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 51);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "ProductName:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 608);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private ListView lstProductLists;
        private Button btnAdd;
        private ComboBox cmbCategoryName;
        private TextBox txtStock;
        private TextBox txtPrice;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private TextBox txtProductName;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnDelete;
        private Button btnGetProduct;
        private ComboBox cmbFilterCategory;
        private Label label6;
    }
}
