using System;
using System.Text;
using RoadBook.CsharpBasic.Chapter10.Manager;
using RoadBook.CsharpBasic.Chapter10.Models;

namespace RoadBook.CsharpBasic.Chapter10.Web.Board
{
    public partial class New : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseInfo dbInfo = new DatabaseInfo();
            dbInfo.Name = "RoadbookDB";
            dbInfo.Ip = "127.0.0.1";
            dbInfo.Port = 1433;
            dbInfo.UserId = "sa";
            dbInfo.UserPassword = "didtmdrb67";

            MsSqlManager ms = new MsSqlManager();
            ms.Open(dbInfo);

            StringBuilder sbSQL = new StringBuilder(); //이거 찾아보자
            sbSQL.Append(" INSERT TB_CONTENTS (TITLE, SMMARY, CREATE_DT, CREATE_USER_NM, TAGS, CATEGORY_IDX) ");
            sbSQL.Append(string.Format(" VALUES( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}' ) ", txtTitle.Text, txtSummary.Text, DateTime.Now.ToString("yyyy-MM-dd"), txtUserNm.Text, txtTags.Text, 2));

            ms.Insert(sbSQL.ToString());

            Response.Redirect("Default.aspx");
        }
    }
}
