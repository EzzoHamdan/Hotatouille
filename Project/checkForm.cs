using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class checkForm : Form // some parameters, attributes and other neccessary declarations
    {

        Boolean para1 = false, para2 = false, para3 = false, para4 = false, para5 = false;
        Boolean newPara1 = false, newPara2 = false, newPara3 = false;
        Boolean invoicePara = false;
        double doublePrice;
        string hotelName, price, stay;
        public checkForm(string hotelName, string price)
        {
            InitializeComponent();
            this.hotelName = hotelName;
            this.price = price;


            string pattern = "[A-Za-z]";
            string noLetterPrice = Regex.Replace(price, pattern, "");
            string noCharPrice = noLetterPrice.Replace("$", "").Replace(":", "");
            doublePrice = Double.Parse(noCharPrice);


            comboBox1.Items.Add("Yes");
            comboBox1.Items.Add("No");
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e) //pictureBox3_MouseEnter: Change panel and button color to Indigo
        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)//panel1_MouseEnter: Change panel and button color to Indigo
        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)//panel1_MouseLeave: Restore panel and button color to default
        
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)//pictureBox3_MouseLeave: Restore panel and button color to default
        
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_MouseLeave(object sender, EventArgs e)//button2_MouseLeave: Restore panel and button color to default
        
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox3_Click(object sender, EventArgs e)//pictureBox3_Click: Show confirmation message before closing the page
        
        {
            DialogResult dr = MessageBox.Show("Are you sure! Any data entered will be lost!", "Leaving the page", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes) this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        //button2_MouseEnter: Change panel and button color to Indigo

        {
            panel1.BackColor = Color.Indigo;
            button2.BackColor = Color.Indigo;
        }

        private void button2_Click(object sender, EventArgs e)
        //button2_Click: Show confirmation message before closing the page
        {
            DialogResult dr = MessageBox.Show("Are you sure! Any data entered will be lost!", "Leaving the page", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes) this.Close();
        }

        private void checkForm_Load(object sender, EventArgs e)
        //checkForm_Load: Display hotel name and price on label
        {
            label2.Text += hotelName + " And " + price + " For one night.";
        }


        private void button5_MouseEnter(object sender, EventArgs e)
        //button5_MouseEnter: Change button color and show tooltip
        {
            button5.ForeColor = Color.White;
            button5.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button5, "Your password is required");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        //button1_MouseEnter: Change button color and show tooltip
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button1, "Click to see the total sum!");
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        //button3_MouseEnter: Change button color and show tooltip
        {
            button3.ForeColor = Color.White;
            button3.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button3, "A clear shot is enough!");
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        //button4_MouseEnter: Change button color and show tooltip
        {
            button4.ForeColor = Color.White;
            button4.BackColor = Color.Indigo;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button4, "Book Now!");
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        //button5_MouseLeave: Restore button color to default
        {
            button5.ForeColor = Color.Orange;
            button5.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        //button1_MouseLeave: Restore button color to default
        {
            button1.ForeColor = Color.Orange;
            button1.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        //button3_MouseLeave: Restore button color to default
        {
            button3.ForeColor = Color.Orange;
            button3.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        //button4_MouseLeave: Restore button color to default
        {
            button4.ForeColor = Color.Orange;
            button4.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        //textBox1_TextChanged: Enable button1 if all parameters are filled
        {
            stay = textBox1.Text;
            if (textBox1.Text.Length > 0)
            {
                para4 = true;
            }
            else { para4 = false; }
            if (para1 && para2 && para3 && para4 && para5)
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        //textBox2_TextChanged: Enable button1 if all parameters are filled
        {
            if (textBox2.Text.Length > 0)
            {
                para1 = true;
            }
            else { para1 = false; }
            if (para1 && para2 && para3 && para4 && para5)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        //textBox3_TextChanged: Enable button1 if all parameters are filled
        {
            if (textBox3.Text.Length > 0)
            {
                para2 = true;
            }
            else { para2 = false; }
            if (para1 && para2 && para3 && para4 && para5)
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }
        }

        private void button5_Click(object sender, EventArgs e)
        //button5_Click: Open file dialog and set para3 to true
        {
            OpenFileDialog myofd = new OpenFileDialog();
            if (myofd.ShowDialog() == DialogResult.OK)
            {
                para3 = true;
            }
            
            if (para1 && para2 && para3 && para4 && para5)
            {
                button1.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //comboBox1_SelectedIndexChanged: Enable button1 if all parameters are filled
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                para5 = true;
            }
            else { button1.Enabled = false; }
            if (para1 && para2 && para3 && para4 && para5)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        //button1_Click: Calculate total based on stay and display elements
        {
            double intstay = Double.Parse(stay);
            double total = intstay * doublePrice;
            if (comboBox1.SelectedIndex == 0)
            {
                double plus = total * 0.05;
                total += plus;
                label6.Text = total.ToString();
                label3.Visible = true;
                label6.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                button3.Visible = true;
                checkBox1.Visible = true;
                button4.Visible = true;


            }
            else
            {
                label6.Text = total.ToString();
                label3.Visible = true;
                label6.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                button3.Visible = true;
                checkBox1.Visible = true;
                button4.Visible = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        //textBox4_TextChanged: Enable button4 if newPara1 or newPara2 are true
        {
            if (textBox4.Text.Length > 0) { newPara1 = true; }
            else { newPara1 = false; }
            if (newPara1 || newPara2)
            {
                if (newPara3)
                {
                    button4.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
                }
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        //button3_Click: Open file dialog and set newPara2 to true
        {
            OpenFileDialog myofd = new OpenFileDialog();
            if (myofd.ShowDialog() == DialogResult.OK)
            {
                newPara2 = true;
                invoicePara = true;
            }
            if (newPara1 || newPara2)
            {
                if (newPara3)
                {
                    button4.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
                }
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //checkBox1_CheckedChanged: Set newPara3 based on checkbox state
        {
            if (checkBox1.Checked) { newPara3 = true; }
            else { newPara3 = false; }

            if (newPara1 || newPara2)
            {
                if (newPara3)
                {
                    button4.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
                }
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        //button4_Click: Create an invoice file and show success message
        {
            StreamWriter streamWriter = new StreamWriter("Invoice.txt");
            streamWriter.WriteLine("Your name: " + textBox2.Text + ".");
            streamWriter.WriteLine("Your ID: " + textBox3.Text.ToString());
            streamWriter.WriteLine("Stay time: " + textBox1.Text.ToString() + " nights.");
            if (comboBox1.SelectedIndex == 0)
            {
                streamWriter.WriteLine("With Kids? " + "YES");
            }
            else streamWriter.WriteLine("With Kids? " + "NO");
            streamWriter.WriteLine("Total Price: "+label6.Text.ToString());
            if(invoicePara == false) {
                string stars = "";
                for (int i = 0; i < textBox4.TextLength - 4; i++)
                {
                    stars += "*";
                }
                streamWriter.WriteLine("Credit Card number: " + stars + textBox4.Text.Substring(0, textBox4.TextLength - 4));
            }
            else
            {
                streamWriter.WriteLine("Credit Card number was submitted via image.");
            }
            streamWriter.WriteLine("Having this Invoice means that you've agreed to the terms and conditions.");

            streamWriter.Close();

            MessageBox.Show("The reservation has been placed successfully. Check the invoice on your device.", "Successful reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
