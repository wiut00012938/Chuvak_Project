namespace seminar5_statistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //getting the numbers from the input
            var marks = txtmarks.Text.Split(",; ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            //variables to collect and display
            var noOfMarksLess30 = 0;
            var noOfMarksFrom30To40 = 0;
            var noOfMarksFrom40To50 = 0;
            var noOfMarksFrom50To60 = 0;
            var noOfMarksFrom60To70 = 0;
            var noOfMarksMoreThan70 = 0;

            //processing each mark
            foreach (var element in marks)
            {
                var mark = Convert.ToInt32(element);
                if (mark < 30)
                {
                    noOfMarksLess30++;
                }
                else if (mark < 40)
                {
                    noOfMarksFrom30To40++;
                }
                else if (mark < 50)
                {
                    noOfMarksFrom40To50++;
                }
                else if (mark < 60)
                {
                    noOfMarksFrom50To60++;
                }
                else if (mark < 70)
                {
                    noOfMarksFrom60To70++;
                }
                else
                {
                    noOfMarksMoreThan70++;
                }
            }
            var message =
                $@"less than 30: {noOfMarksLess30}
between 30 and 40: {noOfMarksFrom30To40}
between 40 and 50: {noOfMarksFrom40To50}
between 50 and 60: {noOfMarksFrom50To60}
between 60 and 70: {noOfMarksFrom60To70}
70+: {noOfMarksMoreThan70}";
            MessageBox.Show(message);
        }
    }
}