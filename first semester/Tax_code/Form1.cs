using System.Xml.Schema;

namespace Tax_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var name = tbxName.Text;
            var purchase = Convert.ToDouble(numPurachase.Value);
            var total = 0.0;
            var tax = 0.0;
            if (tax_exempt.Checked)
            {
                total = purchase;
                tax = 0;
            }
            if (state_sales.Checked)
            {
                total = purchase + purchase * 0.03;
                tax = 0.03;
            }
            if (federal.Checked)
            {
                total = purchase + purchase * 0.05;
                tax = 0.05;
            }
            if (special.Checked)
            {
                total = purchase + purchase * 0.07;
                tax = 0.07;
            }
            var message = $@"Customer name: {name}
Purchase amount: {purchase}
Sales tax: {tax:P2}
Total amound due:{total}";
            MessageBox.Show(message, "Abdulaziz's");
        }
    }
}