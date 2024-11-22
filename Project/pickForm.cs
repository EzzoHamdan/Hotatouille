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
    public partial class pickForm : Form
    {
        public pickForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("Cheap");
            comboBox1.Items.Add("Normal");
            comboBox1.Items.Add("Expensive");
        }

        private void button5_Click(object sender, EventArgs e) //button5_Click: Controls visibility based on choice selection.
        {
            int index = comboBox1.Items.Count;
            string choice = "";
            for (int i = 0; i < index; i++)
            {
                if (comboBox1.SelectedIndex == i)
                    choice = comboBox1.Text;
            }

            if (choice.Equals("Cheap"))
            {
                groupBox10.Visible = true;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
            }
            else if (choice.Equals("Normal"))
            {
                groupBox10.Visible = false;
                groupBox11.Visible = true;
                groupBox12.Visible = false;
            }
            else
            {
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = true;
            }

        }

        private void button5_MouseEnter(object sender, EventArgs e) // button5_MouseEnter: Changes appearance and displays tooltip on mouse enter.
        {
            button5.ForeColor = Color.White;
            button5.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button5, "Click to see the results!");
        }

        private void button5_MouseLeave(object sender, EventArgs e) // button5_MouseLeave: Restores default appearance on mouse leave.
        {
            button5.ForeColor = Color.Orange;
            button5.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button4_MouseEnter(object sender, EventArgs e) // button4_MouseEnter: Changes appearance and displays tooltip on mouse enter.
        {
            button4.ForeColor = Color.White;
            button4.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button4, "Click to book your accommodation!");

        }

        private void button4_MouseLeave(object sender, EventArgs e) // button4_MouseLeave: Restores default appearance on mouse leave.
        {
            button4.ForeColor = Color.Orange;
            button4.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button1_MouseEnter(object sender, EventArgs e) // button1_MouseEnter: Changes appearance and displays tooltip on mouse enter.
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button1, "Click to book your accommodation!");
        }

        private void button1_MouseLeave(object sender, EventArgs e) // button1_MouseLeave: Restores default appearance on mouse leave.
        {
            button1.ForeColor = Color.Orange;
            button1.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button3_MouseEnter(object sender, EventArgs e) // button3_MouseEnter: Changes appearance and displays tooltip on mouse enter.
        {
            button3.ForeColor = Color.White;
            button3.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button3, "Click to book your accommodation!"); // button3_MouseLeave: Restores default appearance on mouse leave.
        }

        private void button3_MouseLeave(object sender, EventArgs e) // button6_MouseEnter: Changes appearance and displays tooltip on mouse enter.                                                                    
        {
            button3.ForeColor = Color.Orange;
            button3.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button6_MouseEnter(object sender, EventArgs e) // button6_MouseLeave: Restores default appearance on mouse leave.
        {
            button6.ForeColor = Color.White;
            button6.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button6, "Click to book your accommodation!");
        }

        private void button6_MouseLeave(object sender, EventArgs e) // button7_MouseEnter: Changes appearance and displays tooltip on mouse enter.
        {
            button6.ForeColor = Color.Orange;
            button6.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button7_MouseEnter(object sender, EventArgs e) // button7_MouseLeave: Restores default appearance on mouse leave.
        {
            button7.ForeColor = Color.White;
            button7.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button5, "Click to book your accommodation!");
        }

        private void button7_MouseLeave(object sender, EventArgs e) // button8_MouseEnter: Changes appearance and displays tooltip on mouse enter.
        {
            button7.ForeColor = Color.Orange;
            button7.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button8_MouseEnter(object sender, EventArgs e) // button8_MouseLeave: Restores default appearance on mouse leave.                                                                                                                                
        {
            button8.ForeColor = Color.White;
            button8.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button8, "Click to book your accommodation!");
        }

        private void button8_MouseLeave(object sender, EventArgs e) // button9_MouseEnter: Changes appearance and displays tooltip on mouse enter.
        {
            button8.ForeColor = Color.Orange;
            button8.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button9_MouseEnter(object sender, EventArgs e) // button9_MouseLeave: Restores default appearance on mouse leave.                                                                    
        {
            button9.ForeColor = Color.White;
            button9.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button9, "Click to book your accommodation!");
        }

        private void button9_MouseLeave(object sender, EventArgs e) // button10_MouseEnter: Changes appearance and displays tooltip on mouse enter.
                                                                    
        {
            button9.ForeColor = Color.Orange;
            button9.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button10_MouseEnter(object sender, EventArgs e) // button10_MouseLeave: Restores default appearance on mouse leave.                                                                    
        {
            button10.ForeColor = Color.White;
            button10.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button10, "Click to book your accommodation!");
        }

        private void button10_MouseLeave(object sender, EventArgs e) // button11_MouseEnter: Changes appearance and displays tooltip on mouse enter.
        {
            button10.ForeColor = Color.Orange;
            button10.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button11_MouseEnter(object sender, EventArgs e) // button11_MouseLeave: Restores default appearance on mouse leave.
                                                                     
        {
            button11.ForeColor = Color.White;
            button11.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button11, "Click to book your accommodation!"); // button11_MouseLeave: Restores default appearance on mouse leave.
        }

        private void button11_MouseLeave(object sender, EventArgs e) 
        {
            button11.ForeColor = Color.Orange;
            button11.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e) // pictureBox3_MouseEnter: Changes appearance on mouse enter.

        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void panel1_MouseEnter(object sender, EventArgs e) // panel1_MouseEnter: Changes appearance on mouse enter.
        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void panel1_MouseLeave(object sender, EventArgs e) // panel1_MouseLeave: Restores default appearance on mouse leave.
                                                                   
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e) // pictureBox3_MouseLeave: Restores default appearance on mouse leave.
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_MouseLeave(object sender, EventArgs e) // button2_MouseLeave: Restores default appearance on mouse leave.                                                                   

        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox3_Click(object sender, EventArgs e)  // pictureBox3_Click: Closes the form.
                                                                  
        {
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e) // button2_MouseEnter: Changes appearance on mouse enter.
        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void button2_Click(object sender, EventArgs e)// button2_Click: Closes the form.
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)// Opens checkForm with specific parameters.      
        {
            checkForm checkForm = new checkForm(groupBox7.Text, label8.Text);
            checkForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)// Opens checkForm with specific parameters.      
        {
            checkForm checkForm = new checkForm(groupBox8.Text, label9.Text);
            checkForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)// Opens checkForm with specific parameters.      
        {
            checkForm checkForm = new checkForm(groupBox9.Text, label10.Text);
            checkForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)// Opens checkForm with specific parameters.      
        {
            checkForm checkForm = new checkForm(groupBox4.Text, label2.Text);
            checkForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)// Opens checkForm with specific parameters.      
        {
            checkForm checkForm = new checkForm(groupBox5.Text, label4.Text);
            checkForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)// Opens checkForm with specific parameters.      
        {
            checkForm checkForm = new checkForm(groupBox6.Text, label6.Text);
            checkForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)// Opens checkForm with specific parameters.      
        {
            checkForm checkForm = new checkForm(groupBox1.Text, label7.Text);
            checkForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)// Opens checkForm with specific parameters.      
        {
            checkForm checkForm = new checkForm(groupBox2.Text, label3.Text); 
            checkForm.Show();
        }

        private void button3_Click(object sender, EventArgs e) // Opens checkForm with specific parameters.                                                              
        {
            checkForm checkForm = new checkForm(groupBox3.Text, label5.Text);
            checkForm.Show();
        }

        // 

        private void pickForm_Load(object sender, EventArgs e)                                                  
        {

        }
    }
}

