namespace CruelGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (rdless21.Checked)
            {
                MessageBox.Show("You're too yound for this cruel game, go play minecraft dude");
            }
            else if (rdbetween21and35.Checked)
            {
                MessageBox.Show("Great!Have a nice game");
            }
            else
            {
                MessageBox.Show("Your're too old grandpa");
            }
        }
    }
}