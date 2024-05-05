using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Supervisorgroups : System.Web.UI.Page
{
    string username = "f1";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGridView();
        }
    }

    protected void BindGridView()
    {
        // Database connection string
        string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

        // SQL query to fetch data from the database
        string query = @"SELECT g.GroupName, STRING_AGG(s.Namee, ', ') AS GroupMembers, s.ProjectTitle
                     FROM StudentGroup g
                     JOIN Student s ON g.StudentUsername = s.Username
                     WHERE s.SupervisorID = @supervisorID
                     GROUP BY g.GroupName, s.ProjectTitle";

        // DataTable to hold the fetched data
        DataTable dt = new DataTable();

        // Establish connection and execute the query
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@supervisorID", username); // assuming 'username' is a class-level variable
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);
        }

        // Bind the DataTable to the GridView
        GridView5.DataSource = dt;
        GridView5.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Supervisorgroups.aspx");
    }
}