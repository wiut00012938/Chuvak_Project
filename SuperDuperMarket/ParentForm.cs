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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<Products>().Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<Product_Add>().Show();
        }
    }
}
