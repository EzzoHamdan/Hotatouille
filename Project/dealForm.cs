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
    public partial class dealForm : Form
    {
        public dealForm()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button1, "Click to book your accommodation!");
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
            button3.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button3, "Click to book your accommodation!");
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
            button4.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button4, "Click to book your accommodation!");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Orange;
            button1.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Orange;
            button3.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Orange;
            button4.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkForm checkForm = new checkForm(groupBox1.Text, "The Price " + label11.Text);
            checkForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkForm checkForm = new checkForm(groupBox2.Text, "The Price " + label10.Text);
            checkForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkForm checkForm = new checkForm(groupBox3.Text, "The Price " + label9.Text);
            checkForm.Show();
        }
    }
}
