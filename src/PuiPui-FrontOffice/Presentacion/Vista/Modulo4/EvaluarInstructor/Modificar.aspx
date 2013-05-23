<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.Master"
 AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="PuiPui_FrontOffice.Presentacion.Vista.Modulo4.EvaluarInstructor.Modificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p class="auto-style1">
        <strong>MODIFICAR EVALUACION</strong></p>
    <p>
        Instructor:&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="Instructores" runat="server" style="font-size: medium">
        </asp:DropDownList>
    </p>
    <p>
        Calificacion:&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="CalificacionDropDown" runat="server" style="font-size: medium" OnSelectedIndexChanged="CalificacionDropDown_SelectedIndexChanged" >
            <asp:ListItem Value="1">1</asp:ListItem>            
            <asp:ListItem Value="2">2</asp:ListItem>
            <asp:ListItem Value="3">3</asp:ListItem>
            <asp:ListItem Value="4">4</asp:ListItem>
            <asp:ListItem Value="5">5</asp:ListItem>
            <asp:ListItem Value="6">6</asp:ListItem>            
            <asp:ListItem Value="7">7</asp:ListItem>
            <asp:ListItem Value="8">8</asp:ListItem>
            <asp:ListItem Value="9">9</asp:ListItem>
            <asp:ListItem Value="10">10</asp:ListItem>
        </asp:DropDownList>
&nbsp;</p>
    <p>
        <asp:Button ID="ButtonModificar" runat="server" Text="Aceptar" OnClick="ButtonModificar_Click"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Cancelar" />
    </p>
    <p>
        <asp:Label ID="exito" runat="server" Text="La Evaluacion fue modificada con exito." ForeColor="Blue"></asp:Label>
    </p>
    <p>
        <asp:Label ID="falla" runat="server" Text="No se pudo modificar la evaluacion." ForeColor="Red"></asp:Label>
    </p>
</asp:Content>
