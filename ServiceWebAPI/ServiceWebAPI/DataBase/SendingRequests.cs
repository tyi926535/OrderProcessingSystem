using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using ServiceWebAPI.Models;
using System.Data;

namespace ServiceWebAPI.DataBase
{
    public class SendingRequests
    {
        PointDataBase pointDataBase = new PointDataBase();

        public void SetRequest(string querySQL)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(querySQL, pointDataBase.GetConnection());
            adapter.SelectCommand = sqlCommand;
            adapter.Fill(dt);
        }
        public void GetRequest(string querySQL)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(querySQL, pointDataBase.GetConnection());
            adapter.SelectCommand = sqlCommand;
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        var item = row[column.ColumnName];
                    }
                }
            }
        }




        public DataTable SampleRequest(string querySQL,int index)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(querySQL, pointDataBase.GetConnection());
            adapter.SelectCommand = sqlCommand;
            adapter.Fill(dt);
            return dt;
        }
    }
}
