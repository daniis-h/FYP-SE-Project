using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class studentreview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Specify the username here or retrieve it from somewhere else in your application
            string username = "s1";

            // Create a DataTable and add columns
            DataTable dt = new DataTable();
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Total Marks", typeof(int));
            dt.Columns.Add("Marks Obtained", typeof(int));

            // Add rows to the DataTable
            dt.Rows.Add("Idea", 25, GetMarksForCategory("IdeaMarks", username));
            dt.Rows.Add("Presentation", 25, GetMarksForCategory("PresentationMarks", username));
            dt.Rows.Add("Documentation", 25, GetMarksForCategory("DocumentationMarks", username));
            dt.Rows.Add("Result", 25, GetMarksForCategory("ResultMarks", username));

            // Bind the DataTable to the GridView
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }

    // Method to get the marks obtained for a specific category and username
    private int GetMarksForCategory(string category, string username)
    {
        int marksObtained = 0;

        // Database connection string
        string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

        // SQL query to fetch marks obtained for the category based on username
        string query = $"SELECT {category} FROM FYPEvaluation e JOIN Student s ON e.FYPTitle = s.ProjectTitle WHERE s.Username = @Username";

        // Establish connection and execute the query
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            connection.Open();
            object result = command.ExecuteScalar();
            if (result != DBNull.Value)
            {
                marksObtained = Convert.ToInt32(result);
            }
        }

        return marksObtained;
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentprogress.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentdeadlines.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentreview.aspx");
    }
}