﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentdeadlines.aspx.cs" Inherits="studentdeadlines" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
        </style>
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form1" runat="server">
               

                 <header class="bg-primary">
  <div class="container py-4">
    <h1>Upcoming Deadlines</h1>
  </div>
</header>

                <div style="height: 33px; margin-top: 0px;">
            <asp:Label ID="Label1" padding="20px" runat="server" BackColor="#808080" BorderColor="Black" BorderStyle="Groove" style="margin-left: 0px ; text-align:center; margin-top: 0px;" Text="" Width="100%" Height="42px">
           
 <asp:Button ID="Button2" height="33px" runat="server" BackColor="#808080" style="margin-left: 30px" Text="Progress" Width="128px" border="none" OnClick="Button2_Click" />
<asp:Button ID="Button1" height="33px" runat="server" BackColor="#808080" style="margin-left: 67px" Text="deadlines" Width="128px" OnClick="Button3_Click" />
<asp:Button ID="Button6" height="33px" runat="server" BackColor="#808080" style="margin-left: 65px" Text="reviews" Width="128px" OnClick="Button6_Click" />

              <a href="studentcover.aspx" style="float:left"> 
  <img src="home.png" alt="Home" width="35" height="35">
</a>

            </asp:Label></div>

        <asp:GridView ID="GridView2"  runat="server" AutoGeneratedColumns ="FALSE" AutoGenerateColumns="False" Height="306px" style="margin-left: 400px; border:inset; margin-top: 69px" BackColor="DimGray" Width="550px" >
<Columns>
     <asp:BoundField DataField="assignment_type" HeaderText=" &nbsp;&nbsp;Assignment" />
     <asp:BoundField DataField="due_date" HeaderText="Due Date" />


    </Columns>

     <EmptyDataTemplate>
        <div>No data available.</div>
    </EmptyDataTemplate>

</asp:GridView>




    </form>


                <!-- Latest compiled and minified CSS -->

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>

</body>
</html>
