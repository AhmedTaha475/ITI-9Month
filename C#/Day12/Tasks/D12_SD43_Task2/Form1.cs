using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;

namespace D12_SD43_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlCn;
        SqlCommand sqlcmd;
        SqlDataAdapter sqlDA;
        DataTable DT;

        SqlCommand sqlcmdSup;
        SqlDataAdapter sqlDaSup;
        DataTable DTSup;


        SqlCommand sqlcmdCat;
        SqlDataAdapter sqlDaCat;
        DataTable DTCat;




        BindingSource bs;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            idBox.ReadOnly= true;


            sqlCn= new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCn"].ConnectionString);
            #region For products
            sqlcmd = new SqlCommand(@"select * from Products", sqlCn);
            //sqlcmd = new SqlCommand(@"SelectAllProducts", sqlCn);
            //sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlDA = new SqlDataAdapter(sqlcmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDA);
            sqlDA.InsertCommand = builder.GetInsertCommand();
            sqlDA.UpdateCommand = builder.GetUpdateCommand();
            sqlDA.DeleteCommand = builder.GetDeleteCommand();

            
            DT = new DataTable();
            sqlDA.Fill(DT);
            bs = new BindingSource(DT, "");
            
            #endregion


            #region Supplier Trial 01
            sqlcmdSup = new SqlCommand(@"select * from Suppliers", sqlCn);
            sqlDaSup = new SqlDataAdapter(sqlcmdSup);
            DTSup = new DataTable();
            sqlDaSup.Fill(DTSup);

            #endregion



            #region Category Trial 01
            sqlcmdCat = new SqlCommand(@"select * from Categories", sqlCn);
            sqlDaCat = new SqlDataAdapter(sqlcmdCat);
            DTCat = new DataTable();
            sqlDaCat.Fill(DTCat);

            #endregion
            //price_numeric.DataBindings.Add("Value", bindingSource, "price", true, DataSourceUpdateMode.OnPropertyChanged);
            /// modified numericUpdown according to date 22-2-2023
            idBox.DataBindings.Add("Value", bs, "ProductID",true,DataSourceUpdateMode.OnPropertyChanged);
            nameBox.DataBindings.Add("Text", bs, "ProductName");
            //suppBox.DataBindings.Add("Value", bs, "SupplierID");
            //catBox.DataBindings.Add("Value", bs, "CategoryID");
            quanBox.DataBindings.Add("Text", bs, "QuantityPerUnit");
            priceBox.DataBindings.Add("Value", bs, "UnitPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            stockBox.DataBindings.Add("Value", bs, "UnitsInStock", true, DataSourceUpdateMode.OnPropertyChanged);
            orderBox.DataBindings.Add("Value", bs, "UnitsOnOrder", true, DataSourceUpdateMode.OnPropertyChanged);
            levelBox.DataBindings.Add("Value", bs, "ReorderLevel", true, DataSourceUpdateMode.OnPropertyChanged);
            disBox.DataBindings.Add("Text", bs, "Discontinued");





            suppCombo.DataSource = DTSup;
            suppCombo.ValueMember = "SupplierID";
            suppCombo.DisplayMember = "CompanyName";
            suppCombo.DataBindings.Add("SelectedValue", bs, "SupplierID");

            catCombo.DataSource = DTCat;
            catCombo.ValueMember = "CategoryID";
            catCombo.DisplayMember = "CategoryName";
            catCombo.DataBindings.Add("SelectedValue", bs, "CategoryID");




            BindingNavigator  nav = new BindingNavigator(bs);
            ToolStripButton btn = new ToolStripButton("Save");
            ToolStripButton btn2 = new ToolStripButton("Add New Row");
            ToolStripButton btn3 = new ToolStripButton("Save New Row");
            //nav.AddNewItem.Visible = false;
            //DataRowBuilder build= new DataRowBuilder(DT,5);

            //--------------------------------


            //DataRow row = DT.NewRow();
            //row["ProductName"] = "Simple Test";
            //Trace.WriteLine(bs.DataSource.GetType().Name);
            //bs.AddingNew += (sender, e) => e.NewObject = row ;

            //-----------------------------------







            nav.Items.AddRange(new ToolStripItem[]
            {
               new ToolStripSeparator(),
               btn,
               new ToolStripSeparator(),
               btn2,
               new ToolStripSeparator(),
               btn3,
            });
            this.Controls.Add(nav);
            btn.Click += saveBtn;
            btn2.Click += AddingNewItem;
            btn3.Click += saveNewItem;



        }
        private void saveNewItem(object sender, EventArgs e)
        {

            DataRow row = DT.NewRow();
            row["ProductName"] = nameBox.Text;
            row["SupplierID"] = suppCombo.SelectedValue;
            row["CategoryID"] = catCombo.SelectedValue;
            row["QuantityPerUnit"] = quanBox.Text;
            row["UnitPrice"] = priceBox.Value;
            row["UnitsInStock"] = stockBox.Value;
            row["UnitsOnOrder"] = orderBox.Value;
            row["ReorderLevel"] = levelBox.Value;
            if(disBox.Text.ToLower()=="true")
            {
            row["Discontinued"] = 1;

            }else if (disBox.Text.ToLower()=="false")
            {
                row["Discontinued"] = 0;

            }
            DT.Rows.Add(row);
           
            try
            {
                sqlDA.Update(DT);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Why are you running ", "Stay Here", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void AddingNewItem(object sender , EventArgs e)
        {

            foreach (var item in this.Controls)
            {
                
                if(item.GetType().Name=="TextBox")
                {
                    TextBox t =(TextBox)item;
                    t.Clear();
                }
                else if (item.GetType().Name == "NumericUpDown")
                {
                    NumericUpDown t = (NumericUpDown)item;
                    t.Value = 0;
                }

            }

            
        }

        private void saveBtn(object sender,EventArgs e)
        {
            this.Validate();
            bs.EndEdit();
            
            try
            {
                sqlDA.Update(DT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Data please Try Again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
    }
}