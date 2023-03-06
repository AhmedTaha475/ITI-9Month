using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13_SD43_DAL
{
    public class DBManager
    {
        SqlConnection sqlCn;
        SqlCommand sqlcmd;
        SqlDataAdapter sqlDA;
        DataTable DT;

        public DBManager()
        {
            try
            {
                sqlCn = new SqlConnection(ConfigurationManager.ConnectionStrings["PubsCn"].ConnectionString);
                sqlcmd = new SqlCommand();
                sqlcmd.Connection= sqlCn;
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlDA = new SqlDataAdapter(sqlcmd);
                DT = new DataTable();

            }
            catch (Exception)
            {

                ///
            }
        }



        public int ExecuteNonQuery(string storedName)
        {

            try
            {
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = storedName;
                if(sqlCn.State==ConnectionState.Closed)
                    sqlCn.Open();
                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return -1;
            }

            finally { sqlCn.Close(); }

        }

        public int ExecuteNonQuery(string storedName,Dictionary<string,object> paramList) 
        {

            try
            {
                sqlcmd.Parameters.Clear();
                foreach (var item in paramList)
                    sqlcmd.Parameters.Add(new SqlParameter(item.Key,item.Value));
                sqlcmd.CommandText=storedName;

                 if(sqlCn.State==ConnectionState.Closed)
                    sqlCn.Open();

                return sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return -1;
            }
            finally { sqlCn.Close(); }  
        }


        public object ExecuteScalar(string storedName)
        {

            try
            {
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = storedName;

                if(sqlCn.State==ConnectionState.Closed)
                        sqlCn.Open();

                return sqlcmd.ExecuteScalar();

            }
            catch (Exception)
            {

                return new();
            }
            finally { sqlCn.Close(); }

        }

       public object ExecuteScalar ( string storedName , Dictionary<string, object> paramList)
        {

            try
            {
                sqlcmd.Parameters.Clear ();
                sqlcmd.CommandText = storedName;

                foreach (var item in paramList)
                {
                    sqlcmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }

                if(sqlCn.State==ConnectionState.Closed)
                    sqlCn.Open();

                return sqlcmd.ExecuteScalar();
            }
            catch (Exception)
            {

                return new();
            }
            finally
            {
                sqlCn.Close();
            }

        }



        public DataTable ExecuteDataTable (string storedName)
        {
            try
            {
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText= storedName;
                
                DT.Clear();
                sqlDA.Fill(DT);

                return DT;

            }
            catch (Exception)
            {

                return new();
            }
        }


        public DataTable ExecuteDataTable (string storedName,Dictionary<string, object> paramList)
        {

            try
            {
                sqlcmd.Parameters.Clear();
                DT.Clear();
                foreach (var item in paramList)
                {
                    sqlcmd.Parameters.Add(new SqlParameter(item.Key,item.Value));
                }
                sqlDA.Fill (DT);


                return DT;
            }
            catch (Exception)
            {

                return new();
            }


        }


    }
}
