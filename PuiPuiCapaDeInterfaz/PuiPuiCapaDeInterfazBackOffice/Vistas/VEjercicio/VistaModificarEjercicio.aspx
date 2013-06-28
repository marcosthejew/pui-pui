<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="VistaModificarEjercicio.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VEjercicio.VistaModificarEjercicio" %>
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
