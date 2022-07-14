using System.Globalization;
namespace Digital_Clock
{
    public partial class Clock : Form
    {
        string lang = "BR";
        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            Horario.Text = DateTime.Now.ToString("HH:mm:ss");
            Data.Text = DateTime.Now.ToString("D");
            Meridium.Text = "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lang == "BR")
            {
                Horario.Text = DateTime.Now.ToString("HH:mm:ss");
                Data.Text = DateTime.Now.ToString("D");
            }
            else if (lang == "EN")
            {
                Horario.Text = DateTime.Now.ToString("hh:mm:ss", CultureInfo.InvariantCulture);
                Data.Text = DateTime.Now.ToString("D", CultureInfo.InvariantCulture);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lang = "BR";
            Horario.Text = DateTime.Now.ToString("HH:mm:ss");
            Data.Text = DateTime.Now.ToString("D");
            Meridium.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lang = "EN";
            Horario.Text = DateTime.Now.ToString("hh:mm:ss", CultureInfo.InvariantCulture);
            Data.Text = DateTime.Now.ToString("D", CultureInfo.InvariantCulture);
            Meridium.Text = DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
        }

    }
}