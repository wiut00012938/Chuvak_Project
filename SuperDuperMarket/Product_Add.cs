using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SuperDuperMarket.DAL;

namespace SuperDuperMarket
{
    public partial class Product_Add : Form
    {
        public Product_Add()
        {
            InitializeComponent();
        }
        public Product Product { get; set; }

        public FormMode Mode { get; set; }

        
        public void CreateNewProduct()
        {
            Mode = FormMode.CreateNew;
            Product = new Product();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateProduct(Product product)
        {
            Mode = FormMode.Update;
            Product = product;
            InitializeControls();
            ShowProductsInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
        }
        private void ShowProductsInControls()
        {
            tbxName.Text = Product.Name;
            nudRemaining.Value = Product.Remaining;
            nudPriority.Value = Product.Priority;
            nudPurchaseLevel.Value = Product.PurchaseLevel;
            nudPrice.Value = Convert.ToDecimal(Product.Price);

        }

        private void GrabUserInput()
        {
            Product.Name = tbxName.Text;
            Product.Remaining = Convert.ToInt32(nudRemaining.Value);
            Product.Priority = Convert.ToInt32(nudPriority.Value);
            Product.PurchaseLevel = Convert.ToInt32(nudPurchaseLevel.Value);
            Product.price = Convert.ToDouble(nudPrice.Value);
            MessageBox.Show(Product.price.ToString());
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new Product_Manager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Product);
                else
                    manager.Update(Product);
                MessageBox.Show(Convert.ToDecimal(nudPrice.Value).ToString());
                MyForms.GetForm<Products>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
