using System;
using System.Data;
using System.Data.SqlClient; // Assuming you're using SQL Server

public partial class committeeviewstudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) // Only bind data on initial load
        {
            BindGridView();
        }
    }

    protected void BindGridView()
    {
        // Connection string for your database
        string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

        // SQL query to get the main data
        string mainQuery = @"SELECT s.Namee AS StudentName,
                                    sg.GroupName,
                                    s.ProjectTitle,
                                    CONCAT(f.FirstName, ' ', f.LastName) AS SupervisorName
                                FROM Student s
                                JOIN StudentGroup sg ON s.Username = sg.StudentUsername
                                JOIN Supervisor su ON s.SupervisorID = su.FacultyID
                                JOIN Faculty f ON su.FacultyID = f.FacultyID";

        // Create a DataTable to hold the main query results
        DataTable dt = new DataTable();

        // Establish connection and execute the main query
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(mainQuery, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);
        }

        // Adding a new column to hold the group members' names
        dt.Columns.Add("Group_Members", typeof(string));

        // SQL query to get group members' names separated by commas

        string groupMembersQuery = @"SELECT sg.GroupName, STRING_AGG(s.Namee, ', ') AS GroupMembers
                            FROM StudentGroup sg
                            JOIN Student s ON sg.StudentUsername = s.Username
                            GROUP BY sg.GroupName";


        // Establish connection and execute the query to get group members' names
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(groupMembersQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Loop through the results and update the corresponding rows in the main DataTable
            while (reader.Read())
            {
                string groupName = reader["GroupName"].ToString();
                string groupMembers = reader["GroupMembers"].ToString();

                // Find the corresponding row in the main DataTable and update the Group_Members column
                DataRow[] rowsToUpdate = dt.Select("GroupName = '" + groupName + "'");
                foreach (DataRow row in rowsToUpdate)
                {
                    row["Group_Members"] = groupMembers;
                }
            }

            reader.Close();
        }

        // Bind the DataTable to the GridView
        GridView5.DataSource = dt;
        GridView5.DataBind();
    }
}
