using System;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class supervisorreview : System.Web.UI.Page
{
    string username = "f1"; // Assuming this is the supervisor ID

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Call the method to populate the GridView with review data
            PopulateGridView();
        }
    }

    // Method to execute the SQL query and populate the GridView with review data
    private void PopulateGridView()
    {
        // Connection string
        string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

        // SQL query
        string query = @"SELECT e.EvaluationID, e.FYPTitle, e.IdeaMarks, e.PresentationMarks, e.DocumentationMarks, e.ResultMarks, e.Suggestions
                        FROM FYPEvaluation e
                        JOIN FYP f ON e.FYPTitle = f.ProjectTitle
                        JOIN Supervisor s ON f.SupervisorID = s.FacultyID
                        WHERE s.FacultyID = @SupervisorID";

        // Create and open connection
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add parameter for the supervisor ID
                command.Parameters.AddWithValue("@SupervisorID", username);

                // Open connection
                connection.Open();

                // Execute command and bind result to GridView
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    GridView6.DataSource = reader;
                    GridView6.DataBind();
                }
            }
        }
    }
}
