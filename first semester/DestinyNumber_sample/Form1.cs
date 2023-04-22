namespace DestinyNumber_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            var number = tbxInput.Text.Split("/;:, ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var init = 0;
            foreach (var item in number)
            {
                var unit = Convert.ToInt32(item);
                while (unit > 0)
                {
                    init += unit % 10;
                    unit /= 10;
                }
            }
            var final = 0;
            while (init > 0){
                final += init %10;
                init /= 10;
            }
            MessageBox.Show(final.ToString());
        }
    }
}