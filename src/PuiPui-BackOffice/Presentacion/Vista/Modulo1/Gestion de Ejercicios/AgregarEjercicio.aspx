<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master" 
AutoEventWireup="true" CodeBehind="AgregarEjercicio.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Ejercicios.AgregarEjercicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        #TextArea1 {

        height: 104px;

        width: 268px;

    }

    #taDescripcion {
    }

        .auto-style1 {
            height: 14px;
        }

        .auto-style2 {
        width: 166px;
    }
    .auto-style3 {
        height: 14px;
        width: 166px;
    }

        .auto-style4 {
        width: 166px;
        height: 86px;
    }
    .auto-style5 {
        height: 86px;
    }
    .auto-style6 {
        width: 166px;
        height: 30px;
    }
    .auto-style7 {
        height: 30px;
    }

        </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">

    <h2>

        AGREGAR EJERCICIO

    </h2>

    <br />

    <asp:Label ID="lExito" runat="server" Text="El ejercicio se ha agregado correctamente." Visible="False"> </asp:Label>

    <br />

    <br />


        <table style="width: 543px; height: 154px;" id="tablaEjercicio">

            <tr>

                <td class="auto-style6">

                    Nombre del ejercicio: </td>

                <td class="auto-style7">

                   

                    <asp:TextBox ID="Nombre" runat="server" AutoPostBack="True" Width="270px"></asp:TextBox>

                   

                </td>

            </tr>

            <tr>

                <td class="auto-style4">

                   Descripcion: 

                </td>

                <td class="auto-style5">

                    &nbsp;<asp:TextBox ID="taDescripcion" runat="server" Height="83px" Width="269px" TextMode="MultiLine" Font-Names="Arial"></asp:TextBox>

                </td>

            </tr>

             <tr>

                <td class="auto-style6">

                    Musculo a ejercitar:</td>

                <td class="auto-style7">

                    <asp:DropDownList ID="ddlMusculo" runat="server" Height="16px" Width="275px" AutoPostBack="True">
                    </asp:DropDownList>
    
                </td>

            </tr>

            <tr>

                <td class="auto-style3">

                    </td>

                <td class="auto-style1"> 

                </td>

            </tr>

             <tr>

                <td class="auto-style2">

                    &nbsp;

                </td>

                <td class="style1"> 

                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;

                    <asp:Button ID="bAgregar" runat="server" Text="Agregar" OnClick="bAgregar_Click" />

                    </td>

            </tr>

        </table>


</asp:Content>