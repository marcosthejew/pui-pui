<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="ModificarClase.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VClase.ModificarClase" %>
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

    <div  style="float:left; height: 648px; width: 891px;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center; font-family:Helvetica; font-size:14px;"><h2>Modificar Clase</h2></legend>
         <div style="height:59px; text-align:left; font-family:Helvetica; font-size:16px; width: 786px;">
        <asp:Label ID="NClase" runat="server" Text="No debe dejar campos vacios" CssClass="NClase" 
            Visible="False" ForeColor="Red" Font-Names="Arial" Font-Size="14px"></asp:Label>
             <br />
             <br />
             <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Clase a Modificar
             <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="225px">
             </asp:DropDownList>
        </div>         
            <table style="margin:5% 117px auto 22%; height: 512px; width: 535px;" border="0" cellspacing="0" cellpadding="0" >
            <tr>
                <td class="auto-style7" align="left">
                    <asp:Label ID="Label4" runat="server" Text="Label"><h2>Nombre de la clase:</h2></asp:Label>
                </td>
                <td class="auto-style8" align="left">
                    <asp:TextBox ID="nombreClaseAModificar" runat="server" Height="22px" ValidationGroup="check" Width="295px"
                      ></asp:TextBox>
                    <asp:RegularExpressionValidator ID="ValidacionExpresionRegular" ControlToValidate="nombreClaseAModificar" runat="server" ForeColor="Red"
                        ErrorMessage="Solo se pueden introducir letras y numeros (sin caracteres especiales)" ValidationGroup="check" ValidationExpression="^[a-zA-Z 0-9''-'\s]{1,25}$"  Display="Dynamic" ></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" align="left">
                    <asp:Label ID="Label3" runat="server" Text="Label"><h2>Descripción:</h2></asp:Label>
                </td>
                <td class="auto-style2" colspan="0" align="left">
                    <asp:TextBox id="TADescripcion" runat="server" Wrap="true" TextMode="MultiLine" Width="306px" Height="104px" ValidationGroup="check"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="ValidacionExpresionRegular2" ControlToValidate="TADescripcion" ForeColor="Red" ValidationGroup="check" runat="server" ValidationExpression="^[a-zA-Z 0-9''-'\s]{1,50}$" ErrorMessage="La descripcion no debe tener mas de 50 caracteres ni se pueden usar caracteres especiales"></asp:RegularExpressionValidator>
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
                <td class="auto-style9" align="center">
                <asp:Button ID="botonRegresar" runat="server" Text="Regresar" CssClass="button" Font-Names="Tomoha Plain" Font-Size="14px" Height="25px" Width="120px" OnClick="botonRegresar_Click"  />
                    </td>
                <td class="auto-style10" colspan="0" align="center">
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
            height: 195px;
        }
        .auto-style2 {
            width: 321px;
            height: 195px;
        }
        .auto-style3 {
            width: 163px;
            height: 34px;
        }
        .auto-style4 {
            width: 321px;
            height: 34px;
        }
        .auto-style5 {
            width: 163px;
            height: 24px;
        }
        .auto-style6 {
            width: 321px;
            height: 24px;
        }
        #TextArea1 {
            height: 71px;
        }
        .auto-style7 {
            width: 163px;
            height: 118px;
        }
        .auto-style8 {
            width: 321px;
            height: 118px;
        }
        .auto-style9
        {
            width: 163px;
            height: 69px;
        }
        .auto-style10
        {
            width: 321px;
            height: 69px;
        }
    </style>
</asp:Content>