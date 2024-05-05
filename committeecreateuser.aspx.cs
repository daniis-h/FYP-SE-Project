using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class committeecreateuser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void StudentButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("committeecreatestudents.aspx");
    }

    protected void FacultyButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("committecreatefaculty.aspx");
    }

    

}