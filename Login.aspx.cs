using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pLevnon
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text,
                       password = TxtPassword.Text;

            //if (username == "admin" && password == "12345")
            //{
            //    //סשן הוא משתנה גלובלי פר משתמש כי משתמש רגיל רק לדף אחד וסשן לכל הדפים הוא נמחק אחרי 20 דקות
            //    Session["category"] = "admin";
            //    Session["username"] = username;
            //    //application();//פעולה שמגדילה את מספר המשמשים ב-1
            //    Response.Redirect("adminPage.aspx");
            //}
            string sqlResults = SqlClass
                .Execute("SELECT password FROM UsersTable WHERE username ='"+username+"'");
            
            if (string.IsNullOrEmpty(sqlResults))//בדיקה אם שם המשתמש כבר קיים הוא מונה את כמות המשתמשים שקיימים בשם זה (1 או 0) בעמודה הראשונה
            {
                LblMessage.Text = "User doesn't exist";
                //Response.Redirect("Register.aspx");

            }
            else
            {
                sqlResults = sqlResults.Replace(" ", string.Empty);// מחיקת רווחים מיותרים
                if (password == sqlResults)
                {
                    string clientFullName = SqlClass
                .Execute("SELECT firstname + ' ' + lastname FROM UsersTable WHERE username = '"+username+"'");
                    Session["clientFullName"] = clientFullName;
                    Session["username"] = username;
                    Session["category"] = "user";//מי שבאתר עכשיו הוא משתמש ולא מנהל

                    Response.Redirect("Homepage.aspx");
                }
                else
                {
                    LblMessage.Text = "Password is incorrect";
                }
            }
        }

    }
}
