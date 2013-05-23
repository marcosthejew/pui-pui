<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.Master"
 AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="PuiPui_FrontOffice.Presentacion.Vista.Modulo3.ReservarClase.Agregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 642px;
        }
        .auto-style2 {
            width: 425px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Seleccione una Clase:"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownListClases" runat="server" Height="30px" Width="380px">
    </asp:DropDownList>
    <asp:Button ID="ButtonEvaluar" runat="server" Text="Evaluar" Width="130px" OnClick="Button1_Click" Height="38px" />
    <br />
    <br />
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:Panel ID="Panel1" runat="server">
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="La clase seleccionada cumplio con sus espectativas:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="El ritmo o exigencia de la clase fue adecuado :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="El salon de clases cumplio con sus espectativas:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Le fue facil seguir el contenido de la clase:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="En general, como considera la clase:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    <table style="width:100%;">
        <tr>
            <td>OBSERVACIONES</td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox6" runat="server" Width="325px"></asp:TextBox>
               
            </td>
            <td> <asp:Button ID="Button1" runat="server" Text="Procesar Evaluacion" Width="135px" OnClick="Button1_Click1" /></td>
        </tr>
    </table>

        </asp:Panel>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
