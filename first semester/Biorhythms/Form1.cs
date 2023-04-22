namespace Biorhythms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            var physical = 23;
            var emotional = 28;
            var intellectual = 33;
            DateTime date1 = Convert.ToDateTime(firstDate.Value);
            DateTime date2 = Convert.ToDateTime(secondDate.Value);
            TimeSpan distance = date1.Subtract(date2);
            var constanta = distance.TotalDays;
            if (constanta < 0)
            {
                constanta = constanta * (-1);
            }
            var physical_remainder = Convert.ToDouble(constanta) % physical;
            var emotional_remainder = Convert.ToDouble(constanta) % emotional;
            var intellectual_remainder = Convert.ToDouble(constanta) % intellectual;
            var physical_mismatch = (physical_remainder / 23) * 100;
            var emotional_mismatch = (emotional_remainder / 28) * 100;
            var intellectual_mismatch = (intellectual_remainder / 28) * 100;
            var physical_compatibility = 100 - physical_mismatch;
            var emotional_compatibility = 100 - emotional_mismatch;
            var intellectual_compatibility = 100 - intellectual_mismatch;
            var message = $@"Considering the follwing dates, here are the following results:
physical mismatch: {physical_mismatch:N2}, while physical compatibily is - {physical_compatibility:N2}
emotional mismatch: {emotional_mismatch:N2}, while emotional compatibilit is - {emotional_compatibility:N2}
intellectual mismatch: {intellectual_mismatch:N2}, while intellectual compatibility is - {intellectual_compatibility:N2}";
            MessageBox.Show(message, "Abdulaziz's");
        }

        private void firstDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}