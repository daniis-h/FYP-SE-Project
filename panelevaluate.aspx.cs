using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class panelevaluate : System.Web.UI.Page
{
    string projectTitle = "";
    string username = "p1";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Retrieve all group names supervised by panel 'p1'
            List<string> groupNames = GetGroupNamesForPanel("p1");

            // Bind the group names to the dropdown list
            groupDropdown.DataSource = groupNames;
            groupDropdown.DataBind();
        }
    }

    // Method to retrieve all group names supervised by a panel
    private List<string> GetGroupNamesForPanel(string panelID)
    {
        List<string> groupNames = new List<string>();

        string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT DISTINCT GroupName " +
                           "FROM StudentGroup " +
                           "WHERE StudentUsername IN (" +
                           "    SELECT Username " +
                           "    FROM Student " +
                           "    WHERE PanelID = @PanelID" +
                           ")";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PanelID", panelID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            groupNames.Add(reader.GetString(0));
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }


        return groupNames;
    }


    protected void submitBtn_Click(object sender, EventArgs e)
    {
        int idea, presentation, documentation, result;
        string suggestiontext = suggestion.Text;

        // Check if the entered values are valid integers
        if (!int.TryParse(project_idea.Text, out idea) ||
            !int.TryParse(project_presentation.Text, out presentation) ||
            !int.TryParse(project_document.Text, out documentation) ||
            !int.TryParse(project_result.Text, out result))
        {
            // Display error message
            error.Text = "Please fill in all fields with valid integer values.";
            return;
        }

        // Check if the entered values are within the valid range (0 to 25)
        if (idea < 0 || idea > 25 || presentation < 0 || presentation > 25 ||
            documentation < 0 || documentation > 25 || result < 0 || result > 25)
        {
            error.Text = "Please enter values in the range of 0 to 25.";
            return;
        }

        // Get the panel ID from the username
        string panelID = username; // Assuming username contains the panel ID

        // Retrieve the selected group name from the dropdown list
        string groupName = groupDropdown.SelectedValue;

        // Get the project title for the selected group
        string projectTitle = GetProjectTitleForGroup(groupName);

        // Construct the SQL query
        string query = "INSERT INTO FYPEvaluation (FYPTitle, PanelID, IdeaMarks, PresentationMarks, DocumentationMarks, ResultMarks, Suggestions) " +
                       "VALUES (@FYPTitle, @PanelID, @IdeaMarks, @PresentationMarks, @DocumentationMarks, @ResultMarks, @Suggestions)";

        // Execute the SQL query
        string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FYPTitle", projectTitle);
                command.Parameters.AddWithValue("@PanelID", panelID);
                command.Parameters.AddWithValue("@IdeaMarks", idea);
                command.Parameters.AddWithValue("@PresentationMarks", presentation);
                command.Parameters.AddWithValue("@DocumentationMarks", documentation);
                command.Parameters.AddWithValue("@ResultMarks", result);
                command.Parameters.AddWithValue("@Suggestions", suggestiontext);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("" + ex.Message);
                    error.Text = "Already Subimitted";
                    return;
                }
            }
        }

        // Clear other textboxes and error label
        project_idea.Text = "";
        project_presentation.Text = "";
        project_document.Text = "";
        project_result.Text = "";
        suggestion.Text = "";
        error.Text = "";
    }


    // Method to retrieve the project title for a given group name
    private string GetProjectTitleForGroup(string groupName)
    {
        string projectTitle = "";

        string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT ProjectTitle " +
                           "FROM StudentGroup " +
                           "WHERE GroupName = @GroupName";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@GroupName", groupName);

                try
                {
                    connection.Open();
                    projectTitle = (string)command.ExecuteScalar(); // Assuming ProjectTitle is of type string
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        return projectTitle;
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("panelmissing.aspx");
    }
}