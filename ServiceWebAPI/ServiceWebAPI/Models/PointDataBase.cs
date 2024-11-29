
using Microsoft.Data.SqlClient;

namespace ServiceWebAPI.Models
{
    public class PointDataBase
    {
       //Подключение к серверу с БД
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=127.0.0.1,1433; User Id=sa;Password=ServerDB_MSSql;Initial Catalog=ServerDB; Integrated Security=False;TrustServerCertificate=True;");
        public void openConnection() //Открывает соединения
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closedConnection()  //Закрывает соединения
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection() => sqlConnection; //Передача соединения
    }
}
