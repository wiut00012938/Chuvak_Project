namespace seminar5_homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            var a = tbx1.Text.Split(";:, ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var b = tbx2.Text.Split(";:, ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var lengthOfC = a.Length + b.Length;
            var c = new string[lengthOfC];
            var currentIndex = 0; //the index to add new element to the resulting array

            foreach(var element in a)
            {
                if (!c.Contains(element))
                {
                    c[currentIndex] = element;
                    currentIndex++;
                }
            }
            foreach(var element in b)
            {
                if (!c.Contains(element))
                {
                    c[currentIndex] = element;
                    currentIndex++;
                }
            }
            Array.Resize(ref c, currentIndex);

            Array.Sort(c);
            var message = string.Join(", ", c);
            MessageBox.Show(message);
        }
    }
}