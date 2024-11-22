namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 75);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Freestyle Script", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(526, 47);
            label1.TabIndex = 0;
            label1.Text = "Hotatouille: Where leisure meets delicious fare.";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.ForeColor = SystemColors.ActiveBorder;
            progressBar1.Location = new Point(0, 423);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(782, 30);
            progressBar1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Enabled = false;
            button1.FlatAppearance.BorderColor = Color.Indigo;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(301, 245);
            button1.Name = "button1";
            button1.Size = new Size(180, 52);
            button1.TabIndex = 3;
            button1.Text = "Make a Reservation";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // label2
            // 
            label2.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(218, 103);
            label2.Name = "label2";
            label2.Size = new Size(346, 50);
            label2.TabIndex = 4;
            label2.Text = "Here arrives this season, so clear,\r\nWith Hotatouille, make moments dear.\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            // 
            // label3
            // 
            label3.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(301, 369);
            label3.Name = "label3";
            label3.Size = new Size(180, 50);
            label3.TabIndex = 5;
            label3.Text = "\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(218, 172);
            label4.Name = "label4";
            label4.Size = new Size(346, 50);
            label4.TabIndex = 6;
            label4.Text = "This time of year, a memory sincere,\r\nWhere flavors rhyme and laughter cheer.\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(782, 453);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(panel2);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}