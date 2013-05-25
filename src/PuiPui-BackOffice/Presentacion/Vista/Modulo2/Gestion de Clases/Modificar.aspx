<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
 AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases.Modificar" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center; font-family:Helvetica; font-size:16px;height:30px;">
    <asp:Label ID="Label6" runat="server" Text="<h1>CLASE</h1>"></asp:Label>
    </div>

    <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False" ForeColor="#ffffff"></asp:Label>
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
    </div>

    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center; font-family:Helvetica; font-size:14px;"><h2>Modificar Clase</h2></legend>
         <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="NClase" runat="server" Text="No debe dejar campos vacios" CssClass="NClase" 
            Visible="False" ForeColor="Red" Font-Names="Arial" Font-Size="14px"></asp:Label>
        </div>         
            <table style="margin:5% auto auto 22%; height: 140px; width: 439px;" border="0" cellspacing="0" cellpadding="0" >
            <tr>
                <td class="auto-style7" align="left">
                    <asp:Label ID="Label4" runat="server" Text="Label"><h2>Nombre de la clase:</h2></asp:Label>
                </td>
                <td class="auto-style8" align="left">
                    <asp:TextBox ID="nombreClaseAModificar" runat="server" Height="22px" Width="270px"
                      ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="left">
                    <asp:Label ID="Label3" runat="server" Text="Label"><h2>Descripción:</h2></asp:Label>
                </td>
                <td class="auto-style2" colspan="0" align="left">
                    <asp:TextBox id="TextArea" runat="server" Wrap="true" TextMode="MultiLine" Width="200px" Height="115px"></asp:TextBox>
                </td>    
            </tr>
            <tr>
                <td class="auto-style3" align="left">
                    <h2>Status:</h2></td>
                <td class="auto-style4" colspan="0" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:RadioButton ID="Activo" runat="server" GroupName="EstatusClases" Text="Activa" />
                    <asp:RadioButton ID="Inactivo" runat="server" GroupName="EstatusClases" Text="Inactiva" />
                    </td>
            </tr>
                <tr>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style6" colspan="0">
                    </td>
            </tr>
                <tr>
                <td class="auto-style5" align="center">
                <asp:Button ID="botonRegresar" runat="server" Text="Regresar" CssClass="button" Font-Names="Tomoha Plain" Font-Size="14px" Height="25px" Width="120px" OnClick="botonRegresar_Click"  />
                    </td>
                <td class="auto-style6" colspan="0" align="center">
                <asp:Button ID="botonAceptar" runat="server" Text="Aceptar" CssClass="button" Font-Names="Tomoha Plain" Font-Size="14px" Height="25px" Width="120px" OnClick="botonAceptar_Click"  />
                    </td>

            </tr>
            

            </table>          
        </fieldset>
    </div>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 163px;
            height: 134px;
        }
        .auto-style2 {
            width: 246px;
            height: 134px;
        }
        .auto-style3 {
            width: 163px;
            height: 34px;
        }
        .auto-style4 {
            width: 246px;
            height: 34px;
        }
        .auto-style5 {
            width: 163px;
            height: 24px;
        }
        .auto-style6 {
            width: 246px;
            height: 24px;
        }
        #TextArea1 {
            height: 71px;
        }
        .auto-style7 {
            width: 163px;
            height: 36px;
        }
        .auto-style8 {
            width: 246px;
            height: 36px;
        }
    </style>
</asp:Content>