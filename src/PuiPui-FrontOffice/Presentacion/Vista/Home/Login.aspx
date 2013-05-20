<%@ Page Title="Página principal" Language="C#" MasterPageFile="../../MasterPage/Site1.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="PuiPui_FrontOffice._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
     <h2>
        Inicie Sesión
    </h2>
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" LoginButtonText="Ingresar" 
        PasswordLabelText="Password" RememberMeText="Recordarme la proxima vez" TitleText=" " UserNameLabelText="Login">
    </asp:Login>
                     
</asp:Content>
