using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class studentdeadlines : System.Web.UI.Page
{
    string username;
    string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string username = Request.QueryString["username"];
            username = "s1";
            // Query to get upcoming deadlines
            string queryDeadlines = @"
                SELECT DeadlineDate AS due_date, Assignment AS assignment_type 
                FROM FYPDeadline 
                WHERE ProjectTitle IN (
                    SELECT ProjectTitle 
                    FROM StudentGroup 
                    WHERE GroupName = (
                        SELECT GroupName 
                        FROM Student 
                        WHERE Username = @Username
                    )
                ) 
                AND DeadlineDate >= GETDATE() 
                ORDER BY DeadlineDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryDeadlines, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    GridView2.DataSource = dt;
                    GridView2.DataBind();
                }
            }
        }
    }


    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

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
}

