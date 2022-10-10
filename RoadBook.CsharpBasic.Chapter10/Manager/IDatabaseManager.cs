using System.Data;
using RoadBook.CsharpBasic.Chapter10.Models;

namespace RoadBook.CsharpBasic.Chapter10.Manager
{
    public interface IDatabaseManager
    {
        void Open(DatabaseInfo dbInfo);
        DataTable Select(string sql);
        int Insert(string sql);
        int Update(string sql);
        int Delete(string sql);
        void Close();
    }
}
