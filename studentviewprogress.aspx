<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentviewprogress.aspx.cs" Inherits="studentviewprogress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            margin-left: 86px;
            width: 135px;
        }
        #Text2 {
            width: 178px;
            height: 97px;
            margin-left: 62px;
            margin-top: 0px;
        }
        #Text3 {
            margin-left: 86px;
            width: 135px;
        }
        #Text4 {
            width: 178px;
            height: 97px;
            margin-left: 62px;
            margin-top: 0px;
        }
    </style>
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form1" runat="server">
                         
        
                 <header class="bg-primary">
  <div class="container py-4">
    <h1>View Progress</h1>
      
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

<p>
  <asp:Label ID="Label2" padding="20px" runat="server" BackColor="#0099FF" BorderColor="Black" BorderStyle="Groove" style="margin-left: 369px; text-align:center; margin-top: 8px;" Text="View Progress" Width="45%" Height="45px"></asp:Label>
</p>


<asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" Height="306px" style="margin-left: 300px; border:inset; margin-top: 69px" BackColor="DimGray" Width="650px">
    <Columns>
        <asp:BoundField DataField="StudentName" HeaderText="Added by" />
        <asp:BoundField DataField="datee" HeaderText="Date Added" />
        <asp:BoundField DataField="Descriptionn" HeaderText="Achievement" />
        <asp:BoundField DataField="SupervisorReview" HeaderText="Supervisor Feedback" />
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
