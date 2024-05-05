using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class studentcover : System.Web.UI.Page
{
    string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";
    string username = "s1";


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            // Query to get student's name
            string query1 = "SELECT namee FROM Student WHERE Username = '" + username + "'";

            // Query to get student's group name
            string query2 = "SELECT g.GroupName FROM [StudentGroup] g JOIN Student s ON g.StudentUsername = s.Username WHERE s.Username = '" + username + "'";

            string query3 = "SELECT ProjectTitle FROM Student WHERE Username = '" + username + "'";

            // Query to get supervisor's name
            string query4 = "SELECT su.FirstName FROM Student s JOIN Faculty su ON s.SupervisorID = su.FacultyID WHERE s.Username = '" + username + "'";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Execute query to get student's name
                using (SqlCommand command1 = new SqlCommand(query1, conn))
                {
                    SqlDataReader reader1 = command1.ExecuteReader();
                    if (reader1.Read())
                    {
                        Label7.Text = reader1["namee"].ToString() ;
                    }
                    reader1.Close();
                }

                // Execute query to get student's group name
                using (SqlCommand command2 = new SqlCommand(query2, conn))
                {
                    SqlDataReader reader2 = command2.ExecuteReader();
                    if (reader2.Read())
                    {
                        Label9.Text = reader2["GroupName"].ToString();
                    }
                    reader2.Close();
                }

                // Execute query to get student's project title
                using (SqlCommand command3 = new SqlCommand(query3, conn))
                {
                    SqlDataReader reader3 = command3.ExecuteReader();
                    if (reader3.Read())
                    {
                        Label10.Text = reader3["ProjectTitle"].ToString();
                    }
                    reader3.Close();
                }

                // Execute query to get supervisor's name
                using (SqlCommand command4 = new SqlCommand(query4, conn))
                {
                    SqlDataReader reader4 = command4.ExecuteReader();
                    if (reader4.Read())
                    {
                        Label11.Text = reader4["FirstName"].ToString();
                    }
                    reader4.Close();
                }
                Label8.Text = username;
            }
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentpanel.aspx?username=" + username);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentprogress.aspx?username=" + username);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentdeadlines.aspx?username=" + username);
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("studentreview.aspx?username=" + username);
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}