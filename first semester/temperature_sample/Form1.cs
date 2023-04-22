namespace temperature_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            var input = tbxInput.Text.Split(",;: ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            var converted = new double[input.Length];
            var result = new double[converted.Length];
            for(int i = 0; i < input.Length; i++)
            {
                if (Isnumeric(input[i]))
                {
                    converted[i] = Convert.ToDouble(input[i]);
                }
                else
                {
                    MessageBox.Show("Sorry, your entered wrong type of input. Try one more time");
                    return;
                }
            }
            foreach (var item in converted)
            {
                if (item < -50)
                {
                    MessageBox.Show("Seems that there is a typeof. enter the value one more time");
                    return;
                }
                else if (item > 60)
                {
                    MessageBox.Show("Seems that there is a typeof. enter the value one more time");
                    return;
                }
            }
            for (int i = 0; i < converted.Length; i++)
            {
                result[i] = Math.Round(converted[i] * 1.8 + 32, 2);
            }
            string final = string.Join(", ", result);
            MessageBox.Show(final);

        }
        private bool Isnumeric (string value)
        {
            double number;
            return double.TryParse(value,out number);
        }
    }
}