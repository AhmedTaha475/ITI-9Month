using D13_SD43_BLL.Entities;
using D13_SD43_BLL.EntityList;
using D13_SD43_DAL;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13_SD43_BLL.EntityManager
{
    public class TitleManager
    {
        static DateTime defaultDate=new DateTime(2000,1,1);
       static DBManager dbManager = new DBManager();

        public static TitleList SelectAllTitles()
        {

            TitleList titleLst= new TitleList();
            try
            {

              return DataTableToTitleList( dbManager.ExecuteDataTable("SelectAllTitles"));


            }
            catch (Exception)
            {

                return new TitleList();
            }

        }

        public static Title SelectTitleByID(string id)
        {

            try
            {
                Dictionary<string, object> Param = new Dictionary<string, object>() { ["@title_id"] = id };

                return DataTableToTitleList(dbManager.ExecuteDataTable("SelectTitleByID", Param))[0];

            }
            catch (Exception)
            {


            }
            return new Title();


        }

        public static bool InsertTitle(string id,string title,string type,string pub_id,decimal? price,decimal? advance,int? royl,int? ytd,string notes,DateTime pubDate)
        {

            try
            {

                Dictionary<string,object> param= new Dictionary<string, object>()
                { ["@title_id"] = id, ["@title"] = title,
                    ["@type"]=type, ["@pub_id"] = pub_id, ["@price"] = price,
                    ["@advance"] = advance, ["@royalty"] = royl,
                    ["@ytd_sales"] = ytd,
                    ["@notes"] = notes,
                    ["@pubdate"]=pubDate  };
                return dbManager.ExecuteNonQuery("InsertTitle", param) > 0;
                   
    
            }
            catch (Exception)
            {

                
            }
            return false;

        }
        public static bool UpdateTitle(string id, string title, string type, string pub_id, decimal? price, decimal? advance, int? royl, int? ytd, string notes, DateTime pubDate)
        {

            try
            {

                Dictionary<string, object> param = new Dictionary<string, object>()
                {
                    ["@title_id"] = id,
                    ["@title"] = title,
                    ["@type"] = type,
                    ["@pub_id"] = pub_id,
                    ["@price"] = price,
                    ["@advance"] = advance,
                    ["@royalty"] = royl,
                    ["@ytd_sales"] = ytd,
                    ["@notes"] = notes,
                    ["@pubdate"] = pubDate
                };
                return dbManager.ExecuteNonQuery("UpdateTitle", param) > 0;


            }
            catch (Exception)
            {


            }
            return false;

        }


        public static bool DeleteTitle(string id)
        {

            try
            {

                Dictionary<string, object> param = new Dictionary<string, object>()
                {
                    ["@title_id"] = id
                };
                return dbManager.ExecuteNonQuery("DeleteTitle", param) > 0;


            }
            catch (Exception)
            {


            }
            return false;

        }




        #region Mapping
        public static TitleList DataTableToTitleList(DataTable dt)
        {
            TitleList lst = new TitleList();
            try
            {

                foreach (DataRow dr in dt.Rows)
                {
                    lst.Add(DataRowToTitle(dr));
                }

            }
            catch (Exception)
            {


            }
            return lst;

        }


        public static Title DataRowToTitle(DataRow dr)
        {
            Title t1 = new Title();

            try
            {
                t1.TitleId = dr["title_id"]?.ToString() ?? "NA";
                t1.TitleName = dr["title"]?.ToString() ?? "NA";
                t1.Type = dr["type"]?.ToString() ?? "NA";
                t1.PublisherId = dr["pub_id"]?.ToString() ?? "NA";
                if (decimal.TryParse(dr["price"]?.ToString() ?? "-1", out decimal tempDecimal))
                    t1.Price = tempDecimal;
                if (decimal.TryParse(dr["advance"]?.ToString() ?? "-1", out tempDecimal))
                    t1.Advance = tempDecimal;
                if (int.TryParse(dr["royalty"]?.ToString() ?? "-1", out int tempint))
                    t1.Royalty = tempint;
                if (int.TryParse(dr["ytd_sales"]?.ToString() ?? "-1", out tempint))
                    t1.YearToDateSales = tempint;

                t1.Notes = dr["notes"]?.ToString() ?? "NA";

                if (DateTime.TryParse(dr["pubdate"]?.ToString() ?? "-1", out DateTime tempDate))
                    t1.PublicationDate = tempDate;

                t1.RowState = EntityState.UnChanged;
            }
            catch (Exception)
            {


            }
            return t1;

        } 
        #endregion

    }




   
}
