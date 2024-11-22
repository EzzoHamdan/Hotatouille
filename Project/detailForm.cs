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
    public partial class detailForm : Form
    {
        public detailForm()
        {
            InitializeComponent();
        }
                
        private void label2_MouseHover(object sender, EventArgs e) // Mouse hover label trigger some effects.
        {
            label2.ForeColor = Color.Orange;
        }

        private void button1_MouseHover(object sender, EventArgs e) // Mouse hover button that carries the icon trigger some effects.
        {

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button1, "Back to Main Page");
        }

        private void button1_MouseLeave(object sender, EventArgs e) // Mouse leave button that carries the icon shape trigger some effects.
        {
            button1.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button1_MouseEnter(object sender, EventArgs e) // Mouse enter button that carries the icon trigger some effects.
        {
            button1.BackColor = Color.Indigo;
        }

        private void label2_MouseLeave(object sender, EventArgs e) // Mouse leave button that carries a triangle shape trigger some effects.
        {
            label2.ForeColor = Color.Indigo;
        }

        private void button1_Click(object sender, EventArgs e) // Mouse click button that carries the icon close the current form.
        {
            this.Close();
        }

        // Accidentally provoked functions

        private void detailForm_Load(object sender, EventArgs e)
        {

        }

    }
}
