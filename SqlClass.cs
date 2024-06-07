
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace pLevnon
{
    public class SqlClass
    {
        public static string Execute(string query)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[1].ConnectionString;//מחרוזת התחברות שאומרת באיזה שרת של מסד נתונים עובדים- אס קיו אל ואיפה הוא שמור

            //make the connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))// קונקשן היא מחלקה שבה מוגדרות פעולות שעוזרות לנו להתחבר למסד הנתונים
            {
                connection.Open();//open the connection
                SqlCommand sqlCommand = new SqlCommand(query, connection);// .מחלקה שעובדת על ביצוע פעולות על מסד הנתונים. היא צריכה את השאילתה והחיבור למסד הנתונים
                var sqlResultsObj = sqlCommand.ExecuteScalar();
                string sqlResults = null;
                if (sqlResultsObj != null)
                {
                    sqlResults = sqlResultsObj.ToString();
                }
                
                if (!string.IsNullOrEmpty(sqlResults))
                    return sqlResults;
            }

           return null;
        }
    }
}