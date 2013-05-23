<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Ejercicios.Modificar" %>
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

        .auto-style1 {
            height: 14px;
        }

        .auto-style2 {
        width: 166px;
    }
    .auto-style3 {
        height: 14px;
        width: 170px;
    }

    .auto-style6 {
        width: 166px;
        height: 30px;
    }
    .auto-style7 {
        height: 86px;
    }
    .auto-style8 {
            width: 170px;
            height: 30px;
        }
    .auto-style9 {
        height: 30px;
    }

        .auto-style10 {
            width: 170px;
        }

        </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">

    <h2>
        MODIFICAR EJERCICIO
    </h2>

    <br />

    <asp:Label ID="lExito" runat="server" Text="El ejercicio se ha modificado correctamente." Visible="False"> </asp:Label>
    <br />
    <br />
    <table style="width: 543px;" id="tabla">
        <tr>
                <td class="auto-style2">
                    Ejercicios:
                <td class="style1">
                     <asp:DropDownList ID="ddlEjercicios" runat="server" Height="22px" Width="275px" OnSelectedIndexChanged="ddlEjercicios_SelectedIndexChanged" AutoPostBack="True" >
    </asp:DropDownList>
                </td>
            </tr>
        </table>
 
    <br />
    <hr />
    <br />

        <table style="width: 543px; height: 154px;" id="tablaEjercicio">
            <tr>
                <td class="auto-style6">
                    Nombre del ejercicio: </td>
                <td class="auto-style9">
                    <asp:TextBox ID="tbNombre" runat="server" AutoPostBack="True" Width="270px"></asp:TextBox>
                </td>

            </tr>

            <tr>

                <td class="auto-style6">

                   Descripcion: 
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="tbDescripcion" runat="server" Height="83px" Width="270px" TextMode="MultiLine" Font-Names="Arial"></asp:TextBox>
                </td>
            </tr>

             <tr>

                <td class="auto-style6">
                    Musculo a ejercitar:</td>
                <td class="auto-style9">

                    <asp:DropDownList ID="ddlMusculo" runat="server" Height="17px" Width="275px" AutoPostBack="True">
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

                <td class="auto-style10">

                    &nbsp;

                    <asp:HiddenField ID="hfEjercicio" runat="server" />

                </td>

                <td class="style1"> 

                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;

                    <asp:Button ID="bModificar" runat="server" Text="Modificar" OnClick="bModificar_Click" />

                    </td>

            </tr>

        </table>


</asp:Content>
