namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = Convert.ToInt32(tbxInput.Text);
            var circumferace = 2 * Math.PI * input;
            var area = Math.PI * Math.Pow(input, 2);
            var message = $@"The radius that you entered - {input:N2}
The circumferance of the given circle - {circumferace:N2}
The area of the given circle - {area:N2}";
            MessageBox.Show(message);
        }
    }
}