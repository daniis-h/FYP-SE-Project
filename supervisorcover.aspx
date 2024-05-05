<%@ Page Language="C#" AutoEventWireup="true" CodeFile="supervisorcover.aspx.cs" Inherits="supervisorcover" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('grad2.jpg'); background-size: cover; background-position: center; background-repeat: no-repeat;">
    <form id="form1" runat="server">
        <header class="bg-primary">
  <div class="container py-4">
    <h1>Welcome Supervisor</h1>
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

        <div >
<div class="table-responsive" style="padding: 60px; align-items:center"> 
       <table class="table" style="border-style: inset; padding: 11px; background-color:dimgrey">
           <thead class="thead-dark">  <!--color of the head row-->
               <tr>
                   <th scope="col" class="auto-style1" style="font-size: large">My Profile</th>
                   <th scope="col" class="text-white"> </th>

               </tr>
           </thead>
           <tbody> <!-- table body -->
              
                   <td class="auto-style3"> <!-- 1st row-->
                           
                       <p style="color: #000000"><b>Name </b></p> </div>
                       
                   </td>
                   <td class="auto-style4">
                       
                       <asp:Label ID="Label7" runat="server" Text=" "></asp:Label>
                       
                   </td>
                   
               
               <!----->
               <tr>  <!-- 2nd row-->
                   <td class="auto-style2">
                        <p style="color: #000000"><b>ID</b></p>
                   </td>
                   <td>
                      
                       <asp:Label ID="Label8" runat="server" Text=" "></asp:Label>
                      
                   </td>
                   
               </tr>
               <!----->
               <tr>  <!-- 3rd row-->
                   <td class="auto-style2">
                        <p style="color: #000000"><b>Field </b></p>
                   </td>
                   <td>
   
                       <asp:Label ID="Label9" runat="server" Text=" "></asp:Label>
   
                   </td>
                   
               </tr>
               <!----->
               <tr>  <!-- 4 row-->
                   <td class="auto-style2">
                        <p style="color: #000000"><b>Phone Number</b></p>
                   </td>
                   <td>
   
                       <asp:Label ID="Label10" runat="server" Text=" "></asp:Label>
   
                   </td>
                   
               </tr>
               <!----->
            
           

           </tbody>
       </table>
   </div>




    </form>



            <!-- Latest compiled and minified CSS -->

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
