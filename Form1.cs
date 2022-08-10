using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//34669205 CR Botha

namespace _34669205_SU2_Act2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\2 - CMPG 212 2021\34669205_SU2_Act2\Movies.mdf;Integrated Security=True");
        SqlDataAdapter adapter;
        DataSet dataset;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {                               
                MessageBox.Show("Connected Successfully", "Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = @"SELECT Genre FROM MovieTable";
                command.CommandText = query;

                SqlDataReader datareader = command.ExecuteReader();

                cbxGenreList.Items.Clear();
                while (datareader.Read())
                {
                    if (!cbxGenreList.Items.Contains(datareader["Genre"].ToString()))
                    {
                        cbxGenreList.Items.Add(datareader["Genre"].ToString());
                    }
                }

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand sql = new SqlCommand(@"SELECT * FROM MovieTable ", con);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                adapter.SelectCommand = sql;
                adapter.Fill(dataset, "MovieTable");

                dataGridView.DataSource = dataset;
                dataGridView.DataMember = "MovieTable";

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDisplayGood_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand sql = new SqlCommand(@"SELECT * FROM MovieTable WHERE Rating > 3 ", con);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                adapter.SelectCommand = sql;
                adapter.Fill(dataset, "MovieTable");

                dataGridView.DataSource = dataset;
                dataGridView.DataMember = "MovieTable";

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxGenreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand command = new SqlCommand(@"SELECT * FROM MovieTable WHERE Genre = '"+cbxGenreList.Text+"'", con);

            command.ExecuteNonQuery();
            SqlDataReader datareader;
            datareader = command.ExecuteReader();

            lbxViewGenres.Items.Clear();
            lbxViewGenres.Items.Add("ID\tMovie\t\tRating\tPrice\n");
            lbxViewGenres.Items.Add("---------------------------------------------------------------------------------");
            while (datareader.Read())
            { 
                lbxViewGenres.Items.Add(datareader.GetValue(0) + "\t" + datareader.GetValue(1) + "\t" + datareader.GetValue(3) + "\t" + datareader.GetValue(4));
            }

            con.Close();
        }
    }
}
