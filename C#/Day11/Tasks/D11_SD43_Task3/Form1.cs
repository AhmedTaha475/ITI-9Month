namespace D11_SD43_Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            defaultBrush = new SolidBrush(this.BackColor);
        }
        Brush drawingBrush = new SolidBrush(Color.Red);
        Brush defaultBrush;
        private void color_Click(object sender, EventArgs e)
        {
            if(dlgColor.ShowDialog()== DialogResult.OK)
            {
                drawingBrush= new SolidBrush(dlgColor.Color);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics grx=this.CreateGraphics();
            if(e.Button == MouseButtons.Left)
            {
                //grx.DrawLine(drawingPen, e.X, e.Y, e.X + 5, e.Y + 5);
                grx.FillEllipse(drawingBrush, new Rectangle(e.Location, new Size(10, 10)));

            }else if(e.Button == MouseButtons.Right)
            {
                grx.FillEllipse(defaultBrush, new Rectangle(e.Location, new Size(10, 10)));

            }
        }
    }
}