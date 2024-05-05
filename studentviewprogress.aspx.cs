using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class studentviewprogress : System.Web.UI.Page
{
    string username;
    string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            username = Request.QueryString["username"];
            username = "s2";

            // Retrieve group name for the current student
            string groupName = GetGroupName(username);

            // Fetch progress details for the group
            if (!string.IsNullOrEmpty(groupName))
            {
                string progressDateQuery = "SELECT p.datee FROM Progress p " +
                                           "JOIN StudentGroup sg ON p.Username = sg.StudentUsername " +
                                           "WHERE sg.GroupName = @GroupName";

                string progressAchievementQuery = "SELECT p.Descriptionn FROM Progress p " +
                                                  "JOIN StudentGroup sg ON p.Username = sg.StudentUsername " +
                                                  "WHERE sg.GroupName = @GroupName";

                string supervisorFeedbackQuery = "SELECT p.SupervisorReview FROM Progress p " +
                                                 "JOIN StudentGroup sg ON p.Username = sg.StudentUsername " +
                                                 "WHERE sg.GroupName = @GroupName";

                string usernameQuery = "SELECT s.Namee FROM Progress p " +
                                       "JOIN StudentGroup sg ON p.Username = sg.StudentUsername " +
                                       "JOIN Student s ON sg.StudentUsername = s.Username " +
                                       "WHERE sg.GroupName = @GroupName";

                // Execute the queries and bind the results to GridView3
                BindGridView(progressDateQuery, progressAchievementQuery, supervisorFeedbackQuery, usernameQuery, groupName);
            }
            else
            {
                // Handle the case where group name is not found
                // You can show a message or perform any other action here
            }
        }
    }

    // Method to retrieve group name for the current student
    private string GetGroupName(string username)
    {
        // Query to retrieve group name for the given username
        string query = "SELECT g.GroupName " +
                       "FROM StudentGroup g " +
                       "JOIN Student s ON g.StudentUsername = s.Username " +
                       "WHERE s.Username = @Username";

        string groupName = null;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameter for username
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    groupName = (string)command.ExecuteScalar(); // Assuming GroupName is of type string
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        return groupName;
    }

    // Method to execute queries and bind data to GridView
    private void BindGridView(string progressDateQuery, string progressAchievementQuery, string supervisorFeedbackQuery, string usernameQuery, string groupName)
    {
        // Create a DataTable to store the retrieved data
        DataTable dataTable = new DataTable();

        // Create columns for the DataTable
        dataTable.Columns.Add("StudentName", typeof(string));
        dataTable.Columns.Add("datee", typeof(DateTime));
        dataTable.Columns.Add("Descriptionn", typeof(string));
        dataTable.Columns.Add("SupervisorReview", typeof(string));

        // Create a SqlConnection
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Open the connection
            connection.Open();

            // Execute the progressDateQuery
            using (SqlCommand command = new SqlCommand(progressDateQuery, connection))
            {
                // Add parameter for group name
                command.Parameters.AddWithValue("@GroupName", groupName);
                // Execute the query and retrieve the data
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Add a new row for each record
                        DataRow row = dataTable.NewRow();
                        row["datee"] = reader.GetDateTime(0);
                        dataTable.Rows.Add(row);
                    }
                }
            }

            // Execute the progressAchievementQuery
            using (SqlCommand command = new SqlCommand(progressAchievementQuery, connection))
            {
                // Add parameter for group name
                command.Parameters.AddWithValue("@GroupName", groupName);
                // Execute the query and update the existing rows in the DataTable
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read() && i < dataTable.Rows.Count)
                    {
                        dataTable.Rows[i]["Descriptionn"] = reader.GetString(0);
                        i++;
                    }
                }
            }

            // Execute the supervisorFeedbackQuery
            using (SqlCommand command = new SqlCommand(supervisorFeedbackQuery, connection))
            {
                // Add parameter for group name
                command.Parameters.AddWithValue("@GroupName", groupName);
                // Execute the query and update the existing rows in the DataTable
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read() && i < dataTable.Rows.Count)
                    {
                        // Check for DBNull before reading the value
                        if (!reader.IsDBNull(0))
                        {
                            dataTable.Rows[i]["SupervisorReview"] = reader.GetString(0);
                        }
                        else
                        {
                            dataTable.Rows[i]["SupervisorReview"] = "-";
                        }
                        i++;
                    }
                }
            }

            // Execute the usernameQuery
            using (SqlCommand command = new SqlCommand(usernameQuery, connection))
            {
                // Add parameter for group name
                command.Parameters.AddWithValue("@GroupName", groupName);
                // Execute the query and update the existing rows in the DataTable
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read() && i < dataTable.Rows.Count)
                    {
                        dataTable.Rows[i]["StudentName"] = reader.GetString(0);
                        i++;
                    }
                }
            }
        }

        // Bind the DataTable to GridView3
        GridView3.DataSource = dataTable;
        GridView3.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentprogress.aspx?username=" + username);
    }
    
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentdeadlines.aspx?username=" + username);
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentreview.aspx?username=" + username);
    }
}
