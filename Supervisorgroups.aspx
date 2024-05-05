<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Supervisorgroups.aspx.cs" Inherits="Supervisorgroups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        #Text1 {
            margin-left: 86px;
        }
        
        #Text2 {
            margin-left: 87px;
        }
        
        #Text3 {
            margin-left: 745px;
            margin-top: 0px;
        }
        
        #Text4 {
            margin-left: 746px;
        }
        
        #Text3 {
            margin-left: 87px;
        }
        
        #Text4 {
            margin-left: 87px;
        }
        
        #Text5 {
            margin-left: 86px;
        }
        
        #Text6 {
            margin-left: 87px;
        }
        
        #Text7 {
            margin-left: 745px;
            margin-top: 0px;
        }
        
        #Text8 {
            margin-left: 746px;
        }
        
        #Text7 {
            margin-left: 87px;
        }
        
        #Text8 {
            margin-left: 87px;
        }
        
        #Text9 {
            margin-left: 86px;
        }
        
        #Text10 {
            margin-left: 87px;
        }
        
        #Text11 {
            margin-left: 745px;
            margin-top: 0px;
        }
        
        #Text12 {
            margin-left: 746px;
        }
        
        #Text11 {
            margin-left: 87px;
        }
        
        #Text12 {
            margin-left: 87px;
        }
        
        #Text13 {
            margin-left: 86px;
        }
        
        #Text14 {
            margin-left: 87px;
        }
        
        #Text15 {
            margin-left: 745px;
            margin-top: 0px;
        }
        
        #Text16 {
            margin-left: 746px;
        }
        
        #Text15 {
            margin-left: 87px;
        }
        
        #Text16 {
            margin-left: 87px;
        }
        
        #Text17 {
            margin-left: 86px;
        }
        
        #Text18 {
            margin-left: 87px;
        }
        
        #Text19 {
            margin-left: 745px;
            margin-top: 0px;
        }
        
        #Text20 {
            margin-left: 746px;
        }
        
        #Text19 {
            margin-left: 87px;
        }
        
        #Text20 {
            margin-left: 87px;
        }
        
        #Text21 {
            margin-left: 86px;
        }
        
        #Text22 {
            margin-left: 87px;
        }
        
        #Text23 {
            margin-left: 745px;
            margin-top: 0px;
        }
        
        #Text24 {
            margin-left: 746px;
        }
        
        #Text23 {
            margin-left: 87px;
        }
        
        #Text24 {
            margin-left: 87px;
        }
        
        #Text25 {
            margin-left: 87px;
        }
        
        #Text26 {
            margin-left: 87px;
        }
        
        #Text27 {
            margin-left: 87px;
        }
        
        #Text28 {
            margin-left: 87px;
        }
        
        #Text29 {
            margin-left: 87px;
        }
        
        #Text30 {
            margin-left: 87px;
        }
        </style>
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form2" runat="server">
        <header class="bg-primary">
  <div class="container py-4">
    <h1>Groups Assigned</h1>
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


        <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" Height="306px" style="margin-left: 300px; border: inset; margin-top: 69px" BackColor="DimGray" Width="650px">
    <Columns>
        <asp:BoundField DataField="GroupName" HeaderText="Group Name" />
        <asp:BoundField DataField="GroupMembers" HeaderText="Group Members" />
        <asp:BoundField DataField="ProjectTitle" HeaderText="Group project" />
    </Columns>
    <EmptyDataTemplate>
        <div>No data available.</div>
    </EmptyDataTemplate>
</asp:GridView>


       






    </form>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>



</body>
</html>
