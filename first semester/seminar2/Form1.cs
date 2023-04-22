namespace seminar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is investment calculator");
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            var name = txtname.Text;
            var surname = txtsurname.Text;
            var amount = numamount.Value;
            var interest = numinterest.Value;
            var durability = numdurability.Value;
            var result = amount + durability * interest * amount / 100;
            //MessageBox.Show("Name of investor: " + name + "\n" + "Surname of investor: " + surname + "\n" + "Amount of investment: " + amount + "\n" + "Interest rate: " + interest + "\n" + "Your amount of money in the bank after " + durability + " years will be: $" + Math.Round(result, 2));
            var message = "";
            message += "Name of investor: " + name + "\n";
            message += "Surname of investor: " + surname + "\n";
            message += "Amount of investment: " + amount + "\n";
            message += "Interest rate: " + interest + "\n";
            message += "Your amount of money in the bank after " + durability + " years will be: $" + Math.Round(result, 2);
        }
    }
}