<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="VistaDesactivarMusculo.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VEjercicio.VistaDesactivarMusculo" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
    .auto-style1 {
        height: 21px;
    }
</style>
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        DESACTIVAR MUSCULO
    </h2>
    <br />

    <asp:Label ID="_exito" runat="server" Text="El musculo se ha desactivado correctamente." Visible="False"></asp:Label>

    <br />
    <br />
        <table style="width: 454px" id="tablaMus">
            <tr>
                <td class="auto-style1">
                    Nombre del musculo: &nbsp; 
                </td>
                <td class="auto-style1">

                    <asp:DropDownList ID="_nombre" runat="server" Height="17px" Width="272px" AutoPostBack="True">
                    </asp:DropDownList>
    
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp; 
                </td>
                <td class="style1">
                   &nbsp; 
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp; 
                </td>
                <td class="style1">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
                    <asp:Button ID="bEliminar" runat="server" Text="Desactivar" OnClick="desactivar_Click" />
                </td>
            </tr>
        </table>
</asp:Content>
