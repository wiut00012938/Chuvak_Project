namespace showdigits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = Convert.ToInt32(txtinput.Text);
            var result = "";
            while (input > 0)
            {
                var lastdigit = input % 10;
                result += lastdigit + "\n";
                input = input / 10;
            }
            MessageBox.Show(result.ToString());
        }
    }
}