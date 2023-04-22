namespace TimeParsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = tbxinput.Text;
            DateTime time;
            if (DateTime.TryParse(input, out time))
            {
                var separated = input.Split(":");
                var seconds = 0;
                if (separated.Length == 1)
                {
                    seconds = Convert.ToInt32(separated[0]);
                }
                else if (separated.Length == 2)
                {
                    seconds = Convert.ToInt32(separated[0]) * 60 + Convert.ToInt32(separated[1]);
                }
                else {
                    seconds = Convert.ToInt32(separated[0]) * 60*60 + Convert.ToInt32(separated[1]) * 60 + Convert.ToInt32(separated[2]);
                }
                MessageBox.Show(seconds.ToString());
            }
            else
            {
                MessageBox.Show("Enter valid format");
            }

        }
    }
}