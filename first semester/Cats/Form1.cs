namespace Cats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            var b = 0.0;
            var h = 0.0;
            var a = 0.0;
            if (sleeping.Checked)
                b = 5;
            if (playing.Checked)
                b = 3.8;
            if (lying.Checked)
                b = 1.2;
            if (long_haired.Checked)
                h = 3.5;
            if (short_haired.Checked)
                h = 1.3;
            if (old.Checked)
                a = 0.1;
            if (young.Checked)
                a = 0.9;
            var result = 1 + ((b + 0.84 * h) / (1 - a));
            MessageBox.Show(result.ToString());

        }
    }
}