<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarDetalle.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo6.Cliente.ConsultarDetalle" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2
        {
            width: 200px;
        }
        .auto-style6
        {
            width: 110px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div style="height: 30px; text-align: center; font-family: Verdana; font-size: 1.5em;">
        <asp:Label ID="falla" runat="server" Text="Label" Visible="False" CssClass="falla">Operación Fallida</asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Label" Visible="False" CssClass="Exito">Operación Realizada Exitosame</asp:Label>
    </div>
    <div style="float: left;">
          <div style="height: 30px; text-align: center; font-family: Verdana; font-size: 1.5em;">
        <h1> Detalle Persona</h1></div>

        
         <table style="margin:auto;" border="0" cellspacing="10" cellpadding="10" >
        
                <tr>
                    <td class="auto-style6">Identificador</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LIdentificador" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Fecha de Ingreso</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LFechaIngreso" runat="server" HHeight="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                     <tr>
                    <td class="auto-style6">Cedula</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LCedula" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Tipo Persona</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ComboTipo" runat="server" Height="22px" Width="100px" Enabled="false">
                            <asp:ListItem Value="Cliente">Cliente</asp:ListItem>
                            <asp:ListItem Value="Administrador">Administrador</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Fecha Nacimiento</td>
                    <td class="auto-style2">
                        <asp:Calendar ID="LFechaNacimiento" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" Enabled="false">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                    </td>
                    <td class="auto-style6">Genero</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ComboGenero" runat="server" Height="22px" Width="100px" Enabled="false">
                            <asp:ListItem Value="Femenino">Femenino</asp:ListItem>
                            <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Primer Nombre</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LPrimerNombre" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Segundo Nombre</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LSegundoNombre" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Primer Apellido</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LPrimerApellido" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Segundo Apellido</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LSegundoApellido" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="auto-style6">Telefono Celular</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LTelefonoCelular" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Telefono Local</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LTelefonoLocal" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Nombre contacto emergencia</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LNombreContactoEmergencia" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Telefono contacto emergencia</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LTelefonoContactoEmergencia" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="auto-style6">Correo Electronico</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LCorreo" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Ciudad</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LCiudad" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" >Direccion</td>
                    <td class="auto-style2"colspan="3">
                        <asp:TextBox ID="LDireccion" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Usuario</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LUsuario" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Contrasena</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LContrasena" runat="server" Height="21px" Width="272px" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Status</td>
                    <td class="auto-style2"colspan="3">
                        <asp:DropDownList ID="ComboStatus" runat="server" Height="22px" Width="100px" Enabled="false">
                            <asp:ListItem Value="Activo">Activo</asp:ListItem>
                            <asp:ListItem Value="Inactivo">Inactivo</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                  <tr>
                    <td colspan="4" align="center">
                        <asp:Button ID="BRegistrar" runat="server" CssClass="button" Width="120" Height="25"  onclick="BRegistrar_Click" Text="Aceptar" Visible="false" />
                    </td>
                </tr>
             </table>

    </div>

</asp:Content>
