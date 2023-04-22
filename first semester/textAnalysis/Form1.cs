namespace textAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            var input = tbxinput.Text;
            var numberOfVowels = 0;
            var numberOfWords = 1;
            var numberofConsonants = 0;
            input = input.Trim();
            if (input == "")
            {
                numberOfWords = 0;
            }
            input = input.ToLower();

            while (input.Contains("  "))
            {
                input = input.Replace("  ", " ");
            }
            foreach(var word in input)
            {
                if ("aeiuo".Contains(word))
                {
                    numberOfVowels++;
                }
                else if ("bcdfghjklmnpqrstvwxyz".Contains(word))
                {
                    numberofConsonants++;
                }
                else if (" ".Contains(word))
                {
                    numberOfWords++;
                }
            }
            var message = $@"
                number of vowels: {numberOfVowels}
                number of consonants: {numberofConsonants}
number of words: {numberOfWords}";
            MessageBox.Show(message.ToString());

        }
    }
}