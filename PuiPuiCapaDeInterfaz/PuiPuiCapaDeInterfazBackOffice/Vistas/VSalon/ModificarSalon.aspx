<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="ModificarSalon.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VSalon.ModificarSalon" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <div style="text-align:center;">
    <h1>SALON</h1>
    </div>

<div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False" ForeColor="#ffffff"></asp:Label>
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
    </div>

    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
       <legend style="text-align:center;"><h2>Modificar Salón</h2></legend>
      <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="NClase" runat="server" Text="Debe introducir todos los campos obligatorios" CssClass="NClase" 
            Visible="False" ForeColor="Red" Font-Names="Arial" Font-Size="14px"></asp:Label>
          <br />
          <br />
&nbsp;<br />
&nbsp;&nbsp;
        </div>                
            <table style="margin:5% auto auto 26%; height: 140px; width: 432px;" border="0" cellspacing="0" cellpadding="0" align="center">
            <tr>
                <td class="auto-style1" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                   <asp:Label ID="Rojo" runat="server" Text="Label" ForeColor="Red" Font-Names="Arial" Font-Size="12px">*</asp:Label>
                    <asp:Label ID="Label4" runat="server" Text="Ubicación:"></asp:Label>
                &nbsp;
                </td>
                <td class="auto-style2">
                    &nbsp;<asp:TextBox ID="TextBoxUbicacion" runat="server" Height="22px" Width="270px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="TextBoxUbicacion" runat="server" ErrorMessage="No se aceptan numero ni caracteres especiales" ForeColor="Red"  ValidationGroup="check" ValidationExpression="^[a-zA-Z''-'''.'\s]{1,45}$"  Display="Dynamic" ></asp:RegularExpressionValidator>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:Label ID="Label6" runat="server" Text="Label" ForeColor="Red" Font-Names="Arial" Font-Size="12px">*</asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="Capacidad:" ></asp:Label>
                    <br />
                    (Número de personas)
                </td>
                <td class="auto-style4">
                    &nbsp;<asp:TextBox ID="TextBoxCapacidad" runat="server" Height="22px" Width="65px"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="TextBoxCapacidad" ValidationGroup="check" ForeColor="Red"  runat="server" ErrorMessage="Solo numero del 1-999" ValidationExpression="^[0-9]{1,3}$"></asp:RegularExpressionValidator>
                    <br />
                </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style1" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                  <asp:Label ID="Label7" runat="server" Text="Label" ForeColor="Red" Font-Names="Arial" Font-Size="12px">*</asp:Label>
                      <asp:Label ID="Label1" runat="server" Text="Status:"></asp:Label></td>
                <td class="auto-style2" align="center" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    &nbsp;<asp:RadioButton ID="Activo" runat="server" GroupName="EstatusSalon" />
                    <asp:Label ID="Label2" runat="server" Text="Activo"></asp:Label>
                    &nbsp;&nbsp;&nbsp;<asp:RadioButton ID="Inactivo" runat="server" GroupName="EstatusSalon"/>
                    <asp:Label ID="Label5" runat="server" Text="Inactivo"></asp:Label>
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
                <asp:Button ID="Cancelar" runat="server" Text="Regresar" Height="25px" Width="120px" Font-Size="14px" OnClick="Cancelar_Click"/>
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
            width: 254px;
        }
        .auto-style3
        {
            width: 92px;
            height: 32px;
        }
        .auto-style4
        {
            width: 254px;
            height: 32px;
        }
    </style>
</asp:Content>

