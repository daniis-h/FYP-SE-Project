using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class supervisordeadlines : System.Web.UI.Page
{
    string username = "f1";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Establish connection to the database
            string connectionString = "Data Source=DESKTOP-P0QGTM9\\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a command to execute the SQL query
                SqlCommand command = new SqlCommand("SELECT Assignment, DeadlineDate FROM FYPDeadline WHERE ProjectTitle IN (SELECT ProjectTitle FROM FYP WHERE SupervisorID = @username)", connection);

                // Add parameters to the command
                command.Parameters.AddWithValue("@username", username);

                // Create a DataTable to hold the results
                DataTable dt = new DataTable();

                // Read the data into the DataTable
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }

                // Bind the DataTable to the GridView
                GridView4.DataSource = dt;
                GridView4.DataBind();
            }
        }
    }


}