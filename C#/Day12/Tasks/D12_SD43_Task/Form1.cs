using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;

namespace D12_SD43_Task
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
           
        }

        SqlConnection SqlCn;

        SqlCommand SqlCmd;
        SqlDataAdapter sqlDp;


        SqlCommand SqlCmd_Sup;
        SqlDataAdapter sqlDp_Sup;

        SqlCommand sqlcmd_cat;
        SqlDataAdapter sqlDp_cat;


        DataTable DT;
        DataTable DT_Supply;
        DataTable DT_cat;


        DataGridViewComboBoxColumn catCol;
        DataGridViewComboBoxColumn supColumn;


        static int counter = 0;
        private void frm1_Load(object sender, EventArgs e)
        {
 
        }

        private void loadMenu_Click(object sender, EventArgs e)
        {
            SqlCn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindcs"].ConnectionString);
            #region ProductTable
            SqlCmd = new SqlCommand(@"select * from products", SqlCn);
            sqlDp = new SqlDataAdapter(SqlCmd);
            SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(sqlDp);
            sqlDp.InsertCommand = sqlBuilder.GetInsertCommand();
            sqlDp.UpdateCommand = sqlBuilder.GetUpdateCommand();
            sqlDp.DeleteCommand = sqlBuilder.GetDeleteCommand();
            DT = new DataTable();
            sqlDp.Fill(DT);
            
            #endregion

            #region SupplierTable
            SqlCmd_Sup = new SqlCommand(@"select * from Suppliers", SqlCn);
            sqlDp_Sup = new SqlDataAdapter(SqlCmd_Sup);
            DT_Supply= new DataTable();
            sqlDp_Sup.Fill(DT_Supply);
            #endregion


           

            grd.DataSource = DT;
            grd.Columns["ProductID"].ReadOnly = true;
            grd.Columns["SupplierID"].Visible = false;
            grd.Columns["CategoryID"].Visible = false;
            #region Mapping Supplier ID to the ComanyName
            
            supColumn = new DataGridViewComboBoxColumn();
            supColumn.HeaderText = "Supplier";
            supColumn.DataSource = DT_Supply;
            supColumn.ValueMember = "SupplierID";
            supColumn.DisplayMember = "CompanyName";
            supColumn.DataPropertyName = "SupplierID";


            if(counter==0)
            {
                grd.Columns.Add(supColumn);
            }
            #endregion

            #region Getting the Category cmd,DataAdapter
            catCol = new DataGridViewComboBoxColumn();
            sqlcmd_cat = new SqlCommand(@"select * from Categories", SqlCn);
            sqlDp_cat = new SqlDataAdapter(sqlcmd_cat);
            DT_cat= new DataTable();
            sqlDp_cat.Fill(DT_cat);

            #endregion

            #region Mapping Category ID to the Category Name 

            
            catCol.HeaderText = "Category";

            if (counter==0)
            {
                grd.Columns.Add(catCol);
               
            }
            catCol.DataSource = DT_cat;
            catCol.DisplayMember = "CategoryName";
            catCol.ValueMember = "CategoryID";
            catCol.DataPropertyName = "CategoryID";


            Debug.WriteLine( grd.Columns.Contains(catCol));
            counter++;
            #endregion
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            grd.EndEdit();
            try
            {
            sqlDp.Update(DT);

            }catch(Exception ex)
            {
                MessageBox.Show("Couldn't perform The Previous Action ","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}