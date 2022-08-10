using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

// Caitlin Botha 34669205

namespace _34669205_Assessment2
{
    public partial class Register : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }    
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ClientData.mdf;Integrated Security=True");
        SqlCommand command;

        protected void btnRegister_Click(object sender, EventArgs e)
        {    
            try
            {
                con.Open();

                command = new SqlCommand($"INSERT INTO ClientData(Username,Password) VALUES ('" + txtbUser.Text + "', '" + txtbPass.Text + "')", con);                
                command.ExecuteNonQuery();

                con.Close();

                Response.Redirect("Login.aspx");
            }
            catch(SqlException error)
            {
                lblError.Text = error.Message;
            }
        }
    }
}