namespace bugger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int LetterCount = 0;
            string strText = "Debugging";
            string letter;


            for (int i = 0; i < strText.Length; i++)
            {
                letter = strText.Substring(i, 1);

                if (letter == "g")
                {
                    LetterCount++;
                }

            }
            MessageBox.Show("G appears " + LetterCount + " times");

        }
    }
}