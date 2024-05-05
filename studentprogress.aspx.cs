using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class studentprogress : System.Web.UI.Page
{
    string username;
    string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True"; 
    protected void Page_Load(object sender, EventArgs e)
    {
        username = Request.QueryString["username"];
        username = "s1";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentprogress.aspx?username=" + username);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentdeadlines.aspx?username=" + username);
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentreview.aspx?username=" + username);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentviewprogress.aspx?username=" + username);
    }

    protected void Button3_Click1(object sender, EventArgs e)
    {
        // Retrieve input values
        string date = Text1.Value; // Assuming Text1 is the ID of your date input control
        string description = Text2.Value; // Assuming Text2 is the ID of your description input control

        // Execute SQL query to insert data into the Progress table

        string query = "INSERT INTO Progress (Datee, Descriptionn, Username) VALUES (@Date, @Description, @Username)";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                // Add parameters
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Username", username);

                conn.Open();
                command.ExecuteNonQuery();
            }
        }
        Text1.Value = null;
        Text2.Value = null;

        // Optionally, you can redirect the user to another page after insertion
        //Response.Redirect("studentprogress.aspx?username=" + username);
    }
}