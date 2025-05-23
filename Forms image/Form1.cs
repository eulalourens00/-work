using System.Drawing.Drawing2D;

namespace Forms_image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            g = panel4.CreateGraphics();
        }

        bool startPaint;
        Graphics g;
        int? initX;
        int? initY;

        bool drawSquare = false;
        bool drawCircle = false;
        bool drawRectangle = false;


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            //Pen pn = new Pen(Brushes.Blue, 5);
            //pn.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            //graphics.DrawEllipse(pn, 50, 100, 170, 40);
            //graphics.Dispose();

            //Rectangle rect = new Rectangle(20, 20, 200, 40);
            //LinearGradientBrush igBrush = new LinearGradientBrush(rect, Color.Red, Color.BurlyWood, 
            //    0.0f, true);
            //graphics.FillRectangle(igBrush, rect);

            //Font f = new Font("Verdana", 14, FontStyle.Bold);
            //graphics.DrawString("Leeky Suya", f, Brushes.Blue, 30, 55);
            //graphics.Dispose();


            // Õ¿ œ–Œ≈ “ œŒƒ “¿¡À»÷” ‘Œ“Œ√–¿‘»…
            //Rectangle rect = this.ClientRectangle;
            //Image im = new Bitmap("ÔˇÚ¸.jpg");
            //graphics.DrawImage(im, rect);
            //graphics.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(panel4.BackColor);
            panel4.BackColor = Color.White;
        }

        private void exidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u wanna exit?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                SolidBrush sb = new SolidBrush(button3.BackColor);
                g.FillRectangle(sb, e.X, e.Y, int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(button3.BackColor);
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                startPaint = false;
                drawRectangle = false;
            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(button3.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                startPaint = false;
                drawCircle = false;
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                Pen p = new Pen(button3.BackColor, float.Parse(comboBox3.Text));
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = c.Color;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                panel4.BackColor = c.Color;
                button1.BackColor = c.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
