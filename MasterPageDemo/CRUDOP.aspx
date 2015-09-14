<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDOP.aspx.cs" Inherits="MasterPageDemo.CRUDOP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table>
      <tr>
          <td><b>Enter ID:</b></td>
          <td>
              <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

          </td>
      </tr>
        <tr>
          <td><b>Enter Name:</b></td>
          <td>
              <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

          </td>
      </tr>
        <tr>
            <td>
                <asp:Button ID="createButton" runat="server" Text="Create" OnClick="createButton_Click" /></td>
            <td>
                <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" /></td>
            <td>
                <asp:Button ID="deleteButton" runat="server" Text="Delete" OnClick="deleteButton_Click" /></td>
            
        </tr>
         <tr>
             <td colspan="3">
                 <b>
                     <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                 </b>
             </td>
         </tr>
    </table>
    </div>
    </form>
</body>
</html>
