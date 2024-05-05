using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class supervisorcover : System.Web.UI.Page
{
    string username = "f1";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Connection string
            string connectionString = "Data Source=DESKTOP-P0QGTM9\\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

            // SQL query to retrieve supervisor's profile information
            string query = "SELECT FacultyID, FirstName, LastName, Field, PhoneNumber " +
                           "FROM Faculty " +
                           "WHERE FacultyID = @username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Set retrieved values to the labels
                        Label7.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                        Label8.Text = reader["FacultyID"].ToString();
                        Label9.Text = reader["Field"].ToString();
                        Label10.Text = reader["PhoneNumber"].ToString();
                    }
                    else
                    {
                        // Handle case where no data is found
                        // You can display a message or take other action
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                // Display or log error message
            }
        }
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentdeadlines.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("supervisorgroups.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("supervisorreview.aspx");
    }
}