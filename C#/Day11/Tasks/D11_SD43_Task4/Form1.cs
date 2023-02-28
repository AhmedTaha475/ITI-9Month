using System.Drawing.Drawing2D;

namespace D11_SD43_Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point dynamicPoint= new Point(20, 20);
        GraphicsPath path =new GraphicsPath();
        bool mdown=false;
        protected override void OnPaint(PaintEventArgs e)
        {

            path.Reset();
            path.AddRectangle(new Rectangle(dynamicPoint, new Size(100, 60)));
            e.Graphics.FillPath(Brushes.DarkCyan, path);

            base.OnPaint(e);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left  )
            {

                if (mdown)
                {
                    dynamicPoint.X = e.X;
                    dynamicPoint.Y = e.Y;
                    Invalidate();
                }

                //if(e.X>=dynamicPoint.X-20 && e.X<=dynamicPoint.X+100 && e.Y>=dynamicPoint.Y-25 && e.Y<=dynamicPoint.Y+60)
                //{
                //    dynamicPoint.X = e.X;
                //    dynamicPoint.Y = e.Y;
                //    Invalidate();
                //}
            }
            
        }
        // so lets say if i used it directly on mouse move 
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(path.IsVisible(e.Location))
            {
                mdown = true;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mdown= false;
        }
    }
}