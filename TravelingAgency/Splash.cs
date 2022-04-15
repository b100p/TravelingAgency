namespace TravelingAgency
{
    public partial class Splash : masterForm
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar1.Value = startpoint;
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Value = 0;
                Login login = new();
                login.Show();
                Hide();
            }
        }
    }
}