using System;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class committeedeadlines : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        errorLabel.Text = ""; // Clear any previous error messages

        // Retrieve the values from the input fields
        string dueDate = dateTextBox.Value;
        string assignment = assignmentTextBox.Value;

        // Check if either of the fields is empty
        if (string.IsNullOrWhiteSpace(dueDate) || string.IsNullOrWhiteSpace(assignment))
        {
            errorLabel.Text = "Please enter both a due date and an assignment.";
            return; // Exit the event handler
        }

        try
        {
            // Your SQL Connection String
            string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

            // Your SQL Query to insert the deadline into the FYPDeadline table
            string insertDeadlineQuery = "INSERT INTO FYPDeadline (Assignment, DeadlineDate, ProjectTitle) " +
                                          "SELECT @Assignment, @DeadlineDate, ProjectTitle FROM FYP";

            // Initialize connection and command
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertDeadlineQuery, connection);
                command.Parameters.AddWithValue("@Assignment", assignment);
                command.Parameters.AddWithValue("@DeadlineDate", dueDate);

                // Open connection and execute command
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Deadline inserted successfully
                    errorLabel.Text = "Deadline has been successfully assigned.";
                }
                else
                {
                    // No deadlines were inserted (maybe there are no projects in FYP)
                    errorLabel.Text = "No projects found to assign the deadline to.";
                }
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions
            errorLabel.Text = "An error occurred: " + ex.Message;
        }
    }
}
