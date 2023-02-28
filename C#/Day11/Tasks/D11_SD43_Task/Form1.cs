using D11_SD43_Task;
using MaterialSkin;
using MaterialSkin.Controls;
namespace KryptonToolKitDemo

{
    public partial class frm1 : MaterialForm
    {
        public frm1()
        {
            InitializeComponent();
            #region Custom Material
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE); 
            #endregion
            
        }

        private void frm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit? Y/N ", "Close Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            close.Click += (sender, e) => this.Close();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            dlgOpen.Filter = "Rich Text File |*.rtf|TextFiles|*.txt";
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                rtb.LoadFile(dlgOpen.FileName,(RichTextBoxStreamType)dlgOpen.FilterIndex-1);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            dlgSave.Filter = "Rich text file |*.rtf|Text file |*.txt";
            if(dlgSave.ShowDialog()==DialogResult.OK)
            {
                rtb.SaveFile(dlgSave.FileName,(RichTextBoxStreamType)dlgSave.FilterIndex-1);
            }
        }

        private void font_Click(object sender, EventArgs e)
        {
            dlgFont.Font = rtb.SelectionFont;
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionFont = dlgFont.Font;
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            dlgColor.Color=rtb.SelectionColor ;
            if(dlgColor.ShowDialog()==DialogResult.OK)
            {
                rtb.SelectionColor = dlgColor.Color;
            }
        }
        CustomDialog cust1= new CustomDialog();
        private void materialButton4_Click(object sender, EventArgs e)
        {
            if(cust1.ShowDialog()==DialogResult.OK)
            {
                rtb.AppendText(cust1.txtHolder.ToUpper());
            }
        }
    }
}