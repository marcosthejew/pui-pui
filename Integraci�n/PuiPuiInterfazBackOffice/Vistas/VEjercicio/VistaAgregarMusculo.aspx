﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="VistaAgregarMusculo.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VEjercicio.VistaAgregarMusculo" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="HeadContent">

</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        AGREGAR MUSCULO
    </h2>
    <br />
    <asp:Label ID="_exito" runat="server" Text=" " Visible="False"></asp:Label>

    <br />

    <br />

        <table style="width: 454px" id="tablaMus">

            <tr>

                <td class="style2">

                    Nombre del musculo: &nbsp; 

                </td>

                <td class="style1">

                    <asp:TextBox ID="_nombre" runat="server" Width="270px" OnTextChanged="tbNombre_TextChanged"></asp:TextBox>

                </td>

            </tr>
            <tr><td class="auto-style6">

                   Descripcion: 
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="_descripcion" runat="server" Height="83px" Width="270px" TextMode="MultiLine" Font-Names="Arial"></asp:TextBox>
                </td></tr>

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

                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;

                    <asp:Button ID="bAgregar" runat="server" Text="Agregar" OnClick="Aceptar_Click" />

                </td>

            </tr>

        </table>

</asp:Content>