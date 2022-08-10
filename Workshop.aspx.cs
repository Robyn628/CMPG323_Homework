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
    public partial class Workshop : System.Web.UI.Page
    {

        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|ClientData.mdf;Integrated Security=True");
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public DataSet dataset;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                HttpCookie logCookie = Request.Cookies["User"];

                if(logCookie != null)
                {
                    lblWelcomeUser.Text = logCookie["Username"];
                    GridUpdate();
                }
            }
            catch (SqlException error)
            {
                lblError.Text = error.Message;
            }
        }

        private void GridUpdate()
        {
            HttpCookie loginCookie = Request.Cookies["User"];

            try
            {
                con.Open();

                command = new SqlCommand(@"SELECT Username, Convert(VarChar, WorkshopDate, 6), Java, CSharp, CPP FROM ClientData WHERE Username = '" + loginCookie["Username"] + "' AND Password = '" + loginCookie["Password"] + "'", con);

                dataset = new DataSet();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataset, "ClientData");

                GridView.DataSource = dataset;
                GridView.DataMember = "ClientData";
                GridView.DataBind();

                con.Close();
            }
            catch (SqlException error)
            {
                lblError.Text = error.Message;
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = Calendar.SelectedDate;
                string d = dt.ToString("dd MMMM yyyy");

                HttpCookie logCookie = Request.Cookies["User"];

                if(logCookie != null)
                {
                    con.Open();

                    command = new SqlCommand($"UPDATE ClientData SET Java = '{rbtnJava.Checked}', CSharp = '{rbtnCSharp.Checked}'" +
                        $", CPP = '{rbtnCPP.Checked}', WorkshopDate = '{d}' WHERE Username = '{logCookie["Username"]}'", con);
                    command.ExecuteNonQuery();

                    con.Close();
                    GridUpdate();
                }

                imgWorkshop.Visible = true;
                lblThankYou.Visible = true;
            }
            catch (SqlException error)
            {
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Text = error.Message;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            HttpCookie userCookie = Request.Cookies["User"];
            userCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(userCookie);

            imgWorkshop.Visible = false;
            lblThankYou.Visible = false;
            Response.Redirect("Login.aspx");
        }
    }
}