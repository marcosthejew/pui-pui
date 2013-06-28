<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazFrontOffice.Master" AutoEventWireup="true" CodeBehind="ModificarEvaluacionInstructor.aspx.cs" Inherits="PuiPuiCapaDeInterfazFrontOffice.Vistas.VEvaluacionInstructor.ModificarEvaluacionInstructor" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align: center; font-family: Helvetica; font-size: 16px;">
        <asp:Label ID="Label2" runat="server" Text="<h1>EVALUACION INSTRUCTOR</h1>"></asp:Label>
    </div>

    <div style="height: 30px; text-align: left; font-family: Helvetica; font-size: 14px;">
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla"
            Visible="False" ForeColor="Red"></asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito"
            Visible="False" ForeColor="#ffffff"></asp:Label>
    </div>

    <div style="float: left;">
        <fieldset style="width: 775px; height: auto; margin-left: 7.5%; fit-position: center;">
            <legend style="text-align: center; font-family: Helvetica; font-size: 14px;">
                <h2>Modificar Evaluacion Instructor</h2>
            </legend>
            <asp:Label ID="NClase" runat="server" Text="No debe dejar campos vacios" CssClass="NClase" 
            Visible="False" ForeColor="Red" Font-Names="Arial" Font-Size="14px"></asp:Label>
            <table style="margin: 5% auto auto 22%; height: 140px; width: 422px;" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td class="auto-style7" align="left">
                        <asp:Label ID="Label4" runat="server" Text="Label"><h3>Nombre Instructor:</h3></asp:Label>
                    </td>
                    <td class="auto-style8" align="left">
                        <asp:TextBox ID="MnombreInstructor" runat="server" Height="22px" Width="270px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7" align="left">
                        <asp:Label ID="Label5" runat="server" Text="Label"><h3>Nombre Cliente:</h3></asp:Label>
                    </td>
                    <td class="auto-style8" align="left">
                        <asp:TextBox ID="nombreCliente" runat="server" Height="22px" Width="270px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7" align="left">
                        <asp:Label ID="Label1" runat="server" Text="Label"><h3>Fecha:</h3></asp:Label>
                    </td>
                    <td class="auto-style8" align="left">
                        <asp:TextBox ID="Fecha" runat="server" Height="22px" Width="270px" Enabled="false" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7" align="left">
                        <asp:Label ID="Label6" runat="server" Text="Label"><h3>Calificacion(0-5):</h3></asp:Label>
                    </td>
                    <td class="auto-style8" align="left">
                        <asp:TextBox ID="Calificacion" runat="server" Height="22px" Width="270px" ></asp:TextBox>
                    </td>
                </tr>


                <tr>
                    <td class="auto-style1" align="left">
                        <asp:Label ID="Label3" runat="server" Text="Label"><h3>Observacion:</h3></asp:Label>
                    </td>
                    <td class="auto-style2" colspan="0" align="left">
                        <asp:TextBox ID="Observacion" runat="server" TextMode="MultiLine" Width="200px" Height="115px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6" colspan="0"></td>
                </tr>
                <tr>
                    <td class="auto-style5" align="center">
                        <asp:Button ID="botonRegresar" runat="server" Text="Regresar" CssClass="button" Font-Names="Tomoha Plain" Font-Size="14px" Height="25px" OnClick="botonRegresar_Click" Width="120px" />
                    </td>
                    <td class="auto-style6" colspan="0" align="center">
                        <asp:Button ID="botonModificar" runat="server" Text="Modificar" CssClass="button" Font-Names="Tomoha Plain" Font-Size="14px" Height="25px" Width="120px" OnClick="botonModificar_Click" />
                    </td>

                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">&nbsp;</td>
                </tr>

            </table>
        </fieldset>
    </div>
</asp:Content>

<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .auto-style1
        {
            width: 146px;
            height: 134px;
        }

        .auto-style2
        {
            width: 246px;
            height: 134px;
        }

        .auto-style3
        {
            width: 146px;
            height: 34px;
        }

        .auto-style4
        {
            width: 246px;
            height: 34px;
        }

        .auto-style5
        {
            width: 146px;
            height: 24px;
        }

        .auto-style6
        {
            width: 246px;
            height: 24px;
        }

        #TextArea1
        {
            height: 71px;
        }

        .auto-style7
        {
            width: 146px;
            height: 36px;
        }

        .auto-style8
        {
            width: 246px;
            height: 36px;
        }
    </style>
</asp:Content>
