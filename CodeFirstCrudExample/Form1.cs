using CodeFirstCrudExample.Data.Contexts;
using CodeFirstCrudExample.Data.Entities;
using CodeFirstCrudExample.Dtos;

namespace CodeFirstCrudExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        void GetAll()
        {
            List<ProductDto> productList = db.Products.Select(x => new ProductDto
            {
                ProductId = x.Id,
                ProductName = x.Name,
                CategoryName = x.Category.Name,
                Price = x.Price,
                Stock = x.Stock
            }).ToList();

            lstProductLists.Items.Clear();

            foreach (ProductDto product in productList)
            {
                ListViewItem li = new ListViewItem();

                li.Text = product.ProductName;
                li.SubItems.Add(product.CategoryName);
                li.SubItems.Add(product.Price.ToString());
                li.SubItems.Add(product.Stock.ToString());
                li.Tag = product;


                lstProductLists.Items.Add(li);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            List<CodeFirstCrudExample.Data.Entities.Category> categoryList = db.Categories.ToList();

            foreach (var item in categoryList)
            {
                cmbCategoryName.Items.Add(item);
                cmbFilterCategory.Items.Add(item);
            }

            GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txtName.Text;
            product.Price = Convert.ToDecimal(txtPrice.Text);
            product.Stock = int.Parse(txtStock.Text);
            product.CategoryId = ((Category)cmbCategoryName.SelectedItem).Id;


            db.Products.Add(product);
            int result = db.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Kayýt Eklendi");
                GetAll();
            }



        }

        private void lstProductLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductDto selectedProduct = (ProductDto)lstProductLists.FocusedItem.Tag;

            txtProductName.Text = selectedProduct.ProductName;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductDto selectedProduct = (ProductDto)lstProductLists.FocusedItem.Tag;


            Product product = db.Products.Find(selectedProduct.ProductId);


            if (product != null)
            {
                product.Name = txtProductName.Text;

                db.Products.Update(product);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Güncelleme Ýþlemi Baþarýlý");
                    GetAll();
                }

            }
            else
            {
                MessageBox.Show("Böyle Bir Ürün Yok");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductDto selectedProduct = (ProductDto)lstProductLists.FocusedItem.Tag;

            Product product = db.Products.Find(selectedProduct.ProductId);

            if (product != null)
            {

                db.Products.Remove(product);
                int result = db.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show("Silme Ýþlemi Baþarýlý");
                    GetAll();
                }

            }
            else
            {
                MessageBox.Show("Böyle Bir Ürün Yok");
            }
        }

        private void btnGetProduct_Click(object sender, EventArgs e)
        {

            Category selectedCategory = (Category)cmbFilterCategory.SelectedItem;

            List<Product> productList = db.Products.Where(x => x.CategoryId == selectedCategory.Id).ToList();

            string productName = " ";
            
            foreach (Product product in productList)
            {
                productName += "-" + product.Name;


            }

            MessageBox.Show(productName);
        }
    }
}
