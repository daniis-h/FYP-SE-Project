<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studentprogress.aspx.cs" Inherits="studentprogress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            margin-left: 150px;
        }
        #Text2 {
            width: 323px;
            height: 97px;
            margin-left: 150px;
            margin-top: 0px;
        }
    </style>
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    
    
    
    <form id="form1" runat="server">
         
         <header class="bg-primary">
  <div class="container py-4">
    <h1>Project Progress</h1>
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
            <asp:Label ID="Label2" padding="20px" runat="server" BackColor="#0099FF" BorderColor="Black" BorderStyle="Groove" style="margin-left: 369px; text-align:center; margin-top: 8px;" Text="Update Progress" Width="45%" Height="45px"></asp:Label>
          </p>
          <p>
              &nbsp;</p>
          <p>
              &nbsp;</p>
        <p style="height: 56px">
    <asp:Label ID="Label3" padding="20px" runat="server" BackColor="#0099FF" BorderColor="Black" BorderStyle="Groove" style="margin-left: 368px ; text-align:center" Text="Date:" Width="142px" Height="30px"></asp:Label>
    <input id="Text1" type="date" runat="server" /></p>
<p style="height: 78px">
    <asp:Label ID="Label4" padding="20px" runat="server" BackColor="#0099FF" BorderColor="Black" BorderStyle="Groove" style="margin-left: 369px; text-align:center; margin-top: 0px;" Text="Achievement" Width="142px" Height="30px"></asp:Label>






    <input id="Text2" type="text" runat="server" /><p style="height: 70px">
            <asp:Button ID="Button3" runat="server" style="margin-left: 588px; margin-top: 28px;" Text="Submit" Width="133px" Height="25px" OnClick="Button3_Click1" />
            </p>
          <p style="height: 70px">
            <asp:Button ID="Button5" runat="server" BackColor="#0099FF" style="margin-left: 492px; margin-top: 28px;" Text="View Progress" Width="188px" Height="47px" OnClick="Button5_Click" />
            </p>
          <p style="height: 70px">
              &nbsp;</p>
    </form>

            <!-- Latest compiled and minified CSS -->

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>

</body>
</html>
