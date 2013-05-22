﻿<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores.Consultar" %>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="MainContent">


    <h2>CONSULTAR&nbsp; INSTRUCTOR</h2>
    <p>
    <asp:Label ID="lExito" runat="server" Text="No hay instructores." Visible="False" Font-Bold="False" ForeColor="Red"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;
        INSTRUCTOR:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="ddlInstructores" runat="server" Height="21px" Width="233px" AutoPostBack="True" OnSelectedIndexChanged="ddlInstructores_SelectedIndexChanged" >
</asp:DropDownList>
    </p>
    <h3>Datos Personales:
    </h3>
    <hr />
    <table style="width: 899px">
        <tr>
            <td class="auto-style31">Cedula: 
                </td>
            <td class="auto-style13">
                <asp:Label ID="lbCedula" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
            <td class="auto-style25">Genero: 
                 </td>
            <td class="style1"><asp:Label ID="lbGenero" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style32">Primer Nombre: 
                </td>
            <td class="auto-style22">
                <asp:Label ID="lbNombre1" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
            <td class="auto-style26">Segundo Nombre: 
                 </td>
            <td class="auto-style24">
                <asp:Label ID="lbNombre2" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style31">Primer Apellido: 
                </td>
            <td class="auto-style13">
                <asp:Label ID="lbApellido1" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
            <td class="auto-style25">Segundo Apellido: 
                 </td>
            <td class="style1">
                <asp:Label ID="lbApellido2" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style33">Telefono Local:
                </td>
            <td class="auto-style15">
                <asp:Label ID="lbTlfLocal" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
            <td class="auto-style27">Telefono Celular: 
                 </td>
            <td class="auto-style14">
                <asp:Label ID="lbTlfCel" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style31">Ciudad:
                </td>
            <td class="auto-style13">
                <asp:Label ID="lbCiudad" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
            <td class="auto-style25">Direccion:
                 </td>
            <td class="style1">
                <asp:Label ID="lbDireccion" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style31">Fecha nacimiento:
                </td>
            <td class="auto-style13">
                <asp:Label ID="lbFechaNac" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
            <td class="auto-style25">E-mail:
                 </td>
            <td class="style1">
                <asp:Label ID="lbMail" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style28">Fecha de Registro:
                </td>
            <td class="auto-style29">
                <asp:Label ID="lbFechaRes" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
             <td class="auto-style30">Estatus:
                 </td>
            <td class="auto-style29">
                <asp:Label ID="lbStatus" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
        </tr>

    </table>
    <br />
    <h3>Datos de Emergencia:
         </h3>
    <hr />
    <table style="width: 899px">
        <tr>
            <td class="auto-style2">Persona Contacto:
                </td>
            <td class="auto-style6">
                <asp:Label ID="lbNomContacto" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
            <td class="auto-style7">Telefono:
                 <asp:Label ID="lbTLfContacto" runat="server" BackColor="White" ForeColor="Black" Text="Label"></asp:Label>
            </td>
            <td class="style1">&nbsp;</td>
        </tr>
    </table>
    <br />


    </asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">

        .auto-style13 {
            width: 165px;
        }
        .auto-style14 {
            height: 29px;
        }
        .auto-style15 {
            width: 165px;
            height: 29px;
        }
        .auto-style2 {
            width: 118px;
        }
        .auto-style6 {
            width: 319px;
        }
        .auto-style7 {
            width: 125px;
        }
        .auto-style22 {
            width: 165px;
            height: 22px;
        }
        .auto-style24 {
            height: 22px;
        }
        .auto-style25 {
            width: 166px;
        }
        .auto-style26 {
            width: 166px;
            height: 22px;
        }
        .auto-style27 {
            width: 166px;
            height: 29px;
        }
        .auto-style28 {
            width: 172px;
            height: 21px;
        }
        .auto-style29 {
            height: 21px;
        }
        .auto-style30 {
            width: 166px;
            height: 21px;
        }
        .auto-style31 {
            width: 172px;
        }
        .auto-style32 {
            width: 172px;
            height: 22px;
        }
        .auto-style33 {
            width: 172px;
            height: 29px;
        }
    </style>
</asp:Content>
