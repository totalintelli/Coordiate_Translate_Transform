using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coordiate_Translate_Transform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PageUnit = GraphicsUnit.Inch;

            Point renderingOrgPt = new Point(0, 0);
            renderingOrgPt.X = 1;
            renderingOrgPt.Y = 1;

            g.TranslateTransform(renderingOrgPt.X, renderingOrgPt.Y);
            g.DrawRectangle(new Pen(Color.Red, 1), 0, 0, 100, 100);
            g.Dispose();
        }
    }
}
