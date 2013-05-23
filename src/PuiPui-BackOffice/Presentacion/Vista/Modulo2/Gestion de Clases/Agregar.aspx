<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases.Agregar" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center; font-family:Helvetica; font-size:16px;height:30px;">
    <asp:Label ID="Label1" runat="server" Text="Clase"></asp:Label>
    </div>

    <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False"></asp:Label>
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
    </div>

    <div  >
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center; font-family:Helvetica; font-size:14px;">Agregar Clase</legend>
        <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="NClase" runat="server" Text="Debe introducir todos los campos obligatorios" CssClass="NClase" 
            Visible="False" ForeColor="Red" Font-Names="Arial" Font-Size="14px"></asp:Label>
        </div>       
            <table style="margin:0px auto auto 22%; height: 140px; width: 476px;" border="0" cellspacing="0" cellpadding="0" >
            <tr>
                <td class="auto-style3" align="left">
                    <asp:Label ID="Rojo" runat="server" Text="Label" ForeColor="Red" Font-Names="Arial" Font-Size="12px">*</asp:Label>
                    <asp:Label ID="Label4" runat="server" Text="Label" Font-Names="Arial" Font-Size="12px">Nombre de la nueva clase:</asp:Label>
                </td>
                <td class="auto-style4">
                    &nbsp;<asp:TextBox ID="nombreNuevaClase" runat="server" Height="22px" Width="270px" Font-Names="Arial" Font-Size="12px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="left">
                    <asp:Label ID="Label6" runat="server" Text="Label" ForeColor="Red" Font-Names="Arial" Font-Size="12px">*</asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="Label">Descripción:</asp:Label>
                </td>
                <td class="auto-style2">
                    &nbsp;<asp:TextBox id="descripcioNuevaClase" runat="server" Wrap="true" TextMode="MultiLine" Width="200px" Height="115px" Font-Names="Arial" Font-Size="12px"></asp:TextBox>
                
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
                    <asp:Label ID="Label7" runat="server" Text="Label" ForeColor="Red" Font-Names="Arial" Font-Size="12px">* Campos Obligatorios</asp:Label>
                   
                    </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>

            <tr >
                <td colspan="2"  style="text-align:center">
                <asp:Button ID="Cancelar" runat="server" Text="Cancelar" Height="25px" Width="120px" Font-Names="Tomoha Plain" Font-Size="14px" OnClick="Cancelar_Click"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Aceptar" runat="server" Text="Aceptar" Height="25px" Width="120px" OnClick="Aceptar_Click" Font-Names="Tomoha Plain" Font-Size="14px"/>
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
        #TextArea1 {
            height: 71px;
        }
        .auto-style7 {
            width: 127px;
            height: 17px;
        }
        .auto-style8 {
            width: 246px;
            height: 17px;
        }
    </style>
</asp:Content>


