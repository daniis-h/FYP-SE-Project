<%@ Page Language="C#" AutoEventWireup="true" CodeFile="committeedeadlines.aspx.cs" Inherits="committeedeadlines" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form1" runat="server">
        <header class="bg-primary">
  <div class="container py-4">
    <h1>Set Deadlines</h1>
  </div>
</header>
       
                <div style="height: 33px; margin-top: 0px;">
            <asp:Label ID="Label2" padding="20px" runat="server" BackColor="#808080" BorderColor="Black" BorderStyle="Groove" style="margin-left: 0px ; text-align:center; margin-top: 0px;" Text="" Width="100%" Height="42px">
          

                
                 <a href="committeecreateuser.aspx" 
    style="text-decoration: none; margin-left:0px; font-size:20px; color: inherit;" 
    onmouseover="this.style.color='lightgrey'" 
    onmouseout="this.style.color='inherit'">Create New User</a>


 <a href="committeeviewstudent.aspx" 
    style="text-decoration: none; margin-left:90px;font-size:20px; color: inherit;" 
    onmouseover="this.style.color='lightgrey'" 
    onmouseout="this.style.color='inherit'">View Student Details</a>
 
 <a href="committeeassigns.aspx" 
    style="text-decoration: none; margin-left:90px;font-size:20px; color: inherit;" 
    onmouseover="this.style.color='lightgrey'" 
    onmouseout="this.style.color='inherit'">Assign faculty</a>

  <a href="committeedeadlines.aspx" 
     style="text-decoration: none; margin-left:90px;font-size:20px; color: inherit;" 
     onmouseover="this.style.color='lightgrey'" 
     onmouseout="this.style.color='inherit'">Set Deadlines</a>


   
               

                                              <a href="committeecover.aspx" style="float:left"> 
  <img src="home.png" alt="Home" width="35" height="35">
</a>

            </asp:Label></div>

               <p>
              <asp:Label ID="Label1" padding="20px" runat="server" BackColor="#0099FF" BorderColor="Black" BorderStyle="Groove" style="margin-left: 369px; text-align:center; margin-top: 8px;" Text="Assign Assignments" Width="45%" Height="45px"></asp:Label>
            </p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        
              <div style="margin-left:20% ; margin-top:0px ; background-color:dimgray ; margin-right:200px ">
 

           <asp:Label ID="errorLabel" runat="server" Text="" ForeColor="Red" style="margin-left:40%"></asp:Label>

            <p style="height: 56px">
               <label for="dateTextBox">Due:</label>
            <input type="date" id="dateTextBox" runat="server" style="margin-left: 180px; width: 300px; background-color: dimgray;" />
 

            <p style="height: 56px">
               <label for="assignmentTextBox">Assignment:</label>
            <input type="text" id="assignmentTextBox" runat="server" style="margin-left: 180px; width: 300px; background-color: dimgray;" />
 

                        <p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Assign" Width="187px" style="margin-left: 415px" />
</p>

                <</div>
    </form>


    
            <!-- Latest compiled and minified CSS -->

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
