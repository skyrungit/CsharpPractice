using System.Data;
using System.Data.SqlClient;
using RoadBook.CsharpBasic.Chapter10.Models;

namespace RoadBook.CsharpBasic.Chapter10.Manager
{
    public class MsSqlManager : IDatabaseManager
    {
        //OPEN
        SqlConnection connection = null;
        public void Open(DatabaseInfo dbInfo)
        {
            string conStr = string.Format("Data Source = {0}, {1}; Initial Catalog = {2}; User ID = {3}; Password = {4}",
                                            dbInfo.Ip, dbInfo.Port, dbInfo.Name, dbInfo.UserId, dbInfo.UserPassword);
            connection = new SqlConnection(conStr); //Created at the 1st line of OPEN
            connection.Open();
        }

        //SELECT
        public DataTable Select(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    for (int idx = 0; idx < reader.FieldCount; idx++)
                    {
                        dt.Columns.Add(new DataColumn(reader.GetName(idx)));
                    }
                    while (reader.Read()) //한 줄 을 읽고 data가 없으면 false return
                    {
                        DataRow row = dt.NewRow();

                        for (int idx = 0; idx < dt.Columns.Count; idx++)
                        {
                            row[dt.Columns[idx]] = reader[dt.Columns[idx].ColumnName]; //이해 안 됨
                        }
                        dt.Rows.Add(row);
                    }
                }
            }
    
            return dt;
        }
        public int Insert(string sql)
        {
            int activeNumber = 0;
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                activeNumber = command.ExecuteNonQuery();
            }
            return activeNumber;
        }

        public int Delete(string sql)
        {
            int activeNumber = 0;
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                activeNumber = command.ExecuteNonQuery();
            }
            return activeNumber;
        }
        public int Update(string sql)
        {
            int activeNumber = 0;
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                activeNumber = command.ExecuteNonQuery();
            }
            return activeNumber;
        }
        public void Close()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
