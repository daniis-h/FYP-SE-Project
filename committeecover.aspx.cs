using System;
using System.Data.SqlClient; // Import SQL Client
using System.Web.UI.WebControls;

public partial class committeecover : System.Web.UI.Page
{
    string username = "2474";

    protected void Page_Load(object sender, EventArgs e)
    {
        // Your SQL Connection String
        string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

        // Your SQL Query to retrieve faculty information
        string selectFacultyQuery = "SELECT FirstName, LastName, Field, PhoneNumber FROM Faculty WHERE FacultyID = @Username";

        // Initialize connection and command
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(selectFacultyQuery, connection);
            command.Parameters.AddWithValue("@Username", username);

            // Open connection and execute command
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Populate labels with retrieved information
                Label7.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                Label8.Text = username;
                Label9.Text = reader["Field"].ToString();
                Label10.Text = reader["PhoneNumber"].ToString();
            }
            else
            {
                // Handle if no faculty member is found with the given username
                // For example, you can display an error message or redirect the user
                // Response.Redirect("ErrorPage.aspx");
            }

            // Close the reader
            reader.Close();
        }
    }
}
