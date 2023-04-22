using Microsoft.VisualBasic;

namespace The_sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long sum = 0;
            for (int i = 2; i <=1000000; i+=2)
            {
                sum += i;
            }
            MessageBox.Show(sum.ToString());
        }

        private void btn_odd_Click(object sender, EventArgs e)
        {
            long sum = 0;
            for (int i = 1; i <1000000; i += 2)
            {
                sum += i;
            }
            MessageBox.Show(sum.ToString());
        }
    }
}