using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pLevnon
{
    public partial class UserPage : System.Web.UI.Page
    {
        DataSet dataSet = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                for (int i = DateTime.Now.Year-8; i < 1920; i++)
                {
                    DdlYear.Items.Add(i.ToString());
                }
                UserDetails();
            }

        }
        public void UserDetails()
        {
            string userUpdateCommand = $"SELECT * FROM UserTbl WHERE username='{Session["username"]}'";
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(userUpdateCommand, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);
            }
            ShowUserDetails();

        }

        public void ShowUserDetails()
        {
            foreach(DataRow row in dataSet.Tables[0].Rows)
            {
                LblUsername.Text = row["username"].ToString();
                TxtPassword.Text = row["password"].ToString();
                TxtFirstName.Text = row["firstName"].ToString();
                TxtLastName.Text = row["lastName"].ToString();
                TxtEmail.Text = row["email"].ToString();
                TxtAddress.Text = row["address"].ToString();

            }
        }
        protected void BtnUserUpdate_Click(object sender,EventArgs e)
        {
            string password = TxtPassword.Text;
            string firstname = TxtFirstName.Text;
            string lastname = TxtLastName.Text;
            string email = TxtEmail.Text;
            string address = TxtAddress.Text;
            int year = int.Parse(DdlYear.SelectedValue);

            string commandUpdateStr = $"UPDATE UserTbl SET Password='" + password + "', FirstName='" + firstname + "', LastName='" + lastname + "',Address='" + address + "',Email='" + email + "',BirthYear'" + year + "',WHERE Username='" + Session["Username"] + "'";
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(commandUpdateStr, connection);
                if (sqlCommand.ExecuteNonQuery()>0)
                {
                    LblMessage.Text = "Successfully Updated";
                }
            }
        }
    }
}