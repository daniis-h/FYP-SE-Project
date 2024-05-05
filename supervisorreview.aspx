﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="supervisorreview.aspx.cs" Inherits="supervisorreview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    


</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form1" runat="server">
        <header class="bg-primary">
  <div class="container py-4">
    <h1>Groups Reviewed</h1>
  </div>
</header>
       
                <div style="height: 33px; margin-top: 0px;">
            <asp:Label ID="Label2" padding="20px" runat="server" BackColor="#808080" BorderColor="Black" BorderStyle="Groove" style="margin-left: 0px ; text-align:center; margin-top: 0px;" Text="" Width="100%" Height="42px">
          

                
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


        <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" Height="306px" 
    style="margin-left: 300px; border:inset; margin-top: 69px" BackColor="DimGray" Width="750px">
    <Columns>
        <asp:BoundField DataField="FYPTitle" HeaderText="Project Title" />
        <asp:BoundField DataField="IdeaMarks" HeaderText="Idea Marks" />
        <asp:BoundField DataField="PresentationMarks" HeaderText="Presentation Marks" />
        <asp:BoundField DataField="DocumentationMarks" HeaderText="Document Marks" />
        <asp:BoundField DataField="ResultMarks" HeaderText="Result Marks" />
        <asp:BoundField DataField="Suggestions" HeaderText="Supervisor Suggestion" />
    </Columns>
    <EmptyDataTemplate>
        <div>No data available.</div>
    </EmptyDataTemplate>
</asp:GridView>


        &nbsp;<br />&nbsp;<br />







    </form>


        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>




</body>
</html>
