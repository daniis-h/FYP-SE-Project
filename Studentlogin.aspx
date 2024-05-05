<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Studentlogin.aspx.cs" Inherits="Studentlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 194px;
            height: 37px;
            margin-left: 156px;
            margin-top: 77px;
        }
        #Text2 {
            width: 194px;
            height: 39px;
            margin-left: 156px;
            margin-top: 77px;
        }
        #Submit1 {
            width: 91px;
            margin-left: 521px;
        }
    </style>

    <!-- Latest compiled and minified CSS -->
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
      
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form1" runat="server">

     <header class="bg-primary">
    <div class="container py-4">
      <h1>Welcome To FYP Management System</h1>
    </div>
  </header>


         
 
   <div style="margin-left:20% ; margin-top:0px ; background-color:dimgray ; margin-right:200px ">
 

<asp:Label ID="errorLabel" runat="server" Text="" ForeColor="Red" style="margin-left:40%"></asp:Label>
</div>
<p style="margin-left:30% ; margin-top:50px; width:400px"
<label for="ddlRole"> </label>
    <asp:DropDownList ID="ddlRole" runat="server" style="margin-left:30%;">
     <asp:ListItem Text="Role" Value="Role"></asp:ListItem>
     <asp:ListItem Text="Student" Value="Student"></asp:ListItem>
    <asp:ListItem Text="Committee" Value="Committee"></asp:ListItem>
    <asp:ListItem Text="Panel" Value="Panel"></asp:ListItem>
    <asp:ListItem Text="Supervisor" Value="Supervisor"></asp:ListItem>
</asp:DropDownList><br /><br />
   
    </p>
        <p style="height: 75px; margin-top: 0px;">
    <asp:Label ID="Label2" runat="server" BackColor="#0099FF" BorderColor="Black" BorderStyle="Ridge" style="margin-left: 254px; text-align:center" Text="&nbsp;&nbsp;&nbsp;ID" Width="182px" Height="39px"></asp:Label>
    <input id="Text1" type="text" runat="server" />

</p>
<p style="height: 147px">
    <asp:Label ID="Label3" runat="server" BackColor="#0099FF" BorderColor="Black" BorderStyle="Outset" style="margin-left: 258px;text-align:center" Text="&nbsp;&nbsp;&nbsp;password" Width="178px" Height="36px"></asp:Label>
    <input id="Text2" type="text" runat="server" />
</p>
           


        <p>
            <asp:Button ID="Button1" runat="server" style="margin-left: 578px" Text="Submit" Width="114px" OnClick="Button1_Click" />
        </p>
    
        <p>
    &nbsp;</p>
        <p>
    &nbsp;</p>
        <p>
    &nbsp;</p>
        <p>
    &nbsp;</p>
        <p>
    &nbsp;</p>

    </form>



    <!-- Latest compiled and minified CSS -->

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
