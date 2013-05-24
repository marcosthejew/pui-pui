<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="PuiPui_FrontOffice.Presentacion.Vista.Modulo5.Consultar" %>
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

        .auto-style5 {
            width: 185px;
            height: 30px;
        }

    .auto-style6 {
        width: 166px;
        height: 30px;
    }
    .auto-style7 {
        width: 185px;
        height: 86px;
    }
    .auto-style8 {
        width: 199px;
    }<a href="Eliminar.aspx">Eliminar.aspx</a>

        </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">

    <h2>
        cONSULTAR rUTINA</h2>
    <br />
    <asp:Label ID="lExito" runat="server" Text="No hay rutinas" Visible="False" Font-Bold="False" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <table style="width: 543px;" id="tabla">
        <tr>
                <td class="auto-style8">
                    Rutinas:
                <td class="style1">
                    <asp:DropDownList ID="ddlRutinas" runat="server" Height="18px" Width="275px" OnSelectedIndexChanged="ddlRutinas_SelectedIndexChanged" AutoPostBack="True" >
                     </asp:DropDownList>
                </td>
            </tr>
        </table>
    <br />
    <hr />
    <br />

        <table style="width: 543px; height: 154px;" id="tablaEjercicio">
            <tr>
                <td class="auto-style6">
                    Nombre Rutina</td>
                <td class="auto-style5">
                    <asp:Label ID="tbNombre" runat="server" ForeColor="Black"></asp:Label>

                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    Ejericicios</td>

                <td class="auto-style7">
                    <asp:TextBox ID="tbDescripcion" runat="server" Width="269px" ReadOnly="True" Columns="50" Height="83px" Rows="5" TextMode="MultiLine" style="margin-left: 2px" Font-Names="Arial" Enabled="False"></asp:TextBox>

                </td>

            </tr>

             <tr>
                <td class="auto-style6">
                    Tiempo</td>
                <td class="auto-style5">
                    <asp:Label ID="tbTiempo" runat="server" ForeColor="Black"></asp:Label>
                </td>

            </tr>
        </table>

        <table style="width: 541px; height: 21px;" id="tablaEjercicio0">

             <tr>
                <td class="auto-style6">
                    Repeticiones&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="tbRepeticiones" runat="server" ForeColor="Black"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                 </td>

            </tr>
        </table>
    <br />
    &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />

</asp:Content>