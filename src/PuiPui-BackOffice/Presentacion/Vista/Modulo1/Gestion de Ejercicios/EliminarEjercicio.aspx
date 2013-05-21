﻿<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
    AutoEventWireup="true" CodeBehind="EliminarEjercicio.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Ejercicios.EliminarEjercicio" %>
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

    .auto-style2 {
            width: 185px;
        }
    .auto-style3 {
            width: 133px;
        }

    .auto-style4 {
            width: 6px;
        }

        </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">

    <h2>
        ELIMINAR EJERCICIO
    </h2>
    <br />
    <asp:Label ID="lExito" runat="server" Text="No hay ejercicios." Visible="False" Font-Bold="False" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ejercicios:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlEjercicios" runat="server" Height="18px" Width="163px" OnSelectedIndexChanged="ddlEjercicios_SelectedIndexChanged" AutoPostBack="True" >
    </asp:DropDownList>
    <br />
    <br />
    <hr />
    <br />
    <br />

        <table style="width: 726px" id="tablaEjercicio">
            <tr>
                <td class="auto-style4" />
                <td class="auto-style3">
                    Nombre del Ejercicio: </td>
                <td class="auto-style2">
                    <asp:TextBox ID="tbNombre" runat="server" Width="269px" ReadOnly="True" Enabled="False"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style4" />
                <td class="auto-style3">
                   Descripcion: 
                </td>

                <td class="auto-style2">
                    <asp:TextBox ID="tbDescripcion" runat="server" Width="269px" ReadOnly="True" Columns="50" Height="83px" Rows="5" TextMode="MultiLine" style="margin-left: 2px" Font-Names="Arial" Enabled="False"></asp:TextBox>

                </td>

            </tr>

             <tr>
                <td class="auto-style4" />
                <td class="auto-style3">
                    Musculo a ejercitar:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="tbMusculo" runat="server" Width="269px" ReadOnly="True" Enabled="False"></asp:TextBox>
                </td>

            </tr>
        </table>
            <br />
    <br />
    <hr />
    <br />
    &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="bEliminar" runat="server" Text="Eliminar" OnClick="bEliminar_Click" />
    <br />
    <br />

</asp:Content>


