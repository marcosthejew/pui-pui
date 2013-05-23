<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.Master"
 AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="PuiPui_FrontOffice.Presentacion.Vista.Modulo4.ReservarInstructor.Agregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p class="auto-style1">
        <strong>RESERVAR INSTRUCTOR</strong></p>
    <p>
        Instructor:&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="Instructores" runat="server" style="font-size: medium">
        </asp:DropDownList>
    </p>
    <p>
        Seleccione el día:<br />
        <asp:Calendar ID="Calendar" runat="server" />
    </p>
    <p>
        Desde las :&nbsp;&nbsp;&nbsp; 
        <asp:DropDownList ID="ddlHoraInicial" runat="server" style="font-size: medium" />
        :
        <asp:DropDownList ID="ddlMinutosInicial" runat="server" style="font-size: medium" />
    </p>
    <p>
        Hasta las :&nbsp;&nbsp;&nbsp; 
        <asp:DropDownList ID="ddlHoraFinal" runat="server" style="font-size: medium" />
        :
        <asp:DropDownList ID="ddlMinutosFinal" runat="server" style="font-size: medium" />
    </p>
    <p>
        <asp:Button ID="ButtonAgregar" runat="server" Text="Aceptar" OnClick="ButtonAgregar_Click"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Cancelar" />
    </p>
    <p>
        <asp:Label ID="exito" runat="server" Text="La Evaluacion fue cargada con exito." ForeColor="Blue"></asp:Label>
    </p>
    <p>
        <asp:Label ID="falla" runat="server" Text="No se pudo cargar la evaluacion." ForeColor="Red"></asp:Label>
    </p>
</asp:Content>
