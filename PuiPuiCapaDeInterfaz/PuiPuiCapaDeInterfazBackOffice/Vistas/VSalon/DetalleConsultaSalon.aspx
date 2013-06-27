<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="DetalleConsultaSalon.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VSalon.DetalleConsultaSalon" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <div style="text-align:center;">
    <h1>SALON</h1>
    </div>

    <div style="height:30px; text-align:left; font-family:Helvetica; font-size:14px;">
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False" ForeColor="#ffffff"></asp:Label>
    </div>

    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">            <legend style="text-align:center;"><h2>Detalle Salón</h2></legend>     
            <table style="margin:5% auto auto 26%; height: 140px; width: 455px;" border="0" cellspacing="0" cellpadding="0" align="center">
            <tr>
                <td class="auto-style3" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    
                    <asp:Label ID="Label4" runat="server" Text="Ubicación:"></asp:Label>
                </td>
                <td class="auto-style4">
                    &nbsp;<asp:TextBox ID="TextBoxUbicacion" runat="server" Height="22px" Width="202px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    
                    <asp:Label ID="Label3" runat="server" Text="Capacidad:" ></asp:Label>
                </td>
                <td class="auto-style6">
                    &nbsp;<asp:TextBox ID="TextBoxCapacidad" runat="server" Height="22px" Width="44px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style1" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    
                    <asp:Label ID="Label2" runat="server" Text="Status:" ></asp:Label>
                </td>
                <td class="auto-style2">
                    &nbsp;<asp:TextBox ID="TextBoxStatus" runat="server" Height="22px" Width="126px" Enabled="False"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style7">
                  <h2>Codigo del Salon:</h2>  
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBoxCodigo" runat="server" Height="22px" Width="189px"  Font-Names="Arial" Font-Size="12px" Enabled="False" ></asp:TextBox>
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

            <tr >
                <td colspan="2"  style="text-align:center">
                <asp:Button ID="Regresar" runat="server" Text="Regresar" Height="25px" Width="120px"  Font-Size="14px" OnClick="Regresar_Click"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Modificar" runat="server" Text="Modificar" Height="25px" Width="120px" OnClick="Modificar_Click" Font-Size="14px"/>
                </td>
            </tr>
            </table>          
        </fieldset>
    </div>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 180px;
        }
        .auto-style2 {
            width: 207px;
        }
        .auto-style3
        {
            width: 180px;
            height: 76px;
        }
        .auto-style4
        {
            width: 207px;
            height: 76px;
        }
        .auto-style5
        {
            width: 180px;
            height: 44px;
        }
        .auto-style6
        {
            width: 207px;
            height: 44px;
        }
        .auto-style7
        {
            width: 180px;
            height: 46px;
        }
        .auto-style8
        {
            width: 207px;
            height: 46px;
        }
    </style>
</asp:Content>
