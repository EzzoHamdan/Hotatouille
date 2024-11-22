using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class mainForm : Form
    {
        public mainForm()
        {

            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e) // Mouse enter button named "Book" trigger some effects.
        {
            panel3.Visible = true;
            button1.ForeColor = Color.White;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button1, "Click to book your accommodation!");
        }

        private void button2_MouseEnter(object sender, EventArgs e) // Mouse enter button named "Deals" trigger some effects.
        {
            panel4.Visible = true;
            button2.ForeColor = Color.White;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button2, "Click to see the best offers!");
        }

        private void button3_MouseEnter(object sender, EventArgs e) // Mouse enter button named "Our critics" trigger some effects.
        {
            panel5.Visible = true;
            button3.ForeColor = Color.White;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button3, "Click to learn more about our critics and their recommendations!");
        }

        private void button4_MouseEnter(object sender, EventArgs e) // Mouse enter button named "Our clients" trigger some effects.
        {
            panel6.Visible = true;
            button4.ForeColor = Color.White;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button4, "Your opinions are our opinions! Click to learn more!");
        }

        private void button5_MouseEnter(object sender, EventArgs e) // Mouse enter button named "About us" trigger some effects.
        {
            panel7.Visible = true;
            button5.ForeColor = Color.White;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button5, "Get to know us more!");
        }

        private void button6_MouseEnter(object sender, EventArgs e) // Mouse enter button named "Exit" trigger some effects.
        {
            panel8.Visible = true;
            button6.ForeColor = Color.White;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button6, "Exit The Program!");
        }

        private void button1_MouseLeave(object sender, EventArgs e) // Mouse leave button named "Book" trigger some effects.
        {
            panel3.Visible = false;
            button1.ForeColor = Color.Orange;
        }

        private void button2_MouseLeave(object sender, EventArgs e) // Mouse leave button named "Deals" trigger some effects.
        {
            panel4.Visible = false;
            button2.ForeColor = Color.Orange;
        }

        private void button3_MouseLeave(object sender, EventArgs e) // Mouse leave button named "Our critics" trigger some effects.
        {
            panel5.Visible = false;
            button3.ForeColor = Color.Orange;
        }

        private void button4_MouseLeave(object sender, EventArgs e) // Mouse leave button named "Our clients" trigger some effects.
        {
            panel6.Visible = false;
            button4.ForeColor = Color.Orange;
        }

        private void button5_MouseLeave(object sender, EventArgs e) // Mouse leave button named "About us" trigger some effects.
        {
            panel7.Visible = false;
            button5.ForeColor = Color.Orange;
        }

        private void button6_MouseLeave(object sender, EventArgs e) // Mouse leave button named "Exit" trigger some effects.
        {
            panel8.Visible = false;
            button6.ForeColor = Color.Orange;
        }

        private void groupBox1_MouseHover(object sender, EventArgs e) // Mouse hover Group box named "Hotatouille critics' weekly recommendation" trigger some effects.
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(groupBox1, "Hotatouille critics' weekly recommendation!");
        }

        private void groupBox2_MouseHover(object sender, EventArgs e) // Mouse hover group box named "People's choice of the day" trigger some effects.
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(groupBox2, "People's choice of the day!"); 
        }

        private void button3_Click(object sender, EventArgs e) // This button named "Our critics" proceeds to its form.
        {
            criticForm criticForm = new criticForm();
            criticForm.Show();
        }

        private void button4_Click(object sender, EventArgs e) // This button named "Our clients" proceeds to its form.
        {
            peopleForm peopleForm = new peopleForm();
            peopleForm.Show();
        }

        private void button6_Click(object sender, EventArgs e) // This button named "Exit" ends the application run.
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("By clicking on OK, you will close the program. Any data you entered without submitting it will be lost.", "Exit Program!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK) { Application.Exit(); }
        }

        private void button5_Click(object sender, EventArgs e) // This button named "About us" proceeds to its form.
        {
            detailForm detailForm = new detailForm();
            detailForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) // This button named "Deals" proceeds to its form.
        {
            dealForm dealForm = new dealForm();
            dealForm.Show();
        }

        private void button1_Click(object sender, EventArgs e) // This button named "Book" proceeds to its form.
        {
            pickForm pickForm = new pickForm();
            pickForm.Show();
        }

        //Accidentally provoked functions

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
