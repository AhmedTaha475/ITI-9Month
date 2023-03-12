using D14_SD43_Task.Context;
using D14_SD43_Task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D14_SD43_Task
{
    public partial class DetailedForm : Form
    {
        public DetailedForm()
        {
            InitializeComponent();
        }
        pubsContext context = new pubsContext();
        static int counter = 0;
        private void DetailedForm_Load(object sender, EventArgs e)
        {

            //context.Titles.Load();
            //context.Publishers.Load();
            LoadData();
            var titLst=context.Titles.Local.ToBindingList();
            var pubLst=context.Publishers.Local.ToBindingList();

            BindingSource bs1=new BindingSource(titLst,"");

            titID.DataBindings.Add("Text", bs1, "TitleId",true,DataSourceUpdateMode.OnPropertyChanged);

            titName.DataBindings.Add("Text", bs1, "Title1");

            titType.DataBindings.Add("Text", bs1, "Type");

            titPrice.DataBindings.Add("Value", bs1, "Price", true, DataSourceUpdateMode.OnPropertyChanged);

            titAdvance.DataBindings.Add("Value", bs1, "Advance", true, DataSourceUpdateMode.OnPropertyChanged);

            titRoyal.DataBindings.Add("Value", bs1, "Royalty", true, DataSourceUpdateMode.OnPropertyChanged);

            titSale.DataBindings.Add("Value", bs1, "YtdSales", true, DataSourceUpdateMode.OnPropertyChanged);

            titNotes.DataBindings.Add("Text", bs1, "Notes");

            titTime.DataBindings.Add("Value", bs1, "Pubdate", true, DataSourceUpdateMode.OnPropertyChanged);

          

            pubCombo.DataSource = pubLst;
            pubCombo.DisplayMember = "PubName";
            pubCombo.ValueMember = "PubId";
            pubCombo.DataBindings.Add("SelectedValue", bs1, "PubId");


            BindingNavigator nav = new BindingNavigator(bs1);
            this.Controls.Add(nav);
            ToolStripButton btn = new ToolStripButton("Save");
            nav.Items.AddRange(new ToolStripItem[]
            {
                new ToolStripSeparator(),
                btn,
            });
            bs1.AddingNew += (sender, e) =>
            {
                e.NewObject = new Title() { TitleId = $"{counter}", Price = 0, Advance = 1, Royalty = 1, YtdSales = 1, Pubdate = DateTime.Now };
                counter++;
            };

            btn.Click += save;

        }


        private void LoadData()
        {
            context.Titles.Load();
            context.Publishers.Load();
        }

        private void save(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
                LoadData();
            }
            catch (Exception)
            {

                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
