<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" 
    AutoEventWireup="true" CodeBehind="AgregarClaseSalon.aspx.cs" 
    Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_Clase_Salon_Instructor.AgregarClaseSalon" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center; font-family:Helvetica; font-size:16px;height:30px;">
    <asp:Label ID="Label1" runat="server" Text="CLASE - SALON - INSTRUCTOR"></asp:Label>
    </div>

    <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False"></asp:Label>
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
    </div>

    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center; font-family:Helvetica; font-size:14px;">Asignación de Clase - Salón - Instructor</legend>
               
            <table style="margin:0px auto auto 30%; height: 140px; width: 288px;" border="0" cellspacing="0" cellpadding="0" >
            <tr>
                <td class="auto-style5" align="left">
                    <asp:Label ID="Label2" runat="server" Text="Nombre de la Clase:" Font-Names="Arial" Font-Size="12px"></asp:Label>
                    
                </td>
                <td class="auto-style6" align="left">
                    <asp:DropDownList ID="ComboClase" runat="server" Height="18px" Width="120px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" align="left">
                    <asp:Label ID="Label4" runat="server" Text="Ubicación del Salón:" Font-Names="Arial" Font-Size="12px"></asp:Label>
                    
                </td>
                <td class="auto-style6" colspan="0" align="left">
                    <asp:DropDownList ID="ComboSalon" runat="server" Height="18px" Width="120px">
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td class="auto-style5" align="left">
                    <asp:Label ID="Label3" runat="server" Text="Instructor:" Font-Names="Arial" Font-Size="12px"></asp:Label>
                    
                    </td>
                <td class="auto-style6" colspan="0" align="left">
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
                <td class="auto-style7">
                    </td>
                <td class="auto-style8">
                    </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>

            <tr >
                <td colspan="2"  style="text-align:left">
                
                <asp:Button ID="Cancelar" runat="server" Text="Cancelar" Height="25px" Width="120px" Font-Names="Tomoha Plain" Font-Size="14px" OnClick="Cancelar_Click"/>
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
            width: 216px;
        }
        .auto-style2 {
            width: 164px;
        }
        .auto-style5 {
            width: 216px;
            height: 26px;
        }
        .auto-style6 {
            width: 164px;
            height: 26px;
        }
        #TextArea1 {
            height: 71px;
        }
        .auto-style7 {
            width: 216px;
            height: 17px;
        }
        .auto-style8 {
            width: 164px;
            height: 17px;
        }
        </style>
</asp:Content>


