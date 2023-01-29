using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParabolaDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textBox1.Text); // коэффициент при x^2 

            int b = Convert.ToInt32(textBox2.Text); // коэффициент при x 

            int c = Convert.ToInt32(textBox3.Text); // свободный член 

            Graphics g = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.Blue, 1);

            g.Clear(Color.White);

            double x; // абсцисса точки растра 

            double y; // ордината точки растра  

            for (x = -pictureBox1.Width / 2; x < pictureBox1.Width / 2; x++) // перебор значений абсциссы  
            {

                y = a * Math.Pow(x, 2) + b * x + c; // вычисление ординаты  

                g.DrawLine(pen, (float)(x + pictureBox1.Width / 2), (float)(-y + pictureBox1.Height / 2), (float)(x + pictureBox1.Width / 2), (float)(-y + pictureBox1.Height / 2));

            }
        }
    }
}