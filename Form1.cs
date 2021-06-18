using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        Bitmap bp = new Bitmap(1024,768);
        Pen p = new Pen(Color.Black,5);
        bool drawing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (drawing) drawing = false; else drawing = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
             if ( drawing)
            {
                Graphics g = Graphics.FromImage(bp);
                g.DrawEllipse(p, e.X, e.Y,3,1);
                pictureBox1.Image = bp;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }
    }
}
