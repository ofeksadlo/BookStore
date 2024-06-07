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
    public partial class AdminPage : System.Web.UI.Page
    {
        DataSet dataset = new DataSet();
        public string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["category"] != "admin")
            {
                Response.Redirect("Login.aspx");
            }
            string comnandUsrString = "SELECT* FROM Users";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(comnandUsrString, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataset);

                if (!IsPostBack)
                    ShowUserData(dataset);
            }

        }
        public void ShowUserData(DataSet dataSet)
        {
            LblShowusers.Text = "<table style='margin: auto'><tr><tr>username</th><th>password</th><th>firstname</th><th>lastname</th><th>adress</th><th>email</th><th>year</th></tr>";
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                LblShowusers.Text += "<tr>";
                LblShowusers.Text += "<td>" + row["username"].ToString() + "</td>";
                LblShowusers.Text += "<td>" + row["password"].ToString() + "</td>";
                LblShowusers.Text += "<td>" + row["firstname"].ToString() + "</td>";
                LblShowusers.Text += "<td>" + row["lastname"].ToString() + "</td>";
                LblShowusers.Text += "<td>" + row["year"].ToString() + "</td>";
                LblShowusers.Text += "<td>" + row["adress"].ToString() + "</td>";
                LblShowusers.Text += "<td>" + row["email"].ToString() + "</td>";
                LblShowusers.Text += "</tr>";
            }
            LblShowusers.Text += "</table>";
        }
        DataSet dataset2 = new DataSet();
        protected void BtnLastName_click(object sender, EventArgs e)
        {
            dataset.Clear();
            //BindUserList(dataset);
            string commandUsrString = "SELECT * FROM UsersTbl order by LastName";
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(commandUsrString, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataset, "Users");
                ShowUserData(dataset);
            }
  
        }
        void BindUsersList(DataSet dataSet)
        {
            DdlCities.DataSource = dataSet.Tables["Users"];
            DdlCities.DataTextField = "Address";
            DdlCities.DataValueField = "Address";
            DdlCities.DataBind();

        }
        protected void BtnCity_Click(object sender, EventArgs e)
        {
            dataset.Clear();
            string selectedCity = DdlCities.SelectedValue;
        }
        protected void DdlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataset.Clear();
            string selectedCity = DdlCities.SelectedValue;

            string commandUsrString = $"SELECT * FROM UsersTbl where address='{selectedCity}'";
            string connetionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(commandUsrString, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataset, "Users");
                ShowUserData(dataset);
            }
        }





    }
}