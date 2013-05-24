<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PuiPui_FrontOffice.Presentacion.Vista.Home.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div id="templatemo_leftmenu_section">

        <div id="templatemo_leftmenu_top"></div>

        <div id="templatemo_leftmenu_mid">
    <h2>
        Inicie Sesión
    </h2>
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" LoginButtonText="Ingresar" 
        PasswordLabelText="Password" RememberMeText="Recordarme la proxima vez" TitleText=" " UserNameLabelText="Login">
    </asp:Login>
            </div>
        <div id="templatemo_leftmenu_bot"></div>
    </div>
</asp:Content>
