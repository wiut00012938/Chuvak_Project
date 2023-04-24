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
    public partial class AddPurpchaseOrder : Form
    {
        public AddPurpchaseOrder()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            var sortedData = new ToOrder_Manager().Sorting();
            var filteredData = new ToOrder_Manager().Filtering(sortedData);

            dgv.DataSource = filteredData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int checkedCount = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells[6].Value);
                checkedCount++;
            }
            if (checkedCount > 5)
            {
                MessageBox.Show("You can select up to 5 items to order.");
            }
            else
            {
                double TotalAmount = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[6].Value);
                    if (isChecked)
                    {
                        int remaining = Convert.ToInt32(row.Cells[2].Value);
                        int toOrder = Convert.ToInt32(row.Cells[4].Value);
                        int new_remaining = remaining + toOrder;
                        var ProductName = Convert.ToString(row.Cells[0].Value);
                        try
                        {
                            var manager = new ToOrder_Manager();
                            manager.Update(new_remaining, ProductName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Double Price = toOrder * Convert.ToDouble(row.Cells[5].Value);
                        TotalAmount += Price;
                    }
                }
                try
                {
                    var NewOrderManager = new PurchaseOrder_Manager();
                    NewOrderManager.Create(TotalAmount);
                    MyForms.GetForm<PurchaseOrders>().Show();
                    Close();
                    //MyForms.GetForm<PurchaseOrders>().LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void AddPurpchaseOrder_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }
    }
}
