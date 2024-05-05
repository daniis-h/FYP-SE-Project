<%@ Page Language="C#" AutoEventWireup="true" CodeFile="committeecreatestudents.aspx.cs" Inherits="committeecreatestudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form1" runat="server">
        <header class="bg-primary">
  <div class="container py-4">
    <h1>Create Student</h1>
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

   

         <div style="margin-left:20% ; margin-top:40px ; background-color:dimgray ; margin-right:200px ">
 
    <h2>Enter Data</h2> 
     <asp:Label ID="error" runat="server" Text="" ForeColor="Red"></asp:Label>
     <br /> 
 
    <label for="student_name" >Name :</label>
    <asp:TextBox ID="student_name" runat="server"  style=" margin-left:185px  ; width:300px ; background-color:dimgray" ></asp:TextBox><br /><br />

    <label for="student_ID">ID:</label>
    <asp:TextBox ID="student_ID" runat="server" style="margin-left:210px ; width:300px; background-color:dimgray" ></asp:TextBox><br /><br />

    <label for="student_group">Group:</label>
    <asp:TextBox ID="student_group" runat="server" style="margin-left:180px ; width:300px; background-color:dimgray"></asp:TextBox><br /><br />

     <label for="student_project">Project:</label>
     <asp:TextBox ID="student_project" runat="server" style="margin-left:170px ; width:300px; background-color:dimgray" ></asp:TextBox><br /><br />

             <label for="student_supervisor">Select Supervisor:</label>
<asp:DropDownList ID="student_supervisor" runat="server" style="margin-left:110px ; width:300px; background-color:dimgray"></asp:DropDownList><br /><br />
     
    <asp:Button ID="submitBtn" runat="server" Text="Create User" OnClick="Button1_Click" />
 

  </div>

    </form>


    
            <!-- Latest compiled and minified CSS -->

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
