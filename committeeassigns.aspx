<%@ Page Language="C#" AutoEventWireup="true" CodeFile="committeeassigns.aspx.cs" Inherits="committeeassigns" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form1" runat="server">
        <header class="bg-primary">
  <div class="container py-4">
    <h1>Assign faculty Members</h1>
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

   

        <!--supervisor to group -->
        <p>
  <asp:Label ID="Label1" padding="20px" runat="server" BackColor="#0099FF" BorderColor="Black" BorderStyle="Groove" style="margin-left: 369px; text-align:center; margin-top: 8px;" Text="Assign Supervisor to Group" Width="45%" Height="45px"></asp:Label>
</p>

      <div style="margin-left:20% ; margin-top:40px ; background-color:dimgray ; margin-right:200px ">
 
 
 <asp:Label ID="error1" runat="server" Text="" ForeColor="Red"></asp:Label>
 <br /> 
 
<label for="supervisor_ID" >Supervisor ID :</label>
<asp:TextBox ID="supervisor_ID" runat="server"  style=" margin-left:195px  ; width:300px ; background-color:dimgray" ></asp:TextBox><br /><br />

<label for="group_name">Group Name:</label>
<asp:TextBox ID="group_name" runat="server" style="margin-left:210px ; width:300px; background-color:dimgray" ></asp:TextBox><br /><br />

           <asp:Button ID="assignsuper" runat="server" Text="Assign Supervisor " OnClick="Button1_Click" />

        </div>




        <!-- panel to faculty member -->
                  <p>
  <asp:Label ID="Label3" padding="20px" runat="server" BackColor="#0099FF" BorderColor="Black" BorderStyle="Groove" style="margin-left: 369px; text-align:center; margin-top: 20px;" Text="Assign Panel to Member" Width="45%" Height="45px"></asp:Label>
</p>


              <div style="margin-left:20% ; margin-top:0px ; background-color:dimgray ; margin-right:200px ">
 
 
 <asp:Label ID="Label4" runat="server" Text="" ForeColor="Red"></asp:Label>
 <br /> 
  <asp:Label ID="error2" runat="server" Text="" ForeColor="Red"></asp:Label>
 <br /> 
<label for="panel_name" >Panel Member ID :</label>
<asp:TextBox ID="panel_name" runat="server"  style=" margin-left:180px  ; width:300px ; background-color:dimgray" ></asp:TextBox><br /><br />

<label for="panel_ID">Panel ID:</label>
<asp:TextBox ID="panel_ID" runat="server" style="margin-left:265px ; width:300px; background-color:dimgray" ></asp:TextBox><br /><br />

           <asp:Button ID="assignpanel" runat="server" Text="Assign Panel" OnClick="Button2_Click" />

        </div>

        <br />



        <!-- Assigning group to panel. -->
                          <p>
  <asp:Label ID="Label7" padding="20px" runat="server" BackColor="#0099FF" BorderColor="Black" BorderStyle="Groove" style="margin-left: 369px; text-align:center; margin-top: 20px;" Text="Assign Panel to Group" Width="45%" Height="45px"></asp:Label>
</p>
        
              <div style="margin-left:20% ; margin-top:0px ; background-color:dimgray ; margin-right:200px ">
 
 
 
  <asp:Label ID="error3" runat="server" Text="" ForeColor="Red"></asp:Label>
 <br /> 
<label for="panel_ID" >Panel ID:</label>
<asp:TextBox ID="panel_ID2" runat="server"  style=" margin-left:180px  ; width:300px ; background-color:dimgray" ></asp:TextBox><br /><br />

<label for="group_name">Group Name:</label>
<asp:TextBox ID="group_name2" runat="server" style="margin-left:265px ; width:300px; background-color:dimgray" ></asp:TextBox><br /><br />

           <asp:Button ID="assigngroup" runat="server" Text="Assign Group" OnClick="Button3_Click" />

        </div>
        <br />
        <br />

    </form>


    
            <!-- Latest compiled and minified CSS -->

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>