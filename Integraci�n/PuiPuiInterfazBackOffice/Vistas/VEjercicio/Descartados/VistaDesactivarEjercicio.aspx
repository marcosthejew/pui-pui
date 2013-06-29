<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="VistaDesactivarEjercicio.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VEjercicio.VistaDesactivarEjercicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

    #TextArea1 {
        height: 104px;
        width: 268px;
    }

    #taDescripcion {
        width: 268px;
        height: 66px;
    }

        .auto-style8 {
        width: 199px;
            height: 26px;
        }

        .auto-style9 {
            height: 26px;
        }

        </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">

    <h2 style="text-align:center">
        DESACTIVAR EJERCICIO
    </h2>
    <br />
    <asp:Label ID="_exito" runat="server" Text=" " Visible="False" Font-Bold="False"></asp:Label>
   
    <br />
    <table style="width: 543px; margin-left:100px" id="tabla" >
        <tr>
                <td class="auto-style8">
                    Ejercicio:
                <td class="auto-style9">
                    <asp:DropDownList ID="_nombre" runat="server" Height="18px" Width="275px" OnSelectedIndexChanged="ddlEjercicios_SelectedIndexChanged" AutoPostBack="True" >
                     </asp:DropDownList>
                </td>
            </tr>
        <tr><td></td><td></td></tr>
        tr><td></td><td>
<asp:Button ID="bEliminar" runat="server" Text="Desactivar" OnClick="Desactivar_Click" />
        </td></tr>
        </table>
   

</asp:Content>
