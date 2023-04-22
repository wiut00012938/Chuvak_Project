namespace mirrored_arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var a = tbxinput.Text.Split(",:; ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var b = new string[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[a.Length - 1 - i];
            }

            var message = "";
            for(int i = 0; i < b.Length; i++)
            {
                message += a[i] + "=>" + b[i] + "\n";
            }
            MessageBox.Show(message);
        }
    }
}