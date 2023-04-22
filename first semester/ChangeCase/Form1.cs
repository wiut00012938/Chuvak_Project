namespace ChangeCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var text = tbxInput.Text;
            var input = text.Split();
            string init = string.Join("", input);
            MessageBox.Show(text);
            var converted = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    converted[i] = input[i].ToUpper();
                }
                else if (input[i] == " ")
                {
                    converted[i] = input[i];
                }
                else if (i == 1 || i == 2)
                {
                    converted[i] = input[i].ToLower();
                }
                else if (".!?".Contains(input[i - 2]) || ".?!".Contains(input[i - 1]))
                {
                    converted[i] = input[i].ToUpper();
                }
                else
                {
                    converted[i] = input[i].ToLower();
                }
            }
            string message = string.Join("",converted);
            MessageBox.Show(message);
        }
    }
}