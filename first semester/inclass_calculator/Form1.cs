namespace inclass_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var first_number = tbxfirst.Text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var second_number = tbxsecond.Text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> numberTable = new Dictionary<string, int>{
        {"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},{"five",5},{"six",6},
        {"seven",7},{"eight",8},{"nine",9},{"ten",10},{"eleven",11},{"twelve",12},
        {"thirteen",13},{"fourteen",14},{"fifteen",15},{"sixteen",16},{"seventeen",17},
        {"eighteen",18},{"nineteen",19},{"twenty",20},{"thirty",30},{"forty",40},
        {"fifty",50},{"sixty",60},{"seventy",70},{"eighty",80},{"ninety",90},
        {"hundred",100},{"thousand",1000},{"lakh",100000},{"million",1000000},
        {"billion",1000000000}};
            var acc1 = 0;
            var total1 = 0;
            var gg1 = new int[5];
            var i = 0;
            foreach (var number in first_number)
            {
                if (numberTable.ContainsKey(number))
                {
                    gg1[i] = numberTable[number];
                    i++;
                }
            }
            MessageBox.Show(gg1[0].ToString());
        }
    }
}