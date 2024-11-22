namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e) // A timer for the brogress bar to run.
        {
            label3.Text = progressBar1.Value.ToString();
            label3.Text += " %";
            this.progressBar1.Increment(1);
            Cursor = Cursors.AppStarting;


            switch (progressBar1.Value)
            {
                case 25: label2.Visible = true; break;
                case 75: label4.Visible = true; break;
                case 100: button1.Enabled = true; break;

            }
            if (progressBar1.Value == 100)
            {
                Cursor = Cursors.Default;
                label3.Text = progressBar1.Value.ToString();
                label3.Text += " %";
                timer1.Stop();
            }


        }

        private void button1_Click(object sender, EventArgs e) // This button proceeds to the next form.
        {
            mainForm mainForm = new mainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e) // Mouse enter to this button trigger some effects.
        {
            if (button1.Enabled)
            {
                Cursor = Cursors.Hand;
            }
            else
                Cursor = Cursors.WaitCursor;
        }

        private void button1_MouseLeave(object sender, EventArgs e) // Mouse leave this button trigger some effects.
        {
            if (button1.Enabled)
            {
                Cursor = Cursors.Default;
            }
            else
                Cursor = Cursors.AppStarting;
        }

        // Accidentally provoked functions.

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}