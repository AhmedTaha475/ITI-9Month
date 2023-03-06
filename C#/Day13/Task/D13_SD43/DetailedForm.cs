using D13_SD43_BLL.Entities;
using D13_SD43_BLL.EntityList;
using D13_SD43_BLL.EntityManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D13_SD43
{
    public partial class DetailedForm : Form
    {
        public DetailedForm()
        {
            InitializeComponent();
        }
        TitleList titleLst;
        PublisherList publisherLst;
        BindingSource bindingSource;
        private void DetailedForm_Load(object sender, EventArgs e)
        {

            loadData();

            bindingSource = new BindingSource(titleLst, "");

            titID.DataBindings.Add("Text", bindingSource, "TitleId");

            titName.DataBindings.Add("Text", bindingSource, "TitleName");

            titType.DataBindings.Add("Text", bindingSource, "Type");

            titPrice.DataBindings.Add("Value", bindingSource, "Price");

            titAdvance.DataBindings.Add("Value", bindingSource, "Advance");

            titRoyal.DataBindings.Add("Value", bindingSource, "Royalty");

            titNotes.DataBindings.Add("Text", bindingSource, "Notes");

            titTime.DataBindings.Add("Value", bindingSource, "PublicationDate");

            titState.DataBindings.Add("Text", bindingSource, "RowState");

            pubCombo.DataSource = publisherLst;
            pubCombo.DisplayMember = "Pub_Name";
            pubCombo.ValueMember = "Pub_id";
            pubCombo.DataBindings.Add("SelectedValue", bindingSource, "PublisherId");


            BindingNavigator nav = new BindingNavigator(bindingSource);
            this.Controls.Add(nav);
            ToolStripButton btn = new ToolStripButton("Save");
            ToolStripButton btn2 = new ToolStripButton("Delete");
            nav.Items.AddRange(new ToolStripItem[]
            {
                new ToolStripSeparator(),
                btn,
                new ToolStripSeparator(),
                btn2,
            });


            btn.Click += Update;
            btn2.Click += Delete;
            bindingSource.AddingNew += (sender, e) =>
         e.NewObject = new Title() { RowState = EntityState.Added, Price = 1, Advance = 1, Royalty = 1,YearToDateSales=1,PublicationDate=DateTime.Now };

            nav.DeleteItem.Click += (sender, e) =>
            {
                var counter = 0;
                foreach (var item in titleLst)
                {
                    counter++;
                }
                MessageBox.Show($"{counter}");
            };
        }
         public void loadData()
        {
            titleLst = TitleManager.SelectAllTitles();

            publisherLst = PublisherManager.SelectAllPublishers();

          

        }
        private void Delete(object sender, EventArgs e)
        {
            var DeletedTitle = titleLst.Where(t=>t.TitleId==titID.Text).FirstOrDefault();

            if (TitleManager.DeleteTitle(DeletedTitle.TitleId))
            {
                titleLst.Remove(DeletedTitle);
            }
            else
            {
                MessageBox.Show("Something Went Wrong","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void Update(object sender, EventArgs e)
        {
            bindingSource.EndEdit();    
            foreach (var item in titleLst)
            {

                if(item.RowState==EntityState.Changed)
                {
                    TitleManager.UpdateTitle(item.TitleId, item.TitleName, item.Type, 
                        item.PublisherId, item.Price, item.Advance, item.Royalty, item.YearToDateSales,
                        item.Notes, item.PublicationDate);
                }else if (item.RowState== EntityState.Deleted) 
                {
                    TitleManager.DeleteTitle(item.TitleId);
                }
                else if (item.RowState== EntityState.Added) 
                {
                    TitleManager.InsertTitle(item.TitleId, item.TitleName, item.Type,
                        item.PublisherId, item.Price, item.Advance, item.Royalty, item.YearToDateSales,
                        item.Notes, item.PublicationDate);
                }



            }
            loadData();
        }
    }
}
