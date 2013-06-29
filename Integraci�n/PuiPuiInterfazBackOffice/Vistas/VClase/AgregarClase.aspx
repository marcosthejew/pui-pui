<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="AgregarClase.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VClase.AgregarClase" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center; font-family:Helvetica; font-size:16px;height:30px;">
    <asp:Label ID="Label1" runat="server" Text="<h1>CLASE</h1>"></asp:Label>
    </div>

    <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False" ForeColor="#ffffff"></asp:Label>
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
    </div>

    <div  >
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center; font-family:Helvetica; font-size:14px;">
            </legend><h2>Agregar Clase</h2>
        <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="NClase" runat="server" Text="Debe introducir todos los campos obligatorios" CssClass="NClase" 
            Visible="False" ForeColor="Red" Font-Names="Arial" Font-Size="14px"></asp:Label>
        </div>       
            <table style="margin:0px auto auto 22%; height: 140px; width: 531px;" border="0" cellspacing="0" cellpadding="0" >
            <tr>
                <td class="auto-style3" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:Label ID="Rojo" runat="server" Text="Label" ForeColor="Red" Font-Names="Arial" Font-Size="12px">*</asp:Label>
                    <asp:Label ID="Label4" runat="server" Text="Label">Nombre de la nueva clase:</asp:Label>
                </td>
                <td class="auto-style4">
         
                    
                    
                 <asp:TextBox ID="nombreNuevaClase" runat="server" Height="23px" Width="231px"  Font-Names="Arial" Font-Size="12px" ValidationGroup="check"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="ValidacionExpresionRegular" ControlToValidate="nombreNuevaClase" runat="server" ForeColor="Red"
                        ErrorMessage="Solo se pueden introducir letras y numeros (sin caracteres especiales)" ValidationGroup="check" ValidationExpression="^[a-zA-Z 0-9''-'\s]{1,25}$"  Display="Dynamic" ></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:Label ID="Label6" runat="server" Text="Label" ForeColor="Red" Font-Names="Arial" Font-Size="12px">*</asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="Label">Descripción:</asp:Label>
                </td>
                <td class="auto-style9">
                   <asp:TextBox id="descripcioNuevaClase" runat="server" Wrap="true" TextMode="MultiLine" Width="276px" Height="141px" Font-Names="Arial" Font-Size="12px" ValidationGroup="check" style="margin-top: 0px" ></asp:TextBox>
                
                    <asp:RegularExpressionValidator ID="ValidacionExpresionRegular2" ControlToValidate="descripcioNuevaClase" ForeColor="Red" ValidationGroup="check" runat="server" ValidationExpression="^[a-zA-Z 0-9''-'\s]{1,50}$" ErrorMessage="La descripcion no debe tener mas de 50 caracteres ni se pueden usar caracteres especiales"></asp:RegularExpressionValidator>
                
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
            width: 192px;
        }
        .auto-style2 {
            width: 246px;
        }
        .auto-style3 {
            width: 192px;
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
            width: 192px;
            height: 17px;
        }
        .auto-style8
        {
            width: 192px;
            height: 266px;
        }
        .auto-style9
        {
            width: 246px;
            height: 266px;
        }
        </style>
</asp:Content>
