namespace D11_SD43_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            Font myFont = new Font(this.Font.FontFamily, 18);
            string str = "Hello GDI +";
            SizeF s= e.Graphics.MeasureString(str, myFont);
            e.Graphics.DrawString(str, myFont, Brushes.CadetBlue, (ClientSize.Width-s.Width)/2, (ClientSize.Height-s.Height)/2);
            
        }
    }
}