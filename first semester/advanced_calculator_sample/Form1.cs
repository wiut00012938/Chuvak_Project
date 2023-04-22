namespace advanced_calculator_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxsecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxfirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var first_number = tbxfirst.Text;
            var second_number = tbxsecond.Text;
            var first_converted = 0;
            var second_converted = 0;
            var settled_words = new Dictionary<string, int>() { { "zero", 0 }, { "one", 1 }, { "two", 2 }, { "three", 3 }, { "four", 4 }, { "five", 5 }, { "six", 6 }, { "seven", 7 }, {"eight", 8 }, {"nine", 9}
            };
            if (settled_words.ContainsKey(first_number))
            {
                first_converted = settled_words[first_number];
            }
            if (settled_words.ContainsKey(second_number))
            {
                second_converted = settled_words[first_number];
            }
            else
            {
                MessageBox.Show("Something is wrong");
            }
            var result = first_converted + second_converted;
            MessageBox.Show(result.ToString());
        }
    }
}