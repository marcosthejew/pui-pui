<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="CambiarContraseña.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Home.CambiarContraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ChangePassword ID="ChangePassword1" runat="server" OnChangingPassword="ChangePassword1_ChangingPassword" ></asp:ChangePassword>                            
</asp:Content>
