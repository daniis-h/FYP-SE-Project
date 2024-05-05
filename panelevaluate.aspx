<%@ Page Language="C#" AutoEventWireup="true" CodeFile="panelevaluate.aspx.cs" Inherits="panelevaluate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form1" runat="server">
        <header class="bg-primary">
  <div class="container py-4">
    <h1>Evaluate FYPs</h1>
  </div>
</header>
       
                <div style="height: 33px; margin-top: 0px;">
            <asp:Label ID="Label2" padding="20px" runat="server" BackColor="#808080" BorderColor="Black" BorderStyle="Groove" style="margin-left: 0px ; text-align:center; margin-top: 0px;" Text="" Width="100%" Height="42px">
          

                
                <a href="panelgroups.aspx" 
                   style="text-decoration: none; margin-left:0px; font-size:20px; color: inherit;" 
                   onmouseover="this.style.color='lightgrey'" 
                   onmouseout="this.style.color='inherit'">Groups Assigned</a>


                <a href="panelevaluate.aspx" 
                   style="text-decoration: none; margin-left:90px;font-size:20px; color: inherit;" 
                   onmouseover="this.style.color='lightgrey'" 
                   onmouseout="this.style.color='inherit'">Evaluate FYPs</a>
   
               

                                              <a href="panelcover.aspx" style="float:left"> 
  <img src="home.png" alt="Home" width="35" height="35">
</a>

            </asp:Label></div>
 
 <div style="margin-left:20% ; margin-top:40px ; background-color:dimgray ; margin-right:200px ">
 
    <h2>Enter Data</h2> 

     <h3 style="font-style:italic">(Note: each evaluation out of 25)</h3>
     <asp:Label ID="error" runat="server" Text="" ForeColor="Red"></asp:Label>
     <br /> 
 
    <label for="groupDropdown">Select Group:</label>
    <asp:DropDownList ID="groupDropdown" runat="server"></asp:DropDownList><br /><br />

    <label for="project_idea" >Idea:</label>
    <asp:TextBox ID="project_idea" runat="server" ></asp:TextBox><br /><br />

    <label for="project_presentation">Presentation:</label>
    <asp:TextBox ID="project_presentation" runat="server" ></asp:TextBox><br /><br />

    <label for="project_document">Documentation:</label>
    <asp:TextBox ID="project_document" runat="server"></asp:TextBox><br /><br />

     <label for="project_result">Result:</label>
     <asp:TextBox ID="project_result" runat="server"></asp:TextBox><br /><br />

     <label for="suggestion">Suggestion for Supervisor</label>
<asp:TextBox ID="suggestion" runat="server"></asp:TextBox><br /><br />

    <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click" />
 

  </div>
 
     <asp:Button ID="Button1" runat="server" OnClick="Button1_Click " style="margin-left: 40%" Text="Missing Evaluations" />
 


 
   




    </form>


    
            <!-- Latest compiled and minified CSS -->

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>