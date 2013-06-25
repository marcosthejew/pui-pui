<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="AgregarSalon.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VSalon.AgregarSalon" %>
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
          <legend style="text-align:center;"><h2>Agregar Salón</h2></legend>
            <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="NClase" runat="server" Text="Debe introducir todos los campos obligatorios" CssClass="NClase" 
            Visible="False" ForeColor="Red" Font-Names="Arial" Font-Size="14px"></asp:Label>
        </div> 
               
            <table style="margin:0px auto auto 22%; height: 140px; width: 473px;" border="0" cellspacing="0" cellpadding="0" align="center">
            <tr>
                <td class="auto-style3" align="left" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:Label ID="Rojo" runat="server" Text="Label" ForeColor="Red" Font-Names="Arial" Font-Size="12px">*</asp:Label>
                    <asp:Label ID="Label4" runat="server" Text="Ubicación:"></asp:Label>
                </td>
                <td class="auto-style2">
                    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="TextBoxUbicacion" runat="server" ErrorMessage="No se aceptan numero ni caracteres especiales" ForeColor="Red"  ValidationGroup="check" ValidationExpression="^[a-zA-Z''-'''.'\s]{1,45}$"  Display="Dynamic" ></asp:RegularExpressionValidator>
                    <asp:TextBox ID="TextBoxUbicacion" runat="server" Height="22px" Width="270px" ValidationGroup="check" Font-Names="Arial" Font-Size="12px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" align="left" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:Label ID="Label6" runat="server" Text="Label" ForeColor="Red" Font-Names="Arial" Font-Size="12px">*</asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="Capacidad:" ></asp:Label>
                    <br />
                    (Número de personas)</td>
                <td class="auto-style2">
                    &nbsp;<asp:TextBox ID="TextBoxCapacidad" runat="server" Height="22px" Width="61px" Font-Names="Arial" Font-Size="12px"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="TextBoxCapacidad" ValidationGroup="check" ForeColor="Red"  runat="server" ErrorMessage="Solo numero del 1-999" ValidationExpression="^[0-9]{1,3}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label7" runat="server" Text="Codigo del Salon:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxCodigo" runat="server" Height="22px" Width="206px" ValidationGroup="check" Font-Names="Arial" Font-Size="12px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style2">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="TextBoxCodigo" ValidationGroup="check" ForeColor="Red"  runat="server" ErrorMessage="No se aceptan numero ni caracteres especiales" ValidationExpression="^[a-zA-Z''-'''.'\s]{1,30}$"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>

            <tr >
                <td colspan="2"  style="text-align:center">
                <asp:Button ID="Cancelar" runat="server" Text="Cancelar" Height="25px" Width="120px" Font-Names="Tomoha Plain" Font-Size="14px" OnClick="Cancelar_Click"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Aceptar" runat="server" Text="Aceptar" Height="25px" Width="120px" OnClick="Aceptar_Click" ValidationGroup="check" Font-Names="Tomoha Plain" Font-Size="14px"/>
                </td>
            </tr>
            </table>          
        </fieldset>
    </div>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style2 {
            width: 207px;
        }
        .auto-style3 {
            width: 187px;
        }
        .auto-style4
        {
            width: 187px;
            height: 31px;
        }
        .auto-style5
        {
            width: 207px;
            height: 31px;
        }
    </style>
</asp:Content>