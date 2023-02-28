using System.Drawing.Drawing2D;
using System.Security.Cryptography.Pkcs;

namespace D11_SD43_Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath p1 = new GraphicsPath();
            p1.AddEllipse(0, 0, this.Width, this.Height);
            p1.AddEllipse(0, 0, 150, 150);
            p1.AddEllipse(330, 0, 150, 150);
            p1.AddRectangle(new Rectangle(100, 150, 100, 40));
            p1.AddRectangle(new Rectangle(300, 150, 100, 40));
            p1.FillMode = FillMode.Winding;
            this.Region = new Region(p1);
            e.Graphics.FillRegion(Brushes.DarkGray, this.Region);

            e.Graphics.DrawRectangle(Pens.White, new Rectangle(100, 150, 100, 40));
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(100, 150, 100, 40));

            e.Graphics.DrawRectangle(Pens.White, new Rectangle(300, 150, 100, 40));
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(300, 150, 100, 40));

            e.Graphics.DrawRectangle(Pens.White, new Rectangle(200, 300, 100, 40));
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(200, 300, 100, 40));



            base.OnPaint(e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool mDown = false;

        private void btnDrg_MouseMove(object sender, MouseEventArgs e)
        {
            if(mDown)
            {
                this.Location= new Point(this.Location.X+e.X, this.Location.Y+e.Y);
                this.Update();
            }
        }

        private void btnDrg_MouseDown(object sender, MouseEventArgs e)
        {
            mDown= true;
        }

        private void btnDrg_MouseUp(object sender, MouseEventArgs e)
        {
            mDown= false;
        }
    }
}