<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="Modificar1.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo6.Cliente.Modificar1" %>
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
        <asp:Label ID="falla" runat="server" Text="Label" CssClass="falla"></asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Label" CssClass="Exito"></asp:Label>
    </div>
    <div style="float: left;">
        
            <table style="margin:auto;" border="0" cellspacing="10" cellpadding="10" >
                <tr>
                    <td class="auto-style6">Identificador</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LIdentificador" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Fecha de Ingreso</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LFechaIngreso" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style6">Fecha Nacimiento</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LFechaNacimiento" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Genero</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ComboGenero" runat="server" Height="20px" Width="90px">
                            <asp:ListItem Value="Femenino">Femenino</asp:ListItem>
                            <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Primer Nombre</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LPrimerNombre" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Segundo Nombre</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LSegundoNombre" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Primer Apellido</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LPrimerApellido" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Segundo Apellido</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LSegundoApellido" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="auto-style6">Telefono Celular</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LTelefonoCelular" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Telefono Local</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LTelefonoLocal" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" >Direccion</td>
                    <td class="auto-style2"colspan="3">
                        <asp:TextBox ID="LDireccion" runat="server" Height="20px" Width="560px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Correo Electronico</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LCorreo" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Tipo de Persona</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ComboTipo" runat="server" Height="20px" Width="90px">
                            <asp:ListItem Value="Cliente">Cliente</asp:ListItem>
                            <asp:ListItem Value="Administrador">Administrador</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
    </div>

</asp:Content>
