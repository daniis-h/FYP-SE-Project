﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="panelmissing.aspx.cs" Inherits="panelmissing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form1" runat="server">
        <header class="bg-primary">
  <div class="container py-4">
    <h1>Missing Evaluations</h1>
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

   
   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="306px" style="margin-left: 400px; border:inset; margin-top: 69px" BackColor="DimGray" Width="550px">
    <Columns>
        <asp:TemplateField HeaderText="Group Name">
            <ItemTemplate>
                <%# Container.DataItem.ToString() %>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Evaluate">
            <ItemTemplate>
                <asp:Button ID="EvaluateButton" runat="server" Text="Evaluate" OnClick="Button1_Click" CommandArgument='<%# Container.DataItem.ToString() %>' />
            </ItemTemplate>
        </asp:TemplateField>
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
