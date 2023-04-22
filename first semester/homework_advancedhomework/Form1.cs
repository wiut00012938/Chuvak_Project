using System.Diagnostics;

namespace homework_advancedhomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtnum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            var first_number = Convert.ToDouble(txtnum1.Text);
            var second_number = Convert.ToDouble(txtnum2.Text);
            var result = first_number + second_number;
            var show = MessageBox.Show(result.ToString());
            
        }
    }
}