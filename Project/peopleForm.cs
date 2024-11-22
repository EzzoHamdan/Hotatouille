using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class peopleForm : Form
    {
        public peopleForm()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e) // Mouse enter button named "Book now!" trigger some effects.
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button1, "Click to book your accommodation!");
        }

        private void button2_MouseHover(object sender, EventArgs e) // Mouse hover button that carries a triangle shape trigger some effects.
        {

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button2, "Back to Main Page");
        }

        private void button2_Click(object sender, EventArgs e) // Mouse clicl button that carries a triangle shape closes the current form.
        {
            this.Close();
        }

        private void button1_MouseLeave(object sender, EventArgs e) // Mouse leave button named "Book now!" trigger some effects.
        {
            button1.ForeColor = Color.Orange;
            button1.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e) // Mouse hover picture box that carries the icon trigger some effects.
        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void panel1_MouseEnter(object sender, EventArgs e) // Mouse enter button that carries a triangle shape trigger some effects.
        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void panel1_MouseLeave(object sender, EventArgs e) // Mouse leave button named "Book now!" trigger some effects.
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e) // Mouse leave picture box that carries the icon trigger some effects.
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_MouseLeave(object sender, EventArgs e) // Mouse leave button that carries the icon trigger some effects.
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Mouse clicl picture box that carries the icon closes the current form.
        {
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e) // Mouse enter that carries the icon trigger some effects.
        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void button1_Click(object sender, EventArgs e) // Mouse click picture box that carries the icon trigger some effects.
        {
            checkForm checkForm = new checkForm(label5.Text, " The Price is: 99.99$ ");
            checkForm.Show();
        }

        // Accidentally provoked functions

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {

        }

    }
}
