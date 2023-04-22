namespace Grades_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            var input = Math.Round(numinput.Value, 0);
            var mark = "";
            if (input == 0)
                mark = "F";
            else if (input == 1)
                mark = "D";
            else if (input == 2)
                mark = "C";
            else if (input == 3)
                mark = "B";
            else if (input == 4)
                mark = "A";
            else
            {
                MessageBox.Show("You entered your mark wrongly");
            }
            MessageBox.Show($"your mark that is converted to the new system is: {mark}");
        }
    }
}