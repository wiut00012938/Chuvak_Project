namespace Kaa_Language
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;
            var new_input = new string[100];
            var i = 0;
            foreach (char item in input)
            {
                var unit = Convert.ToString(item);
                if ("aeoui".Contains(unit))
                {
                    new_input[i] += unit + "akka";
                }
                else
                {
                    new_input[i] += unit;
                }
                i++;
            }
            string result = string.Join("", new_input);
            MessageBox.Show(result);
        }
    }
}