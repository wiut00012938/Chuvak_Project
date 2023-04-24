using SuperDuperMarket.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperDuperMarket
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new Product_Add();
            form.CreateNewProduct();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }
        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new Product_Manager().GetAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an item");
            else
            {
                var c = (Product)dgv.SelectedRows[0].DataBoundItem;
                new Product_Add().UpdateProduct(c);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a course");
            else
            {
                var c = (Product)dgv.SelectedRows[0].DataBoundItem;
                new Product_Manager().Delete(c.Id);
                LoadData();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ByAttribute selectedAttribute = ByAttribute.Name;
            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to sort by"); //validating of combobox
            else
            {
                if (cbxSort.SelectedIndex == 0)
                    selectedAttribute = ByAttribute.Name;
                else if (cbxSort.SelectedIndex == 1)
                    selectedAttribute = ByAttribute.Priority;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new Product_Manager().SortProducts(selectedAttribute);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchItem = tbxSearch.Text.Trim();
            if (searchItem == "")
            {
                MessageBox.Show("Enter a text for searching");
            }
            else
            {
                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new Product_Manager().SearchByName(tbxSearch.Text);
            }
        }
    }
}
