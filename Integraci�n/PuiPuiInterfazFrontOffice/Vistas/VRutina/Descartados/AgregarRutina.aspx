<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazFrontOffice.Master" AutoEventWireup="true" CodeBehind="AgregarRutina.aspx.cs" Inherits="PuiPuiCapaDeInterfazFrontOffice.Vistas.VRutina.AgregarRutina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Label ID="error" runat="server" CssClass="falla" Font-Bold="True"></asp:Label>
    
    <div style="height: 30px; text-align: center; font-family: Verdana; font-size: 1.5em;">
        <h1> Agregar Rutina</h1>
        <p> &nbsp;</p></div>
    <div style="float: left; height: 779px;" >
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td class="auto-style6">Nombre</td>
                <td class="auto-style2">
                    <asp:TextBox ID="LNombre" runat="server" Height="21px" Width="272px" MaxLength="8"></asp:TextBox>
                </td>
                
                <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripcion</td>
                <td class="auto-style2">
                    <asp:TextBox ID="LDescripcion" runat="server" Height="21px" Width="272px" MaxLength="8"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="repeticionRadioButton" GroupName="Grupo1" runat="server" 
                     oncheckedchanged="repeticionRadioButton_CheckedChanged" AutoPostBack="true"/>
                     Repeticiones:
                </td>
                <td>
                    <asp:TextBox ID="LRepeticiones" runat="server" Height="21px" Width="272px"></asp:TextBox>
                </td>
                <td>
                    <asp:RadioButton ID="duracionRadioButton" GroupName="Grupo1" runat="server" 
                     oncheckedchanged="duracionRadioButton_CheckedChanged" AutoPostBack="true"/>
                     Duracion:
                </td>
                <td>
                    <asp:TextBox ID="LDuracion" runat="server" Height="21px" Width="272px"></asp:TextBox>
                </td>
            </tr>
        </table> 
        
        <table style="width:116%;">
        <tr>
            <td class="auto-style35">
                Ejercicio No Asociado<br />
                <asp:ListBox ID="LBEjercicioNoAsociado" runat="server" Height="280px" 
                     Width="266px" OnSelectedIndexChanged="EjercicioNoAsociado_SelectedIndexChanged">
                </asp:ListBox>
            </td>
            <td class="auto-style36">
                <asp:Button ID="AgregarEjercicio" runat="server" CssClass="button" 
                     OnClick="AgregarEjercicio_Click" Text="Agregar -->" />
                <br />
                <br />
                <br />
                <asp:Button ID="EliminarEjercicio" runat="server" CssClass="button" 
                     OnClick="EliminarEjercicio_Click" Text="<-- Eliminar" />
            </td>    
            <td>
                Ejercicio Asociado<br />
                <asp:ListBox ID="LBEjercicioAsociado" runat="server" Height="280px" 
                     Width="268px" OnSelectedIndexChanged="EjercicioAsociado_SelectedIndexChanged">
                </asp:ListBox>
            </td>
        </tr>
        <tr>
            <td colspan="4" align="center">
                <br />
                <br />
                <br />
                <asp:Button ID="BGugardar" runat="server" CssClass="button" Height="25" OnClick="BGuardar_Click" Text="Guardar" Width="120" />
                <br />
            </td>
        </tr>    
    </table>
    </div>


</asp:Content>
