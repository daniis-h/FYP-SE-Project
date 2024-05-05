using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Studentlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        errorLabel.Text = ""; // Clear any previous error messages

        // Retrieve the values from the input fields
        string role = ddlRole.SelectedValue;
        string id = Text1.Value;
        string password = Text2.Value;

        // Check if any of the fields are empty
        if (role == "Role" || string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
        {
            errorLabel.Text = "Please enter all required information.";
            return; // Exit the event handler
        }

        // Navigate to the appropriate cover page based on the selected role
        switch (role)
        {
            case "Student":
                Response.Redirect("studentcover.aspx");
                break;
            case "Committee":
                Response.Redirect("Committeecover.aspx");
                break;
            case "Supervisor":
                Response.Redirect("supervisorcover.aspx");
                break;
            case "Panel":
                Response.Redirect("panelcover.aspx");
                break;
            default:
                // Handle any other cases
                break;
        }
    }


}