using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using System.Diagnostics;

namespace D12_SD43_Task2
{
    public partial class frmTst : Form
    {
        public frmTst()
        {
            InitializeComponent();
            #region Testing
            //sqlcom1 = new SqlCommand("SelectAllProducts", sqlcon);//Stored procedure
            //sqlcom1.CommandType = CommandType.StoredProcedure;
            //adpro = new SqlDataAdapter(sqlcom1);
            //dtpro = new DataTable();
            //sqlcom2 = new SqlCommand("select CompanyName,SupplierID as Sid from [dbo].[Suppliers]", sqlcon);
            //adsup = new SqlDataAdapter(sqlcom2);
            //dtsup = new DataTable();
            //sqlcom3 = new SqlCommand("select [CategoryName],[CategoryID] as Cid from [dbo].[Categories]", sqlcon);
            //adcat = new SqlDataAdapter(sqlcom3);
            //dtcat = new DataTable();
            //SqlCommandBuilder sqlbuilder = new SqlCommandBuilder(adpro);
            //adpro.InsertCommand = sqlbuilder.GetInsertCommand();
            //adpro.UpdateCommand = sqlbuilder.GetUpdateCommand();
            //adpro.DeleteCommand = sqlbuilder.GetDeleteCommand(); 
            #endregion
        }
        #region Testing
        //SqlConnection sqlcon = new SqlConnection(@"Data Source=.\ITI_DB;Initial Catalog=Northwind;Integrated Security=True;Encrypt=false");
        //SqlCommand sqlcom1;
        //SqlCommand sqlcom2;
        //SqlCommand sqlcom3;
        //SqlDataAdapter adpro;
        //SqlDataAdapter adsup;
        //SqlDataAdapter adcat;
        //DataTable dtpro;
        //DataTable dtsup;
        //DataTable dtcat; 
        #endregion

        SqlConnection sqlcn;
        SqlCommand sqlcmd;
        SqlDataAdapter sqlDa;
        DataTable dt;
        private void frmTst_Load(object sender, EventArgs e)
        {
            #region Testing
            //adpro.Fill(dtpro);
            //adsup.Fill(dtsup);
            //adcat.Fill(dtcat);
            //BindingSource bindp = new BindingSource(dtpro, "");
            //BindingNavigator bn = new BindingNavigator(bindp);
            //this.Controls.Add(bn);
            //textBox1.DataBindings.Add("Text", bindp, "ProductName");
            //textBox2.DataBindings.Add("Text", bindp, "QuantityPerUnit");
            //textBox3.DataBindings.Add("Text", bindp, "UnitPrice");
            //textBox4.DataBindings.Add("Text", bindp, "UnitsInStock");
            //textBox5.DataBindings.Add("Text", bindp, "UnitsOnOrder");
            //textBox6.DataBindings.Add("Text", bindp, "ReorderLevel");
            ////textBox7.DataBindings.Add("Text", bindp, "Discontinued");
            //checkBox1.DataBindings.Add("Checked", bindp, "Discontinued");


            //comboBox1.DataSource = dtsup;
            //comboBox1.DisplayMember = "CompanyName";
            //comboBox1.ValueMember = "Sid";

            //comboBox2.DataSource = dtcat;
            //comboBox2.DisplayMember = "CategoryName";
            //comboBox2.ValueMember = "Cid"; 
            #endregion


            sqlcn = new(ConfigurationManager.ConnectionStrings["pubscn"].ConnectionString);
            //sqlcmd = new SqlCommand(@"select * from publishers", sqlcn);
            sqlcmd = new SqlCommand(@"select * from Titles", sqlcn);
            sqlDa = new SqlDataAdapter(sqlcmd);
            SqlCommandBuilder builder= new SqlCommandBuilder(sqlDa);
            sqlDa.UpdateCommand = builder.GetUpdateCommand();
            sqlDa.InsertCommand = builder.GetInsertCommand();
            sqlDa.DeleteCommand= builder.GetDeleteCommand();
            dt= new DataTable();
            sqlDa.Fill(dt);


            grd1.DataSource = dt;

            Trace.WriteLine(dt.Rows[0].GetType());


        }

        private void saveData_Click(object sender, EventArgs e)
        {
            sqlDa.Update(dt);
        }
    }
}
