using System.Media;

namespace LeapYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            var year = numyear.Value;
            bool isLeap;
            if (year > 1952)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            isLeap = true;
                        }
                        else
                        {
                            isLeap = false;
                        }
                    }
                    else
                    {
                        isLeap = false;
                    }
                }
                else
                {
                    isLeap = false;
                }
            }
            else
            {
                isLeap = false;
            }

            if (isLeap)
            {
                MessageBox.Show("It is a leap year");
            }
            else
            {
                MessageBox.Show("It is not a leap year");
            }
        }
    }
}