using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class panelcover : System.Web.UI.Page
{
    string username = "f1";
    protected void Page_Load(object sender, EventArgs e)
    {
        //string username = Request.QueryString["username"] ?? "";

        // Validate username here if necessary

        // Execute SQL query to fetch panel member's profile information
        string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";
        string query = "SELECT FacultyID, FirstName, LastName, Field, PhoneNumber FROM Faculty WHERE FacultyID = @FacultyID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FacultyID", username);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Set the profile information to the corresponding Label controls
                    Label7.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                    Label8.Text = reader["FacultyID"].ToString();
                    Label9.Text = reader["Field"].ToString();
                    Label10.Text = reader["PhoneNumber"].ToString();
                }

                reader.Close();
            }
        }
    }
}