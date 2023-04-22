using System.Net;

namespace seminar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Goodbye, cruel world");
            //e.Cancel = true;
        }

        private void btnshow1_Click(object sender, EventArgs e)
        {
            lblshow.Text = "Hello " + txtbox.Text + ". How are you doing?";
        }

        private void btnshow2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {

        }
    }
}