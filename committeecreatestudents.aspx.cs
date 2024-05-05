using System;
using System.Collections.Generic;
using System.Data.SqlClient; // Import SQL Client
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class committeecreatestudents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Populate supervisors dropdown list
            PopulateSupervisors();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Check if any of the text fields are empty
        if (string.IsNullOrEmpty(student_name.Text) ||
            string.IsNullOrEmpty(student_ID.Text) ||
            string.IsNullOrEmpty(student_group.Text) ||
            string.IsNullOrEmpty(student_project.Text) ||
            string.IsNullOrEmpty(student_supervisor.SelectedValue))
        {
            // Display error message for empty fields
            error.Text = "Please fill in all fields.";
            return;
        }

        try
        {
            // Your SQL Connection String
            string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";


            // Insert into Student table
            string insertStudentQuery = "INSERT INTO Student (Username, Namee, ProjectTitle, SupervisorID) " +
                                         "VALUES (@Username, @Name, @ProjectTitle, @SupervisorID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand insertStudentCommand = new SqlCommand(insertStudentQuery, connection);
                insertStudentCommand.Parameters.AddWithValue("@Username", student_ID.Text);
                insertStudentCommand.Parameters.AddWithValue("@Name", student_name.Text);
                insertStudentCommand.Parameters.AddWithValue("@ProjectTitle", student_project.Text);
                insertStudentCommand.Parameters.AddWithValue("@SupervisorID", student_supervisor.SelectedValue);
                insertStudentCommand.ExecuteNonQuery();
            }



            // Insert into FYP table
            try
            {
                string insertFYPQuery = "INSERT INTO FYP (ProjectTitle, SupervisorID) " +
                                         "VALUES (@ProjectTitle, @SupervisorID)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand insertFYPCommand = new SqlCommand(insertFYPQuery, connection);
                    insertFYPCommand.Parameters.AddWithValue("@ProjectTitle", student_project.Text);
                    insertFYPCommand.Parameters.AddWithValue("@SupervisorID", student_supervisor.SelectedValue);
                    insertFYPCommand.ExecuteNonQuery();
                }
            } catch { }

            // Insert into StudentGroup table
            string insertStudentGroupQuery = "INSERT INTO StudentGroup (GroupName, StudentUsername, ProjectTitle) " +
                                             "VALUES (@GroupName, @StudentUsername, @ProjectTitle)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand insertStudentGroupCommand = new SqlCommand(insertStudentGroupQuery, connection);
                insertStudentGroupCommand.Parameters.AddWithValue("@GroupName", student_group.Text);
                insertStudentGroupCommand.Parameters.AddWithValue("@StudentUsername", student_ID.Text);
                insertStudentGroupCommand.Parameters.AddWithValue("@ProjectTitle", student_project.Text);
                insertStudentGroupCommand.ExecuteNonQuery();
            }



            // Clear form data
            student_name.Text = "";
            student_ID.Text = "";
            student_group.Text = "";
            student_project.Text = "";
            student_supervisor.SelectedIndex = -1;



            // Clear error message
            error.Text = "";

            // Optionally, you can also redirect the user to another page after submission
            // Response.Redirect("SuccessPage.aspx");
        }
        catch (Exception ex)
        {
            // Handle exceptions
            error.Text = "An error occurred: " + ex.Message;
        }
    }

    // Method to populate supervisors dropdown list
    private void PopulateSupervisors()
    {
        // Your SQL Connection String
        string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

        // Your SQL Query to retrieve supervisors
        string selectSupervisorsQuery = "SELECT S.FacultyID, CONCAT(F.FirstName, ' ', F.LastName) AS SupervisorName " +
                                "FROM Supervisor S " +
                                "JOIN Faculty F ON S.FacultyID = F.FacultyID";


        // Initialize connection and command
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(selectSupervisorsQuery, connection);

            // Open connection and execute command
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Bind the reader to the dropdown list
            student_supervisor.DataSource = reader;
            student_supervisor.DataTextField = "SupervisorName"; // Display SupervisorName alias
            student_supervisor.DataValueField = "FacultyID"; // Corresponding FacultyID
            student_supervisor.DataBind();

            // Close the reader
            reader.Close();
        }

        // Add a default item
        student_supervisor.Items.Insert(0, new ListItem("Select Supervisor", ""));
    }

}
