using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class committeeassigns : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // Reset error message
        error1.Text = "";

        // Validate inputs
        if (string.IsNullOrWhiteSpace(supervisor_ID.Text))
        {
            error1.Text = "Please enter a Supervisor ID.";
            return;
        }

        if (string.IsNullOrWhiteSpace(group_name.Text))
        {
            error1.Text = "Please enter a Group Name.";
            return;
        }

        // SQL query to assign supervisor to group
        string assignSupervisorQuery = "UPDATE Student " +
                               "SET SupervisorID = @supervisorID " +
                               "WHERE Username IN (" +
                                   "SELECT StudentUsername " +
                                   "FROM StudentGroup " +
                                   "WHERE GroupName = @groupName" +
                               ")";

        // Execute the first query to assign supervisor to group
        try
        {
            // Establish connection (replace connection string with your actual connection string)
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-P0QGTM9\\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True"))
            {
                // Create and configure the SqlCommand object
                SqlCommand command = new SqlCommand(assignSupervisorQuery, connection);
                command.Parameters.AddWithValue("@supervisorID", supervisor_ID.Text);
                command.Parameters.AddWithValue("@groupName", group_name.Text);

                // Open connection
                connection.Open();

                // Execute the query
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions
            error1.Text = "An error occurred: " + ex.Message;
            // Log the exception or display a more user-friendly error message
        }

        // After executing the first query, add the additional queries
        try
        {
            // Establish connection (replace connection string with your actual connection string)
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-P0QGTM9\\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True"))
            {
                // Select project title based on the group name
                string selectProjectTitleQuery = "SELECT distinct ProjectTitle FROM StudentGroup WHERE GroupName = @groupName";

                // Create and configure the SqlCommand object
                SqlCommand selectCommand = new SqlCommand(selectProjectTitleQuery, connection);
                selectCommand.Parameters.AddWithValue("@groupName", group_name.Text);

                // Open connection
                connection.Open();

                // Execute the select query
                string projectTitle = (string)selectCommand.ExecuteScalar();

                // Update FYP table with the new supervisor for the project
                string updateFYPQuery = "UPDATE FYP SET SupervisorID = @newSupervisorID WHERE ProjectTitle = @projectTitle";

                // Create and configure the SqlCommand object for updating FYP table
                SqlCommand updateCommand = new SqlCommand(updateFYPQuery, connection);
                updateCommand.Parameters.AddWithValue("@newSupervisorID", supervisor_ID.Text);
                updateCommand.Parameters.AddWithValue("@projectTitle", projectTitle);

                // Execute the update query
                updateCommand.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions
            error1.Text = "An error occurred: " + ex.Message;
            // Log the exception or display a more user-friendly error message
        }
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        error2.Text = "";

        // Validate inputs
        if (string.IsNullOrWhiteSpace(panel_name.Text))
        {
            error2.Text = "Please enter a Panel Member ID.";
            return;
        }

        if (string.IsNullOrWhiteSpace(panel_ID.Text))
        {
            error2.Text = "Please enter a Panel ID.";
            return;
        }

        try
        {
            // Establish connection (replace connection string with your actual connection string)
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-P0QGTM9\\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True"))
            {

                // Insert into Panel table
                string insertPanelQuery = "INSERT INTO Panel (PanelID) VALUES (@panelID)";
                SqlCommand insertPanelCommand = new SqlCommand(insertPanelQuery, connection);
                insertPanelCommand.Parameters.AddWithValue("@panelID", panel_ID.Text);

                // Insert into PanelMember table
                string insertPanelMemberQuery = "INSERT INTO PanelMember (PanelID, FacultyID) VALUES (@panelID, @facultyID)";
                SqlCommand insertPanelMemberCommand = new SqlCommand(insertPanelMemberQuery, connection);
                insertPanelMemberCommand.Parameters.AddWithValue("@panelID", panel_ID.Text);
                insertPanelMemberCommand.Parameters.AddWithValue("@facultyID", panel_name.Text);

                // Open connection
                connection.Open();

                // Execute queries
                try
                {
                    insertPanelCommand.ExecuteNonQuery();
                } catch (Exception ex) { }
                insertPanelMemberCommand.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions
            error2.Text = "An error occurred: " + ex.Message;
            // Log the exception or display a more user-friendly error message
        }
    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        error3.Text = "";

        // Validate inputs
        if (string.IsNullOrWhiteSpace(panel_ID2.Text))
        {
            error3.Text = "Please enter a Panel ID.";
            return;
        }

        if (string.IsNullOrWhiteSpace(group_name2.Text))
        {
            error3.Text = "Please enter a Group.";
            return;
        }

        try
        {
            // Establish connection (replace connection string with your actual connection string)
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-P0QGTM9\\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True"))
            {
                // Update Student table to assign the panel to the group
                string updateStudentQuery = "UPDATE Student SET PanelID = @panelID WHERE ProjectTitle IN (SELECT ProjectTitle FROM StudentGroup WHERE GroupName = @groupName)";
                SqlCommand command = new SqlCommand(updateStudentQuery, connection);
                command.Parameters.AddWithValue("@panelID", panel_ID2.Text);
                command.Parameters.AddWithValue("@groupName", group_name2.Text);

                // Open connection
                connection.Open();

                // Execute the query
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions
            // Log the exception or display a more user-friendly error message
        }
    }

}