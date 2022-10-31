using System;
using System.Data;
using RoadBook.CsharpBasic.Chapter10.Manager;
using RoadBook.CsharpBasic.Chapter10.Models;

namespace RoadBook.CsharpBasic.Chapter10.Web.Board
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo = new DatabaseInfo();
            dbInfo.Name = "RoadBookDB";
            dbInfo.Ip = "127.0.0.1";
            dbInfo.Port = 1433;
            dbInfo.UserId = "sa";
            dbInfo.UserPassword = "didtmdrb67";

            MsSqlManager ms = new MsSqlManager();
            ms.Open(dbInfo);

            DataTable dt = ms.Select(" SELECT IDX, TITLE, SMMARY, CREATE_DT, CREATE_USER_NM, TAGS, LIKE_CNT, CATEGORY_IDX FROM TB_CONTENTS");

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}