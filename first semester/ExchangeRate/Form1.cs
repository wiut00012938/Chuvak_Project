using System.DirectoryServices;

namespace ExchangeRate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private int tries = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;
            var int_input = Convert.ToInt32(textBox1.Text);
            foreach(var item in input)
            {
                var num = Convert.ToString(item);
                if (!isNumeric(num))
                {
                    MessageBox.Show("Enter only numbers");
                    return;
                }
            }
            if (input.Length != 4)
            {
                MessageBox.Show("Pin consists of 4 numbers");
            }
            var right = 1234;
            
            if (right == int_input)
            {
                MessageBox.Show("All right");
                    return;
            }
            else
            {
                 textBox1.Text = "";
                 tries++;
            }
            if (tries == 5)
            {
                MessageBox.Show("your card was blocked");
            }

        }
        private bool isNumeric(string text)
        {
            int pattern;
            return int.TryParse(text, out pattern);
        }
    }
}