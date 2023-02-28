using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D11_SD43_Task
{
    public partial class CustomDialog : MaterialForm
    {
        public string txtHolder { get => txt.Text; set => txt.Text = value; }
        public CustomDialog()
        {
            InitializeComponent();
            txtHolder = txt.Text;
        }
    }
}
