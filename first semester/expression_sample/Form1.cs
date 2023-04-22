namespace expression_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text.ToCharArray();
            var outcome = 0;
            if ("+".Contains(input[1]))
            {
                outcome = Convert.ToInt32(input[0]) + Convert.ToInt32(input[2]);
            }
            else if ("-".Contains(input[1]))
            {
                outcome = Convert.ToInt32(input[0]) - Convert.ToInt32(input[2]);
            }
            else if ("*".Contains(input[1]))
            {
                outcome = Convert.ToInt32(input[0]) * Convert.ToInt32(input[2]);
            }
            else if ("/".Contains(input[1]))
            {
                outcome = Convert.ToInt32(input[0]) /Convert.ToInt32(input[2]);
            }
            MessageBox.Show(outcome.ToString());
        }
    }
}