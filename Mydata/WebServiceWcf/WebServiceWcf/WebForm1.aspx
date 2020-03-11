<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="WebForm1.aspx.cs" Inherits="WebServiceWcf.WebForm1" %>

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

                    <td>
                        <asp:Label ID="lbSname" runat="server" Text="Server Name"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtSname" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbDbName" runat="server" Text="DB Name"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDbName" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbUser" runat="server" Text="UserId"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbPswd" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPswd" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbQuery" runat="server" Text="Query"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtQuery" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>

                        <asp:Button ID="btnGetXml" runat="server" Text="Get XML" ValidateRequestMode="Disabled" OnClick="btnGetXml_Click" />
                    </td>
                     <td>
                         <asp:Button ID="btnGetData" runat="server" Text="Get Data" ValidateRequestMode="Disabled" OnClick="btnGetData_Click" />

                     </td>
                </tr>
              
            </table>

              <asp:TextBox ID="txtXml" runat="server" TextMode="MultiLine" Height="324px"  Width="335px"></asp:TextBox>
              <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
