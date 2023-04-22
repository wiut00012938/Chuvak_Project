namespace conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private int input;
        private string name;
        private void btnInch_Click(object sender, EventArgs e)
        {
            
            var result = input / 0.0254;
            input = Convert.ToInt32(tbxInput.Text);
            name = "Abdulaziz's";
            MessageBox.Show(result.ToString(),name);
        }

        private void btnMile_Click(object sender, EventArgs e)
        {
            var result = input / 1610.0 ;
            MessageBox.Show(result.ToString(), name);
        }

        private void btnFeet_Click(object sender, EventArgs e)
        {
            var result = input / 0.3048;
            MessageBox.Show(result.ToString(), name);
        }
    }
       
}