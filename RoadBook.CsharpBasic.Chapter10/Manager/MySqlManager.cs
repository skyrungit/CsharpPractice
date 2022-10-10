using System.Data;
using RoadBook.CsharpBasic.Chapter10.Models;

namespace RoadBook.CsharpBasic.Chapter10.Manager
{
    public class MySqlManager : IDatabaseManager
    {
        public void Open(DatabaseInfo dbInfo)
        {
            throw new System.NotImplementedException();
        }
        public DataTable Select(string sql)
        {
            throw new System.NotImplementedException();
        }

        public int Insert(string sql)
        {
            throw new System.NotImplementedException();
        }

        public int Update(string sql)
        {
            throw new System.NotImplementedException();
        }
        public int Delete(string sql)
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }
    }
}
