<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Geestion_de_Salones.Modificar" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <div style="text-align:center; font-family:Helvetica; font-size:16px;height:30px">
    <asp:Label ID="Label6" runat="server" Text="Salón"></asp:Label>
    </div>

<div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False"></asp:Label>
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
    </div>

    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center; font-family:Helvetica; font-size:14px;">Modificar Salón</legend>
      <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="NClase" runat="server" Text="Debe introducir todos los campos obligatorios" CssClass="NClase" 
            Visible="False" ForeColor="Red" Font-Names="Arial" Font-Size="14px"></asp:Label>
        </div>                
            <table style="margin:5% auto auto 26%; height: 140px; width: 390px;" border="0" cellspacing="0" cellpadding="0" align="center">
            <tr>
                <td class="auto-style1" align="left">
                    <asp:Label ID="Label4" runat="server" Text="Ubicación:" Font-Names="Arial" Font-Size="12px"></asp:Label>
                </td>
                <td class="auto-style2">
                    &nbsp;<asp:TextBox ID="TextBoxUbicacion" runat="server" Height="22px" Width="270px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="left">
                    <asp:Label ID="Label3" runat="server" Text="Capacidad:" Font-Names="Arial" Font-Size="12px"></asp:Label>
                </td>
                <td class="auto-style2">
                    &nbsp;<asp:TextBox ID="TextBoxCapacidad" runat="server" Height="22px" Width="270px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style1" align="left">
                    <asp:Label ID="Label1" runat="server" Text="Status:" Font-Names="Arial" Font-Size="12px"></asp:Label></td>
                <td class="auto-style2" align="center">
                    &nbsp;<asp:RadioButton ID="Activo" runat="server" GroupName="EstatusSalon" />
                    <asp:Label ID="Label2" runat="server" Text="Activo" Font-Names="Arial" Font-Size="12px"></asp:Label>
                    &nbsp;&nbsp;&nbsp;<asp:RadioButton ID="Inactivo" runat="server" GroupName="EstatusSalon"/>
                    <asp:Label ID="Label5" runat="server" Text="Inactivo" Font-Names="Arial" Font-Size="12px"></asp:Label>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>

            <tr >
                <td colspan="2"  style="text-align:center">
                <asp:Button ID="Cancelar" runat="server" Text="Cancelar" Height="25px" Width="120px" Font-Size="14px" OnClick="Cancelar_Click"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Aceptar" runat="server" Text="Aceptar" Height="25px" Width="120px" Font-Size="14px" OnClick="Aceptar_Click"/>
                </td>
            </tr>
            </table>          
        </fieldset>
    </div>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 92px;
        }
        .auto-style2 {
            width: 207px;
        }
    </style>
</asp:Content>

