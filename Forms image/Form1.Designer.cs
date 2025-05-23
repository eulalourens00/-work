namespace Forms_image
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            exidToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            button3 = new Button();
            comboBox3 = new ComboBox();
            panel2 = new Panel();
            button1 = new Button();
            label3 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            label4 = new Label();
            panel4 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, exidToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(122, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // exidToolStripMenuItem
            // 
            exidToolStripMenuItem.Name = "exidToolStripMenuItem";
            exidToolStripMenuItem.Size = new Size(122, 26);
            exidToolStripMenuItem.Text = "Exid";
            exidToolStripMenuItem.Click += exidToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 58);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(comboBox3);
            panel1.Location = new Point(12, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 151);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 13);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 6;
            label2.Text = "Pen Tool";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(7, 104);
            button3.Name = "button3";
            button3.Size = new Size(232, 29);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox3.Location = new Point(7, 55);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(232, 28);
            comboBox3.TabIndex = 0;
            comboBox3.Text = "1";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 82);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(13, 36);
            button1.Name = "button1";
            button1.Size = new Size(225, 29);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 13);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 0;
            label3.Text = "Canvas Color";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 300);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 138);
            panel3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 54);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 5;
            label5.Text = "size";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(107, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 27);
            textBox1.TabIndex = 4;
            // 
            // button5
            // 
            button5.Location = new Point(7, 45);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 3;
            button5.Text = "circle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(7, 80);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "rectangle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(7, 10);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "square";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 14);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 0;
            label4.Text = "Draw Shapes";
            // 
            // panel4
            // 
            panel4.Location = new Point(300, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(474, 391);
            panel4.TabIndex = 7;
            panel4.MouseDown += panel4_MouseDown;
            panel4.MouseMove += panel4_MouseMove;
            panel4.MouseUp += panel4_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exidToolStripMenuItem;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private ComboBox comboBox3;
        private Label label2;
        private Label label3;
        private Button button1;
        private Panel panel3;
        private Label label4;
        private Button button5;
        private Button button4;
        private Button button2;
        private Label label5;
        private TextBox textBox1;
        private Panel panel4;
    }
}
