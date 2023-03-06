using D13_SD43_BLL.EntityList;
using D13_SD43_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using D13_SD43_BLL.Entities;
namespace D13_SD43_BLL.EntityManager
{
    public class PublisherManager
    {

     static DBManager Manager =new();

        public static PublisherList SelectAllPublishers()
        {

            try
            {
             return DataTableToProductList(Manager.ExecuteDataTable("SelectAllPublishers"));

            }
            catch (Exception)
            {

                return new PublisherList();
            }

        }

        public static Entities.Publisher SelectPublisherByID(int id)
        {

            try
            {
            Dictionary<string,object> Param = new Dictionary<string, object>() { ["@pub_id"]=id};

                return DataTableToProductList(Manager.ExecuteDataTable("SelectPublisherByID", Param))[0];

            }
            catch (Exception)
            {

                
            }
            return new Entities.Publisher();


        }


        public static bool InsertPublisher(string id,string pub_Name,string country,string city,string state)
        {
            try
            {
                Dictionary<string,object> param= new Dictionary<string, object>() { ["@pub_id"] = id, ["pub_Name"] = pub_Name, ["@country"] = country, ["@city"] = city, ["@state"]=state };

                return Manager.ExecuteNonQuery("InsertPublisher", param) > 0;
            }
            catch (Exception)
            {

               
            }
            return false;



        }

        public static bool UpdatePublisher (string id, string pub_Name, string country, string city, string state)

        {
            try
            {

                Dictionary<string, object> param = new Dictionary<string, object>() { ["@pub_id"] = id, ["pub_Name"] = pub_Name, ["@country"] = country, ["@city"] = city, ["@state"] = state };

                return Manager.ExecuteNonQuery("UpdatePublisher", param) > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }


        public static bool DeletePublisher(string id)

        {
            try
            {

                Dictionary<string, object> param = new Dictionary<string, object>() { ["@pub_id"] = id };

                return Manager.ExecuteNonQuery("DeletePublisher", param) > 0;
            }
            catch (Exception)
            {

            }
            return false;
        }

        #region Mapping Of Publisher OFC
        public static PublisherList DataTableToProductList(DataTable dt)
        {

            PublisherList list = new PublisherList();
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(FromDataRowToPublisher(dr));
                }

            }
            catch (Exception)
            {


            }
            return list;


        }


        public static Entities.Publisher FromDataRowToPublisher(DataRow dr)
        {

            Entities.Publisher pub1 = new();
            try
            {
                pub1.Pub_id = dr["pub_id"]?.ToString() ?? "NA";
                pub1.Pub_Name = dr["pub_Name"]?.ToString() ?? "NA";
                pub1.Country = dr["country"]?.ToString() ?? "NA";
                pub1.State = dr["state"]?.ToString() ?? "NA";
                pub1.City = dr["city"]?.ToString() ?? "NA";
                pub1.RowState = EntityState.UnChanged;
            }
            catch (Exception)
            {


            }

            return pub1;
        } 
        #endregion


    }
}
