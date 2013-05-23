<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master" 
AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Ejercicios.Consulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        #TextArea1 {

        height: 104px;

        width: 268px;

    }

    #taDescripcion {

        width: 268px;

        height: 66px;

    }

        .auto-style3 {
        width: 166px;
    }

        .auto-style4 {
        width: 166px;
        height: 86px;
    }
    .auto-style5 {
        width: 185px;
        height: 86px;
    }
    .auto-style6 {
        width: 166px;
        height: 30px;
    }
    .auto-style7 {
        width: 185px;
        height: 30px;
    }

        .auto-style8 {
        width: 197px;
    }

        </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">

    <h2>
        CONSULTAR EJERCICIO
    </h2>
    <br />
    <asp:Label ID="lExito" runat="server" Text="No hay ejercicios." Visible="False" Font-Bold="False" ForeColor="Red"></asp:Label>
    <br />
    <br /><table style="width: 543px;" id="tabla">
        <tr>
                <td class="auto-style8">
                    Ejercicios:
                <td class="style1">
                    <asp:DropDownList ID="ddlEjercicios" runat="server" Height="16px" Width="270px" OnSelectedIndexChanged="ddlEjercicios_SelectedIndexChanged" AutoPostBack="True" >
</asp:DropDownList>
                </td>
            </tr>
        </table>
  
<br />
<br />
<hr />
    <br />


        <table style="width: 543px; height: 154px;" id="tablaEjercicio">
            <tr>
                <td class="auto-style6">
                    Nombre del Ejercicio: </td>
                <td class="auto-style7">
                    <asp:TextBox ID="tbNombre" runat="server" Width="270px" ReadOnly="True"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                   Descripcion: 
                </td>

                <td class="auto-style5">
                    <asp:TextBox ID="tbDescripcion" runat="server" Width="267px" ReadOnly="True" Columns="5" Height="83px" Rows="5" TextMode="MultiLine" style="margin-left: 2px" Font-Names="Arial"></asp:TextBox>

                </td>

            </tr>

             <tr>
                <td class="auto-style6">

                    Musculo a ejercitar:</td>

                <td class="auto-style7">

                    <asp:TextBox ID="tbMusculo" runat="server" Width="270px" ReadOnly="True"></asp:TextBox>

                </td>

            </tr>

            <tr>

                <td class="auto-style3"> 

                    &nbsp;</td>

            </tr>

             </table>


</asp:Content>
