namespace homework_language
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btntranslate_Click(object sender, EventArgs e)
        {
            var length = txtenglish.Text.Length;
            double outcome = length / 2;
            double first = Math.Floor(outcome);
            var point = Convert.ToInt32(first);
            var second = first;
            var result = txtenglish.Text.Substring(Convert.ToInt32(second)) + txtenglish.Text.Substring(0, point);
            MessageBox.Show(result);
        }
    }
}