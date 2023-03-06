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
    public partial class frmTitle : Form
    {
        public frmTitle()
        {
            InitializeComponent();
        }
        TitleList plst;
        static int counter = 0;
        private void loadGrd_Click(object sender, EventArgs e)
        {
            plst = TitleManager.SelectAllTitles();
            BindingSource bs = new BindingSource(plst, "");
            grd1.DataSource = bs;
            grd1.Columns["PublisherId"].Visible= false;
           PublisherList publisherlst=PublisherManager.SelectAllPublishers();

            if(counter==0)
            {
                DataGridViewComboBoxColumn col2 = new DataGridViewComboBoxColumn();
                grd1.Columns.Add(col2);
                col2.DataSource = publisherlst;
                col2.HeaderText = " PublisherList";
                col2.DisplayMember = "pub_Name";
                col2.ValueMember = "pub_id";
                col2.DataPropertyName = "PublisherId";
                counter++;
            }
            
            #region Adjusting Columns Max Length
            DataGridViewTextBoxColumn col = (DataGridViewTextBoxColumn)grd1.Columns[0];
            col.MaxInputLength = 6;
            col = (DataGridViewTextBoxColumn)grd1.Columns[1];
            col.MaxInputLength = 80;
            col = (DataGridViewTextBoxColumn)grd1.Columns[2];
            col.MaxInputLength = 12;
            col = (DataGridViewTextBoxColumn)grd1.Columns[3];
            col.MaxInputLength = 4;
            //col = (DataGridViewTextBoxColumn)grd1.Columns[4];
            //col.MaxInputLength = 30;
            #endregion
            grd1.Columns["RowState"].ReadOnly = true;
            bs.AddingNew += (sender, e) => e.NewObject = new Title() { RowState = EntityState.Added };

        }

        private void saveGrd_Click(object sender, EventArgs e)
        {
            grd1.EndEdit();
            foreach (var item in plst)
            {

                if (item.RowState == EntityState.Changed)
                {
                    TitleManager.UpdateTitle(item.TitleId, item.TitleName, item.Type, item.PublisherId,
                       item.Price, item.Advance, item.Royalty, item.YearToDateSales , item.Notes, item.PublicationDate );
                }
                else if (  item.RowState == EntityState.Added )
                {
                    TitleManager.InsertTitle(item.TitleId, item.TitleName, item.Type, item.PublisherId,
                        item.Price, item.Advance, item.Royalty, item.YearToDateSales, item.Notes, item.PublicationDate);
                }




            }
        }

        private void grd1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if ((EntityState)e.Row.Cells["RowState"].Value != EntityState.Added)
            {
                if (e.Row.Cells[0].Value != null && TitleManager.DeleteTitle(e.Row.Cells[0].Value.ToString()))
                {
                    MessageBox.Show($"Row with ID {e.Row.Cells[0].Value.ToString()} Has Been Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Something Went Wrong ", "Deleting Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show($"You Can't Newly Added Rows ", "Deleting Row", MessageBoxButtons.OK, MessageBoxIcon.Information);

                e.Cancel = true;
            }
        }

        private void grd1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(e.Exception!= null && e.Context== DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Please enter Correct Data Type for the cell ", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
