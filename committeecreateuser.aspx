<%@ Page Language="C#" AutoEventWireup="true" CodeFile="committeecreateuser.aspx.cs" Inherits="committeecreateuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form1" runat="server">
        <header class="bg-primary">
  <div class="container py-4">
    <h1>Create New User</h1>
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


        <div style="text-align:center;">
    <h1 style="margin-top:0px ; background-color:dodgerblue ; border:inset">Choose Role</h1>
            <br />
   
    <asp:Button ID="studentButton" runat="server" Text="Student" CssClass="role-button"  style="margin-top:30px ; width:300px ; height:80px ; background-color:dimgray ; font-size:30px " OnClick="StudentButton_Click" Width="86px" />
             <br />
 
    <asp:Button ID="FacultyButton" runat="server" Text="Faculty" CssClass="role-button" style="margin-top:70px ; width:300px ; height:80px ; background-color:dimgray ; font-size:30px " OnClick="FacultyButton_Click" />
            <br />
   

</div>

   



    </form>


    
            <!-- Latest compiled and minified CSS -->

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>