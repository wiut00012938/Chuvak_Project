using System.Xml.Schema;

namespace numerology
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

        private void button1_Click(object sender, EventArgs e)
        {
            var input = tbtInput.Text;
            DateTime result;
            if (DateTime.TryParse(input, out result))
            {
                DateTime dob = Convert.ToDateTime(input);
                int number = (dob.Year + dob.Month + dob.Day);
                while (number > 9)
                {
                    int sumOfDigits = 0;
                    while (number > 0)
                    {
                        int LastDigit = number % 10;
                        sumOfDigits += LastDigit;
                        number = number / 10;
                    }
                    number = sumOfDigits;
                }
                string personType;
                switch (number)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        personType = "vampire";
                        break;
                    case 5:
                    case 6:
                    case 7:
                        personType = "neutral";
                        break;
                    default:
                        personType = "angel";
                        break;
                }
                MessageBox.Show(number.ToString(), personType.ToString());
            }
            else
            {
                MessageBox.Show("You haven't entered date type.Please try one more time");
            }
        }
    }
}