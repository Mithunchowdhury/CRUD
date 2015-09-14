<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MasterPageDemo.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
        

    </table>

</asp:Content>
