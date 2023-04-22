using System.CodeDom;
using System.DirectoryServices.ActiveDirectory;

namespace sample_sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            var input = tbxInput.Text.Split(",;: ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var new_input = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (IsNumeric(input[i])){
                    new_input[i] = Convert.ToInt32(input[i]);
                }
                else
                {
                    MessageBox.Show("Fuck you");
                    return;
                }
            }
            var haveChanges = true;
            while (haveChanges)
            {
                haveChanges = false;
                for (int i = 0; i < input.Length -1; i++)
                {
                    if (new_input[i] > new_input[i + 1])
                    {
                        Swap(ref new_input[i], ref new_input[i + 1]);
                        haveChanges = true;
                    }
                }
            }
            var final = string.Join(",", new_input);
            Message(final);
        }
        private bool IsNumeric(string text)
        {
        return double.TryParse(text, out _);
        }

        private void Swap(ref int a, ref int b)
        {
            var c = a;
            a = b;
            b = c;
        }
        private void Message(string text)
        {
            MessageBox.Show(text, "Abdulaziz's");
        }
    }
}