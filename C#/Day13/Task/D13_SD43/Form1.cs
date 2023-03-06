using D13_SD43_BLL.Entities;
using D13_SD43_BLL.EntityList;
using D13_SD43_BLL.EntityManager;
using System.Diagnostics;

namespace D13_SD43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PublisherList plst;
        private void loadGrd_Click(object sender, EventArgs e)
        {
            plst= PublisherManager.SelectAllPublishers();
            BindingSource bs= new BindingSource(plst,"");
            grd1.DataSource = bs;
            #region Adjusting Columns Max Length
            DataGridViewTextBoxColumn col = (DataGridViewTextBoxColumn)grd1.Columns[0];
            col.MaxInputLength = 4;
            col = (DataGridViewTextBoxColumn)grd1.Columns[1];
            col.MaxInputLength = 40;
            col = (DataGridViewTextBoxColumn)grd1.Columns[2];
            col.MaxInputLength = 20;
            col = (DataGridViewTextBoxColumn)grd1.Columns[3];
            col.MaxInputLength = 2;
            col = (DataGridViewTextBoxColumn)grd1.Columns[4];
            col.MaxInputLength = 30; 
            #endregion
            grd1.Columns["RowState"].ReadOnly= true;
            bs.AddingNew += (sender, e) => e.NewObject = new Publisher() { RowState = EntityState.Added };
            
        }

        private void saveGrd_Click(object sender, EventArgs e)
        {
            grd1.EndEdit();
            foreach (var item in plst)
            {

                if(item.RowState==EntityState.Changed)
                {
                    PublisherManager.UpdatePublisher(item.Pub_id, item.Pub_Name, item.Country, item.City, item.State);
                }
                else if (item.RowState==EntityState.Added)
                {
                    PublisherManager.InsertPublisher(item.Pub_id,item.Pub_Name,item.Country,item.City, item.State);
                }




            }
        }

        private void grd1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            #region Testing States
            //if ((EntityState)e.Row.Cells[5].Value== EntityState.UnChanged)
            //{
            //    Trace.Write("Trueeeeeeeeeeeeeeeeeeeeeee");
            //}
            //else
            //{
            //    Trace.WriteLine("trashhhhhhh");
            //} 
            #endregion
            if ((EntityState)e.Row.Cells["RowState"].Value != EntityState.Added)
            {
                if ( e.Row.Cells[0].Value!= null && PublisherManager.DeletePublisher(e.Row.Cells[0].Value.ToString()))
                {
                    MessageBox.Show($"Row with ID {e.Row.Cells[0].Value.ToString()} Has Been Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"ID Can't Be Null Here ", "Deleting Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show($"You Can't Newly Added Rows ", "Deleting Row", MessageBoxButtons.OK, MessageBoxIcon.Information);

                e.Cancel = true;
            }

        }

    

     

       
    }
}