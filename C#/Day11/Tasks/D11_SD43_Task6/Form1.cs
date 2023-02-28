using System.Drawing.Drawing2D;

namespace D11_SD43_Task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int x = 150;
        private bool flag;
        protected override void OnPaint(PaintEventArgs e)
        {

            GraphicsPath p1 = new GraphicsPath();
            p1.StartFigure();
            p1.AddEllipse(50, 50, 100, 100);
            p1.AddLine(new Point(100, 150), new Point(100, 350));
            p1.CloseFigure();
            p1.StartFigure();
            p1.AddLine(new Point(100, 150), new Point(150, 200));
            p1.AddLine(new Point(100, 150), new Point(50, 200));
            p1.CloseFigure();
            p1.AddLine(new Point(100, 350), new Point(150, 400));
            p1.AddLine(new Point(100, 350), new Point(50, 400));
            e.Graphics.DrawPath(Pens.Black, p1);
            //Path 2 the female
            e.Graphics.DrawEllipse(Pens.Black, 900, 50, 100, 100);
            e.Graphics.DrawLine(Pens.Black, new Point(950, 150), new Point(950, 350));
            e.Graphics.DrawLine(Pens.Black, new Point(950, 350), new Point(1000, 400));
            e.Graphics.DrawLine(Pens.Black, new Point(950, 350), new Point(900, 400));
            e.Graphics.DrawLine(Pens.Black, new Point(950, 150), new Point(1000, 200));
            e.Graphics.DrawLine(Pens.Black, new Point(950, 150), new Point(900, 200));
            e.Graphics.DrawLine(Pens.Black, new Point(950, 50), new Point(1000, 100));
            e.Graphics.DrawLine(Pens.Black, new Point(950, 50), new Point(900, 100));


            e.Graphics.DrawEllipse(Pens.Red, x, 300, 100, 100);
            base.OnPaint(e);
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 150)
            {
                flag = true;
            }
            else if (x == 800)
            {
                flag = false;
            }

            if (flag)
            {
                x += 50;
                Invalidate();
            }
            else
            {
                x -= 50;
                Invalidate();
            }
        }
    }
}