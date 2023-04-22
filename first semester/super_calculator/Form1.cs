namespace super_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var first_number = tbxFirstNumber.Text;
            var second_number = TbxSecondNumber.Text;
            var first_aggregated = 0;
            var second_aggregated = 0;

            if (first_number == "zero")
            {
                first_aggregated = 0;
            }
            else if (first_number == "one")
            {
                first_aggregated++;
            }
            else if (first_number == "two")
            {
                first_aggregated+=2;
            }
            else if (first_number == "thee")
            {
                first_aggregated+=3;
            }
            else if (first_number == "four")
            {
                first_aggregated+=4;
            }
            else if (first_number == "five")
            {
                first_aggregated+=5;
            }
            else if (first_number == "six")
            {
                first_aggregated+=6;
            }
            else if (first_number == "seven")
            {
                first_aggregated+=7;
            }
            else if (first_number == "eight")
            {
                first_aggregated+=8;
            }
            else if (first_number == "nine")
            {
                first_aggregated+=9;
            }
            else
            {
                MessageBox.Show("you entered the first number incorrecty");
            }


            if (second_number == "zero")
            {
                second_aggregated = 0;
            }
            else if (second_number == "one")
            {
                second_aggregated++;
            }
            else if (second_number == "two")
            {
                second_aggregated += 2;
            }
            else if (second_number == "thee")
            {
                second_aggregated += 3;
            }
            else if (second_number == "four")
            {
                second_aggregated += 4;
            }
            else if (second_number == "five")
            {
                second_aggregated += 5;
            }
            else if (second_number == "six")
            {
                second_aggregated += 6;
            }
            else if (second_number == "seven")
            {
                second_aggregated += 7;
            }
            else if (second_number == "eight")
            {
                second_aggregated += 8;
            }
            else if (second_number == "nine")
            {
                second_aggregated += 9;
            }
            else
            {
                MessageBox.Show("you entered the second number incorrecty");
            }

            var result = first_aggregated + second_aggregated;
            MessageBox.Show(result.ToString());
        }
    }
}