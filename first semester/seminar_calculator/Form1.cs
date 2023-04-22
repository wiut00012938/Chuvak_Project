namespace seminar_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(num1.Text);
            var number2 = Convert.ToDouble(num2.Text);
            var result = number1 + number2;
            MessageBox.Show(result.ToString());
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(num1.Text);
            var number2 = Convert.ToDouble(num2.Text);
            var result = number1 - number2;
            MessageBox.Show(result.ToString());
        }

        private void btnmulitiply_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(num1.Text);
            var number2 = Convert.ToDouble(num2.Text);
            var result = number1 * number2;
            MessageBox.Show(result.ToString());
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(num1.Text);
            var number2 = Convert.ToDouble(num2.Text);
            var result = number1 / number2;
            MessageBox.Show(result.ToString());
        }

        private void btnpower_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(num1.Text);
            var number2 = Convert.ToDouble(num2.Text);
            var result = Math.Pow(number1, number2);
            MessageBox.Show(result.ToString());
        }

        private void btnremainder_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(num1.Text);
            var number2 = Convert.ToDouble(num2.Text);
            var result = number1 % number2;
            MessageBox.Show(result.ToString());
        }
    }
}