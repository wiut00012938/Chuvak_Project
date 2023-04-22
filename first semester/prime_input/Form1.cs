namespace prime_input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            var number = txtguess.Text;
            int result;
            if(int.TryParse(number, out result))
            {
                bool prime = true;
                var input = Convert.ToInt32(number);
                for (int i = 2; i < input; i++)
                {
                    if(input % i == 0)
                    {
                        prime = false;
                        break;
                    }
                    else
                    {
                        prime = true;
                        break;
                    }
                }
                if (prime)
                {
                    MessageBox.Show("This is a prime number");
                }
                else
                {
                    MessageBox.Show("This is not a prime number");
                }
            }
            else
            {
                MessageBox.Show("This is not an integer number, Please intput right number");
            }
        }
    }
}