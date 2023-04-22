namespace sample_show_digits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxinput_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = tbxinput.Text;
            var result = "";
            foreach (var item in input)
            {
                result += item + "\n";
            }
            MessageBox.Show(result);
        }
    }
    }
