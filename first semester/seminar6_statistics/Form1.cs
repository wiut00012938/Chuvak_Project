namespace seminar6_statistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var costumer = tbxName.Text;
            var amount = numAmount.Value;
            var rate = numRate.Value;
            var balance = amount + amount * rate / 100;
            var message = $@"Today date: {DateTime.Now:dd-MMM-yyyy hh:mm}
The amount of deposit: {amount:C2}
The interest rate: {rate/100:P1}
Balance after the interest will be applied: {balance:C1}
Thank you!";
            MessageBox.Show(message);
        }
    }
}