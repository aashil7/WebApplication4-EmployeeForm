using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApplication4.Models;

namespace WebApplication4.Repository
{
    public class Common
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }

        public List<AppRefData> GetAppRefData(int parentId)
        {
            List<AppRefData> appRefList = new List<AppRefData>();

            Connection();
            SqlCommand cmd = new SqlCommand("GetAppRefData_Training_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ProjectId", DbType.Int32);
            param[0].Value = parentId;

            cmd.Parameters.AddRange(param);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                appRefList.Add(

                    new AppRefData
                    {
                        KeyID = Convert.ToInt32(dr["KeyID"]),
                        KeyName = Convert.ToString(dr["KeyName"])
                    }

                    );
            }

            return appRefList;
        }

    }
}
    