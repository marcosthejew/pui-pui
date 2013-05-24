<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="DetalleClaseSalonInstructor.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_Clase_Salon_Instructor.WebForm1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center;">
    <h1>CLASE - SALON - INSTRUCTOR</h1>
        
    </div>

   <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False" ForeColor="#ffffff"></asp:Label>
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
    </div>

    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center;"><h2>Asignación de Clase - Salón - Instructor</h2></legend>
               
            <table style="margin:5% auto auto 18%; height: 140px; width: 440px;" border="0" cellspacing="0" cellpadding="0" >
            <tr>
                <td class="auto-style3" align="left">
                    <h3>Nombre de la Clase:</h3>
                    
                </td>
                <td class="auto-style4" style="text-align:left">
                   <asp:TextBox ID="etiqueta_clase" runat="server" Font-Names="Arial" Font-Size="12px" Width="150px" Enabled="False"></asp:TextBox>
                    
                </td>
                <td class="auto-style8"><asp:DropDownList ID="ComboClase" runat="server" Height="22px" Width="120px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td class="auto-style9" align="left">
                    <h3>Ubicación del Salón:</h3>
                    
                </td>
                <td class="auto-style10" colspan="0" style="text-align:left">
                                      
                   <asp:TextBox ID="etiqueta_salonA" runat="server" Font-Names="Arial" Font-Size="12px" Width="150px" Enabled="False"></asp:TextBox>
                    
                </td>
                <td class="auto-style11">
                    
                    <asp:DropDownList ID="ComboSalon" runat="server" Height="22px" Width="120px">
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td class="auto-style5" align="left">
                    <h3>Instructor:</h3>
                    
                    </td>
                <td class="auto-style6" colspan="0" style="text-align:left" align="left">
                    
                   <asp:TextBox ID="etiqueta_instructorA" runat="server" Font-Names="Arial" Font-Size="12px" Width="150px" Enabled="False"></asp:TextBox>
                    
                    </td>
                <td class="auto-style7">
                    
                    <asp:DropDownList ID="ComboInstructor" runat="server" Height="22px" Width="120px">
                    </asp:DropDownList>
                    </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    <h3>Estatus:</h3></td>
                <td class="auto-style2" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    
                    <asp:RadioButton ID="Activo" Text="Activo" runat="server" OnCheckedChanged="Activo_CheckedChanged" GroupName="radio"/>
                    
                    <asp:RadioButton ID="Inactivo" Text="Inactivo"  runat="server" OnCheckedChanged="Inactivo_CheckedChanged" GroupName="radio" />
                    
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td><asp:Button ID="defaultButton" runat="server" Text="Aceptar" CssClass="button" OnClick="defaultButton_Click" Font-Names="tomoha plain" Font-Size="14px" Height="25px" Width="120px" />
                </td>
            </tr>
            </table>          
        </fieldset>
    </div>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 125px;
        }
        .auto-style2 {
            width: 172px;
        }
        .auto-style3 {
            width: 125px;
            height: 43px;
        }
        .auto-style4 {
            width: 172px;
            height: 43px;
        }
        .auto-style5 {
            width: 125px;
            height: 34px;
        }
        .auto-style6 {
            width: 172px;
            height: 34px;
        }
        #TextArea1 {
            height: 71px;
        }
        .auto-style7 {
            height: 34px;
        }
        .auto-style8 {
            height: 43px;
        }
        .auto-style9 {
            width: 125px;
            height: 39px;
        }
        .auto-style10 {
            width: 172px;
            height: 39px;
        }
        .auto-style11 {
            height: 39px;
        }
    </style>
</asp:Content>



