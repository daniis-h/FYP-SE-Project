using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Data Source = DESKTOP - P0QGTM9\SQLEXPRESS; Initial Catalog = SE_FYP_f; Integrated Security = True; Trust Server Certificate=True
public partial class committecreatefaculty : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Reset error message
        error.Text = "";

        // Validate inputs
        if (string.IsNullOrWhiteSpace(faculty_name.Text))
        {
            error.Text = "Please enter a name.";
            return;
        }


        if (string.IsNullOrWhiteSpace(faculty_ID.Text))
        {
            error.Text = "Please enter an ID.";
            return;
        }

        if (string.IsNullOrWhiteSpace(faculty_field.Text))
        {
            error.Text = "Please enter a field.";
            return;
        }

        if (string.IsNullOrWhiteSpace(faculty_phone.Text))
        {
            error.Text = "Please enter a phone number.";
            return;
        }

        if (ddlRole.SelectedValue == "" || ddlRole.SelectedValue == "Role")
        {
            error.Text = "Please select a role.";
            return;
        }

        // If all inputs are valid, proceed with database insertion

    }


    string connectionString = "Data Source=DESKTOP-P0QGTM9\\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True";

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(faculty_name.Text) ||
                string.IsNullOrWhiteSpace(faculty_ID.Text) ||
                string.IsNullOrWhiteSpace(faculty_field.Text) ||
                string.IsNullOrWhiteSpace(faculty_phone.Text) ||
                ddlRole.SelectedValue == "" || ddlRole.SelectedValue == "Role")
            {
                error.Text = "Please fill in all fields.";
                return;
            }

            // Insert faculty details into Faculty table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertFacultyQuery = "INSERT INTO Faculty (FacultyID, FirstName, LastName, Field, PhoneNumber) " +
                                            "VALUES (@FacultyID, @FirstName, @LastName, @Field, @PhoneNumber)";
                SqlCommand command = new SqlCommand(insertFacultyQuery, connection);
                command.Parameters.AddWithValue("@FacultyID", faculty_ID.Text);
                command.Parameters.AddWithValue("@FirstName", faculty_name.Text);
                command.Parameters.AddWithValue("@LastName", ""); // Assuming you don't have a separate field for last name
                command.Parameters.AddWithValue("@Field", faculty_field.Text);
                command.Parameters.AddWithValue("@PhoneNumber", faculty_phone.Text);
                command.ExecuteNonQuery();
            }

            // Insert faculty role into FacultyRoles table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertRoleQuery = "INSERT INTO FacultyRoles (FacultyID, RoleName) " +
                                         "VALUES (@FacultyID, @RoleName)";
                SqlCommand command = new SqlCommand(insertRoleQuery, connection);
                command.Parameters.AddWithValue("@FacultyID", faculty_ID.Text);
                command.Parameters.AddWithValue("@RoleName", ddlRole.SelectedValue);
                command.ExecuteNonQuery();
            }

            // Insert additional data based on role
            if (ddlRole.SelectedValue == "Supervisor")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertSupervisorQuery = "INSERT INTO Supervisor (FacultyID, TotalFYPs) " +
                                                   "VALUES (@FacultyID, @TotalFYPs)";
                    SqlCommand command = new SqlCommand(insertSupervisorQuery, connection);
                    command.Parameters.AddWithValue("@FacultyID", faculty_ID.Text);
                    command.Parameters.AddWithValue("@TotalFYPs", 0); // Set the initial value of TotalFYPs
                    command.ExecuteNonQuery();
                }
            }
            else if (ddlRole.SelectedValue == "Committee")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertCommitteeQuery = "INSERT INTO CommitteeMember (FacultyID) " +
                                                  "VALUES (@FacultyID)";
                    SqlCommand command = new SqlCommand(insertCommitteeQuery, connection);
                    command.Parameters.AddWithValue("@FacultyID", faculty_ID.Text);
                    command.ExecuteNonQuery();
                }
            }

            // Clear form fields after successful insertion
            faculty_name.Text = "";
            faculty_ID.Text = "";
            faculty_field.Text = "";
            faculty_phone.Text = "";
            ddlRole.ClearSelection();
            error.Text = "User created successfully.";
        }
        catch (Exception ex)
        {
            // Handle any exceptions
            error.Text = "An error occurred: " + ex.Message;
        }
    }

}