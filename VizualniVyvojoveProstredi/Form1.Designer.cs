namespace VizualniVyvojoveProstredi
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
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 553);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(12, 348);
            button7.Name = "button7";
            button7.Size = new Size(170, 50);
            button7.TabIndex = 6;
            button7.Text = "END";
            button7.UseVisualStyleBackColor = false;
            button7.Click += AddOnClick;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(12, 292);
            button6.Name = "button6";
            button6.Size = new Size(170, 50);
            button6.TabIndex = 5;
            button6.Text = "WHILE";
            button6.UseVisualStyleBackColor = false;
            button6.Click += AddOnClick;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(12, 236);
            button5.Name = "button5";
            button5.Size = new Size(170, 50);
            button5.TabIndex = 4;
            button5.Text = "IF";
            button5.UseVisualStyleBackColor = false;
            button5.Click += AddOnClick;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(12, 180);
            button4.Name = "button4";
            button4.Size = new Size(170, 50);
            button4.TabIndex = 3;
            button4.Text = "ACTION";
            button4.UseVisualStyleBackColor = false;
            button4.Click += AddOnClick;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(12, 68);
            button3.Name = "button3";
            button3.Size = new Size(170, 50);
            button3.TabIndex = 2;
            button3.Text = "INPUT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += AddOnClick;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(12, 124);
            button2.Name = "button2";
            button2.Size = new Size(170, 50);
            button2.TabIndex = 1;
            button2.Text = "OUTPUT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddOnClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(170, 50);
            button1.TabIndex = 0;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddOnClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Dock = DockStyle.Right;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(732, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 428);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(200, 428);
            panel3.Name = "panel3";
            panel3.Size = new Size(682, 125);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.AllowDrop = true;
            panel4.AutoScroll = true;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(200, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(532, 428);
            panel4.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
