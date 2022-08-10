using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;

// Caitlin Botha 34669205

namespace _34669205_Assessment2
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ClientData.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie userCookie = Request.Cookies["User"];

            if(userCookie != null)
            {
                string name, pass;
                name = userCookie["Username"];
                pass = userCookie["Password"];

                if(cookieValidation(name,pass))
                {
                    Response.Redirect("Workshop.aspx");
                }
            }
        }

        private bool cookieValidation(string username, string password)
        {
            bool valid = false;

            try
            {
                con.Open();

                command = new SqlCommand($"SELECT * FROM ClientData WHERE Username = '{username}' AND Password = '{password}'", con);
                reader = command.ExecuteReader();

                if(reader.Read())
                {
                    valid = true;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                lblIncorrect.Text = ex.Message;                 
            }

            return valid;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtbUsername.Text;
            password = txtbPassword.Text;

            if(cookieValidation(username, password))
            {
                HttpCookie userCookie = new HttpCookie("User");

                userCookie["Username"] = username;
                userCookie["Password"] = password;

                if(cbxRemeber.Checked)
                {
                    userCookie.Expires = DateTime.Now.AddDays(2);
                }

                Response.Cookies.Add(userCookie);
                Response.Redirect("Workshop.aspx");
            }
            else
            {
                lblIncorrect.Text = "User information incorrect.";
            }
        }
    }
}

