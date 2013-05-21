<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases.Agregar" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="superior">
    <h2 style="margin-left:350px">agregar clase</h2>
    
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
                    <asp:Label ID="Label4" runat="server" Text="Label">Nombre de la nueva clase:</asp:Label>
                </td>
                <td class="auto-style4" align="left">
                    <asp:TextBox ID="nombreNuevaClase" runat="server" Height="20px" Width="178px" style="margin-left: 3px"
                      ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Label">Descripcion:</asp:Label>
                </td>
                <td class="auto-style2" colspan="0" align="left">
                    <asp:TextBox ID="descripcioNuevaClase" runat="server" Height="59px" Width="189px" style="margin-left: 3px"
                      ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    </td>
                <td class="auto-style6" colspan="0">
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


