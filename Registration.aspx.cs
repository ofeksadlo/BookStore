      using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pLevnon
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                string username = TxtUsername.Text;
                string password = TxtPassword.Text;
                string firstname = TxtFirstName.Text;
                string lastname = TxtLastName.Text;
                string email = TxtEmail.Text;
                string address = TxtAddress.Text;
                int year = int.Parse(DdlYear.SelectedValue);

                string connectionString =
                    ConfigurationManager.ConnectionStrings[1].ConnectionString;
                string strCheckUsername = $"SELECT COUNT (*) FROM UsersTable WHERE username='{username}'";

                //creat the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand sqlCommend = new SqlCommand(strCheckUsername, connection);
                    //check if username exists
                    if ((int)sqlCommend.ExecuteScalar() > 0)
                    {
                        LblMessage.Text = "The username already exists";
                        return;

                    }
                }
                string cmdInsertString = $"INSERT INTO UsersTable values ('{username}','{password} ','{firstname} ','{email}','{lastname}',{year},'{address}')";
                //create the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(cmdInsertString, connection);
                    //execute query
                    sqlCommand.ExecuteNonQuery();
                }
                Session["clientFullName"] = firstname + " " + lastname;
                Response.Redirect("Homepage.aspx");
            }
            for (int i = 2016; i > 1930; i--)
            {
                DdlYear.Items.Add(i.ToString());

            }
        }

        protected void BtnRegistr_Click(object sender, EventArgs e)
        {

            
        }

    }
}