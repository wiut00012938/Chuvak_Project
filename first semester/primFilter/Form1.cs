namespace primFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var convertedInput = new int[input.Length];
            for(int i = 0; i < convertedInput.Length; i++)
            {
                if (isNumeric(input[i]))
                {
                    convertedInput[i] = Convert.ToInt32(input[i]);
                }
                else
                {
                    MessageBox.Show("Enter only integers");
                    return;
                }
            }
            var finalarray = new List<int>();
            for (int i = 0; i < convertedInput.Length; i++)
            {
                if (convertedInput[i] % 2 != 0)
                {
                    finalarray.Add(convertedInput[i]);
                }
            }
            var final = finalarray.ToArray();
            string message = string.Join(", ", final);
            MessageBox.Show("Prime numbers from you entered numbers are:" + message);
        }
        private bool isNumeric(string text)
        {
            int pattern;
            return int.TryParse(text, out pattern);
        }
    }
}