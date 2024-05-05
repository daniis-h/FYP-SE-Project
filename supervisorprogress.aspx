﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="supervisorprogress.aspx.cs" Inherits="supervisorprogress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form2" runat="server">
        <header class="bg-primary">
  <div class="container py-4">
    <h1>Groups Progress</h1>
  </div>
</header>
       
                <div style="height: 33px; margin-top: 0px;">
            <asp:Label ID="Label1" padding="20px" runat="server" BackColor="#808080" BorderColor="Black" BorderStyle="Groove" style="margin-left: 0px ; text-align:center; margin-top: 0px;" Text="" Width="100%" Height="42px">


                <a href="Supervisorgroups.aspx" 
                   style="text-decoration: none; margin-left:0px; font-size:20px; color: inherit;" 
                   onmouseover="this.style.color='lightgrey'" 
                   onmouseout="this.style.color='inherit'">Groups Assigned</a>


                <a href="Supervisorreview.aspx" 
                   style="text-decoration: none; margin-left:90px;font-size:20px; color: inherit;" 
                   onmouseover="this.style.color='lightgrey'" 
                   onmouseout="this.style.color='inherit'">View Reviews</a>
   
                <a href="supervisordeadlines.aspx" 
                   style="text-decoration: none; margin-left:90px;font-size:20px; color: inherit;" 
                   onmouseover="this.style.color='lightgrey'" 
                   onmouseout="this.style.color='inherit'">View Deadlines</a>


                             <a href="supervisorprogress.aspx" 
style="text-decoration: none; margin-left:90px;font-size:20px; color: inherit;" 
onmouseover="this.style.color='lightgrey'" 
onmouseout="this.style.color='inherit'">Progress</a>
            


                              <a href="supervisorcover.aspx" style="float:left"> 
  <img src="home.png" alt="Home" width="35" height="35">
</a>

            </asp:Label></div>


        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" Height="306px" style="margin-left: 300px; border:inset; margin-top: 69px" BackColor="DimGray" Width="650px">
    <Columns>
    <asp:BoundField DataField="StudentName" HeaderText="Added by" />
    <asp:BoundField DataField="datee" HeaderText="Date Added" />
    <asp:BoundField DataField="Descriptionn" HeaderText="Achievement" />
    <asp:TemplateField HeaderText="Supervisor Feedback">
        <ItemTemplate>
            <asp:TextBox ID="feedbackTextBox" runat="server"></asp:TextBox>
        </ItemTemplate>
    </asp:TemplateField>
</Columns>

    <EmptyDataTemplate>
        <div>No data available.</div>
    </EmptyDataTemplate>
</asp:GridView>



    </Columns>

     <EmptyDataTemplate>
        <div>No data available.</div>
    </EmptyDataTemplate>

</asp:GridView>
                <p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" Width="187px" style="margin-left: 415px" />
</p>

    </form>

    
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>

</body>
</html>
