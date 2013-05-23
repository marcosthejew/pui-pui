<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaDetalle.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases.ConsultaDetalle" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center; font-family:Helvetica; font-size:16px;">
    <asp:Label ID="Label2" runat="server" Text="CLASE"></asp:Label>
    </div>

    <div style="height:30px; text-align:center; font-family:Helvetica; font-size:14px;">
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False"></asp:Label>
    </div>

    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center; font-family:Helvetica; font-size:14px;">Detalle Clase</legend>       
               
            <table style="margin:5% auto auto 8%; height: 140px; width: 476px;" border="0" cellspacing="0" cellpadding="0" >
            <tr>
                <td class="auto-style7" align="center">
                    <asp:Label ID="Label4" runat="server" Text="Label">Nombre de la clase:</asp:Label>
                </td>
                <td class="auto-style8" align="left">
                    <asp:TextBox ID="nombreClaseActual" runat="server" Height="22px" Width="270px" Enabled="False"
                      ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="center">
                    <asp:Label ID="Label3" runat="server" Text="Label">Descripción:</asp:Label>
                </td>
                <td class="auto-style2" colspan="0" align="left">
                    <asp:TextBox id="TextArea" runat="server" Wrap="true" TextMode="MultiLine" Enabled="False" Width="200px" Height="115px"></asp:TextBox>
                </td>    
            </tr>
            <tr>
                <td class="auto-style3" align="center">
                    Status:</td>
                <td class="auto-style4" colspan="0">
                    <asp:TextBox ID="EstatusActual" runat="server" Height="22px" Width="270px" Enabled="False"
                      ></asp:TextBox>
                    </td>
            </tr>
                <tr>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style6" colspan="0">
                    </td>
            </tr>
                <tr>
                <td class="auto-style5" align="center">
                <asp:Button ID="botonRegresar" runat="server" Text="Regresar" CssClass="button" Font-Names="Tomoha Plain" Font-Size="14px" Height="25px" OnClick="botonRegresar_Click" Width="120px"  />
                    </td>
                <td class="auto-style6" colspan="0" align="center">
                <asp:Button ID="botonAceptar" runat="server" Text="Modificar" CssClass="button" Font-Names="Tomoha Plain" Font-Size="14px" OnClick="botonAceptar_Click" Height="25px" Width="120px"  />
                    </td>

            </tr>
            <tr >
                <td colspan="2"  style="text-align:center">
                    &nbsp;</td>
            </tr>

            </table>          
        </fieldset>
    </div>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 127px;
            height: 134px;
        }
        .auto-style2 {
            width: 246px;
            height: 134px;
        }
        .auto-style3 {
            width: 127px;
            height: 34px;
        }
        .auto-style4 {
            width: 246px;
            height: 34px;
        }
        .auto-style5 {
            width: 127px;
            height: 24px;
        }
        .auto-style6 {
            width: 246px;
            height: 24px;
        }
        #TextArea1 {
            height: 71px;
        }
        .auto-style7 {
            width: 127px;
            height: 36px;
        }
        .auto-style8 {
            width: 246px;
            height: 36px;
        }
    </style>
</asp:Content>