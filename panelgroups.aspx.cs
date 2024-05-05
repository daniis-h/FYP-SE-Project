using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class panelgroups : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Group_ID", typeof(int));
        dt.Columns.Add("Group_Name", typeof(string));
        dt.Columns.Add("Group_Members", typeof(string));
        dt.Columns.Add("Group_Project", typeof(string));
        // Add rows to the DataTable
        dt.Rows.Add(1, "Alt", "Ali, Ahmad", "drone");

        // Bind the DataTable to the GridView
        GridView7.DataSource = dt;
        GridView7.DataBind();
    }

    protected void search(object sender, EventArgs e)
    {
        
    }
}