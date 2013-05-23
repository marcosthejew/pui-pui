<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" 
    AutoEventWireup="true" CodeBehind="AgregarClaseSalon.aspx.cs" 
    Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_Clase_Salon_Instructor.AgregarClaseSalon" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center; font-family:Helvetica; font-size:16px;">
    <asp:Label ID="Label1" runat="server" Text="CLASE - SALON"></asp:Label>
    </div>

    <div style="height:30px; text-align:center; font-family:Helvetica; font-size:14px;">
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False"></asp:Label>
    </div>

    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center; font-family:Helvetica; font-size:14px;">Agregar Clase - Salón</legend>
               
            <table style="margin:5% auto auto 8%; height: 140px; width: 476px;" border="0" cellspacing="0" cellpadding="0" >
            <tr>
                <td class="auto-style3" align="center">
                    <asp:Label ID="Label2" runat="server" Text="Nombre de la Clase:" Font-Names="Arial" Font-Size="12px"></asp:Label>
                    
                </td>
                <td class="auto-style4" align="center">
                    <asp:DropDownList ID="ComboClase" runat="server" Height="18px" Width="120px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="center">
                    <asp:Label ID="Label4" runat="server" Text="Ubicación del Salón:" Font-Names="Arial" Font-Size="12px"></asp:Label>
                    
                </td>
                <td class="auto-style2" colspan="0" align="center">
                    <asp:DropDownList ID="ComboSalon" runat="server" Height="18px" Width="120px">
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>

            <tr>
                <td class="auto-style5" align="center">
                    <asp:Label ID="Label3" runat="server" Text="Instructor:" Font-Names="Arial" Font-Size="12px"></asp:Label>
                    
                    </td>
                <td class="auto-style6" colspan="0" align="center">
                    <asp:DropDownList ID="ComboInstructor" runat="server" Height="18px" Width="120px">
                    </asp:DropDownList>
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
                
                <asp:Button ID="Cancelar" runat="server" Text="Cancelar" Height="25px" Width="120px" Font-Names="Tomoha Plain" Font-Size="14px"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="defaultButton" runat="server" Text="Aceptar" CssClass="button" OnClick="defaultButton_Click" Font-Names="tomoha plain" Font-Size="14px" Height="25px" Width="120px" />
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


