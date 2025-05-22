using System.Drawing.Drawing2D;

namespace Forms_image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
