namespace seminar4_homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnroot_Click(object sender, EventArgs e)
        {
            var number = Convert.ToDouble(numinput.Value);
            var root = 1.00;
            while( Math.Abs(root*root - number) > 0.01)
            {
                root = (root + (number / root)) / 2;
            }
            MessageBox.Show("Square root is " + Math.Sqrt(number) + "\nGuess is " + root);
        }
    }
}