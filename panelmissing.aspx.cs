using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class panelmissing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          //  string panelID = "username";
            // Retrieve all group names supervised by panel 'p1'
            List<string> groupNames = GetGroupNamesForPanel("p1");

            // Bind the group names to the dropdown list
            GridView1.DataSource = groupNames;
            GridView1.DataBind();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("panelevaluate.aspx");
    }

    private List<string> GetGroupNamesForPanel(string panelID)
    {
        List<string> groupNames = new List<string>();

        string connectionString = @"Data Source=DESKTOP-P0QGTM9\SQLEXPRESS;Initial Catalog=SE_FYP_f;Integrated Security=True;TrustServerCertificate=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"SELECT DISTINCT sg.GroupName 
                 FROM StudentGroup sg
                 INNER JOIN Student s ON sg.StudentUsername = s.Username
                 LEFT JOIN FYPEvaluation fe ON sg.ProjectTitle = fe.FYPTitle
                 WHERE s.PanelID = @PanelID AND fe.EvaluationID IS NULL";


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

}