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
    <br />
    <br />
    &nbsp;&nbsp; Ejercicios:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlEjercicios" runat="server" Height="18px" Width="163px" OnSelectedIndexChanged="ddlEjercicios_SelectedIndexChanged" AutoPostBack="True" >
    </asp:DropDownList>
    <br />
    <br />
    <hr />
    <br />
    <br />

        <table style="width: 543px; height: 239px;" id="tablaEjercicio">
            <tr>
                <td class="style2">
                    Nombre del ejercicio: </td>
                <td class="style1">
                    <asp:TextBox ID="tbNombre" runat="server" AutoPostBack="True" Width="259px"></asp:TextBox>
                </td>

            </tr>

            <tr>

                <td class="style2">

                   Descripcion: 
                </td>
                <td class="style1">
                    <asp:TextBox ID="tbDescripcion" runat="server" Height="62px" Width="256px" TextMode="MultiLine" Font-Names="Arial"></asp:TextBox>
                </td>
            </tr>

             <tr>

                <td class="style2">
                    Musculo a ejercitar:</td>
                <td class="style1">

                    <asp:DropDownList ID="ddlMusculo" runat="server" Height="17px" Width="259px" AutoPostBack="True">
                    </asp:DropDownList>
    
                </td>

            </tr>

            <tr>

                <td class="auto-style1">

                    </td>

                <td class="auto-style1"> 

                </td>

            </tr>

             <tr>

                <td class="style2">

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
