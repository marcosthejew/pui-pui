<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" 
    AutoEventWireup="true" CodeBehind="AgregarClaseSalon.aspx.cs" 
    Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_Clase_Salon_Instructor.AgregarClaseSalon" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="superior">
    <h2 style="margin-left:350px">asignar clase Salon</h2>
    
    </div>

    <div style="height:30px; text-align:center; font-family:Verdana;font-size: 1.5em;">
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False"></asp:Label>
    </div>

    <div  >
        <fieldset style="width:400px; height:180px; margin-left:23%;">
               
            <table style="margin:5% auto auto 8%; height: 140px; width: 476px;" border="0" cellspacing="0" cellpadding="0" >
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Label">Nombre de la clase:</asp:Label>
                </td>
                <td class="auto-style4" align="left">
                    <asp:DropDownList ID="ComboClase" runat="server" Height="18px" Width="120px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Label">Ubicacion del Salon:</asp:Label>
                </td>
                <td class="auto-style2" colspan="0" align="left">
                    <asp:DropDownList ID="ComboSalon" runat="server" Height="18px" Width="120px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label5" runat="server" Text="Label">Instructor:</asp:Label>
                    </td>
                <td class="auto-style6" colspan="0">
                    <asp:DropDownList ID="ComboInstructor" runat="server" Height="18px" Width="120px">
                    </asp:DropDownList>
                    </td>
            </tr>
            <tr >
                <td colspan="2"  style="text-align:center">
                <asp:Button ID="defaultButton" runat="server" Text="Aceptar" CssClass="button" OnClick="defaultButton_Click" />
                </td>
            </tr>
            </table>          
        </fieldset>
    </div>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 127px;
        }
        .auto-style2 {
            width: 246px;
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
            height: 23px;
        }
        .auto-style6 {
            width: 246px;
            height: 23px;
        }
        #TextArea1 {
            height: 71px;
        }
    </style>
</asp:Content>


