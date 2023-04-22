namespace practice_classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var home_team = txthome.Text;
            var away_team = txtaway.Text;
            var home_score = numscoreaway.Value;
            var away_score = numscoreaway.Value;
            var home_points = 0;
            var away_points = 0;
            if (home_score > away_score)
            {
                home_points += 3;
            }
            else
            {
                away_points += 3;
            }
            var message = $@"Latest Result



{home_team}:{home_score}, {away_team}:{away_score}

{home_team}: {home_points} points
{away_team}: {away_points} points";
            MessageBox.Show(message);
        }
    }
}