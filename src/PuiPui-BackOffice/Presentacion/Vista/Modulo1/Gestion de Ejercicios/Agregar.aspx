﻿<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Ejercicios.Agregar" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="HeadContent">

</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        AGREGAR MUSCULO
    </h2>
    <br />

    <asp:Label ID="lExito" runat="server" Text="El ejercicio se ha agregado correctamente." Visible="False"> </asp:Label>

    <br />

    <br />

        <table style="width: 454px" id="tablaMus">

            <tr>

                <td class="style2">

                    Nombre del musculo: &nbsp; 

                </td>

                <td class="style1">

                    <asp:TextBox ID="tbNombre" runat="server" Width="268px"></asp:TextBox>

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

                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;

                    <asp:Button ID="bAgregar" runat="server" Text="Agregar" OnClick="bAgregar_Click" />

                </td>

            </tr>

        </table>

</asp:Content>