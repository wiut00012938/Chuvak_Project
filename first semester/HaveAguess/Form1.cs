namespace HaveAguess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ComputerNumber;
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            var usernumber = numguess.Value;
            if(usernumber > ComputerNumber)
            {
                MessageBox.Show("Too high");
            }
            else if (usernumber < ComputerNumber)
            {
                MessageBox.Show("Too low");
            }
            else
            {
                MessageBox.Show("Bingo!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var random = new Random();
            ComputerNumber = random.Next(0, 100);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}