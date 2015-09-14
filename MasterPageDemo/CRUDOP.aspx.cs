using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageDemo
{
    public partial class CRUDOP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            int rowsInserted = 0;
            string query = String.Format(@"Insert into Users values(@name,@id)");
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@name", TextBox2.Text);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox1.Text));
                    connection.Open();
                    rowsInserted = command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            if (rowsInserted>0)
            {
                Label1.Text = "Information saved";
            }
            else
            {
                Label1.Text = "Not saved";
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            int rowsInserted = 0;
            string query = String.Format(@"Update Users set FullName=@name where id=@id");
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@name", TextBox2.Text);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox1.Text));
                    connection.Open();
                    rowsInserted = command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            if (rowsInserted > 0)
            {
                Label1.Text = "Information Updated";
            }
            else
            {
                Label1.Text = "Not Updated";
            }
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            int rowsInserted = 0;
            string query = String.Format(@"Delete from Users Where id=@Id");
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@name", TextBox2.Text);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox1.Text));
                    connection.Open();
                    rowsInserted = command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            if (rowsInserted > 0)
            {
                Label1.Text = "Information saved";
            }
            else
            {
                Label1.Text = "Not saved";
            }
        }
    }
}