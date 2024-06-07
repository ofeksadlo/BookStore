using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pLevnon
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;//מחרוזת התחברות שאומרת באיזה שרת של מסד נתונים עובדים- אס קיו אל ואיפה הוא שמור
            ////make the connection to the database
            //using (SqlConnection connection = new SqlConnection(connectionString))// קונקשן היא מחלקה שבה מוגדרות פעולות שעוזרות לנו להתחבר למסד הנתונים
            //{
            //    connection.Open();
            //    clientFullName = new SqlCommand("SELECT ",connection)
            //}
        }

    }
}

