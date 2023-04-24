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
    public partial class PurchaseOrders : Form
    {
        public PurchaseOrders()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new PurchaseOrder_Manager().GetAll();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<AddPurpchaseOrder>().Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void PurchaseOrders_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }
    }
}
