using D14_SD43_Task.Context;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace D14_SD43_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        pubsContext context=new pubsContext();
        static int counter=0;
        DataGridViewComboBoxColumn col;
        private void Form1_Load(object sender, EventArgs e)
        {
            


            foreach (var item in context.Titles.Local)
            {
                Trace.WriteLine($"ID is :{item.TitleId} ::: Pub_ID {item.PubId}");
            }

            
        }

        private void loadMenu_Click(object sender, EventArgs e)
        {
            context.Titles.Load();
            context.Publishers.Load();
            //BindingSource bs1=new BindingSource(context.Titles.Local.ToList(),"");
            //grd1.DataSource = bs1;
            grd1.DataSource = context.Titles.Local.ToBindingList();

            grd1.Columns[10].Visible = false;
            grd1.Columns[3].Visible = false;

             col = new DataGridViewComboBoxColumn();
            col.HeaderText = "Publisher";
            col.DataSource = context.Publishers.Local.ToBindingList();
            col.DisplayMember = "PubName";
            col.ValueMember = "PubId";
            col.DataPropertyName = "PubId";
            grd1.Columns.Add(col);
             


        }

        private void SaveMenu_Click(object sender, EventArgs e)
        {
            grd1.EndEdit();
            Trace.WriteLine("====================");
            foreach (var item in context.Titles.Local)
            {

                Trace.WriteLine(context.Entry(item).State);


            }
            context.SaveChanges();
        }
    }
}