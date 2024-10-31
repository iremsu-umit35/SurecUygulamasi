namespace SurecUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10; //deðeri artýrma iþlemi
            if (progressBar2.Value % 20 == 10)
            {
                label2.BackColor = Color.HotPink;
            }
            if (progressBar2.Value % 20 == 0)
            {

                label2.BackColor = Color.Yellow;
            }


            // süreç bitince timerý durdurma iþlemi
            if (progressBar2.Value == 100)
            {
                Timer1.Stop();
                Timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 5;

            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.HotPink;
            }
            if (progressBar3.Value % 20 == 0)
            {

                label3.BackColor = Color.Yellow;
            }

            if (progressBar3.Value == 100)
            {
                Timer2.Stop();
                Timer3.Start();
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 10;

            if (progressBar4.Value % 20 == 10)
            {
                label4.BackColor = Color.HotPink;
            }
            if (progressBar4.Value % 20 == 0)
            {
                label4.BackColor = Color.Yellow;
            }
            if (progressBar4.Value == 100)
            {
                Timer3.Stop();
                Timer4.Start();
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            progressBar5.Value += 1;

            if (progressBar5.Value % 2 == 0)
            {
                label5.BackColor = Color.HotPink;
            }
            if (progressBar5.Value % 2 == 1)
            {
                label5.BackColor = Color.Yellow;
            }
            if (progressBar5.Value == 100)
            {
                Timer4.Stop();
                MessageBox.Show("PASTAMIZ HAZIR OLDU  :)");
            }

        }
    }
}
