namespace seminar2_exchanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            var amount_sum = Convert.ToDouble(txtsum.Text);
            var result = amount_sum / 11000;
            txtdollar.Text = result.ToString();
        }

        private void txtdollar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnround1_Click(object sender, EventArgs e)
        {
            //var dollars = Convert.ToDecimal(txtdollar.Text);
            //var amount_in_dollars = Math.Round(dollars, 0);
            //txtdollar = amount_in_dollars.ToString();
            var input_rounded = Math.Round(Convert.ToDouble(txtdollar.Text));
            txtdollar.Text = input_rounded.ToString();
        }

        private void btnround2_Click(object sender, EventArgs e)
        {
            var input_rounded = Math.Round(Convert.ToDouble(txtdollar.Text), 2);
            txtdollar.Text = input_rounded.ToString();
        }
    }
}