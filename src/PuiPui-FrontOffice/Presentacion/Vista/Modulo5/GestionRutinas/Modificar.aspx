<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="PuiPui_FrontOffice.Presentacion.Vista.Modulo5.GestionRutinas.Modificar" %>
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

        .auto-style2 {
        width: 166px;
    }
    .auto-style3 {
        height: 42px;
        width: 170px;
    }

    .auto-style6 {
        width: 170px;
        height: 30px;
    }
    .auto-style7 {
        height: 174px;
            width: 384px;
        }
    .auto-style9 {
            height: 30px;
            width: 384px;
        }

        .auto-style10 {
            width: 170px;
        }

        .auto-style11
        {
            width: 384px;
        }
        .auto-style14
        {
            width: 170px;
            height: 174px;
        }
        .auto-style15
        {
            width: 166px;
            height: 45px;
        }
        .auto-style16
        {
            height: 45px;
            width: 281px;
        }
        .auto-style17
        {
            height: 42px;
            width: 384px;
        }

        .auto-style18
        {
            height: 27px;
            width: 170px;
        }
        .auto-style19
        {
            height: 27px;
            width: 384px;
        }

        </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">

    <h2>
        MODIFICAR Rutinas</h2>

    <br />

    <script language="javascript" type="text/javascript" src="../../../Scripts/ValidarText.js"></script>

    <asp:Label ID="lExito" runat="server" Text="El ejercicio se ha modificado correctamente." Visible="False"> </asp:Label>
    <br />
    <br />
    <table style="width: 543px;" id="tabla">
        <tr>
                <td class="auto-style2">
                    Rutinas:
                <td class="style1">
                     <asp:DropDownList ID="ddlRutinas" runat="server" Height="22px" Width="275px" OnSelectedIndexChanged="ddlRutinas_SelectedIndexChanged" AutoPostBack="True" >
    </asp:DropDownList>
                </td>
            </tr>
        </table>
 
    <br />
    <hr />

        <table style="width: 633px; height: 154px;" id="tablaEjercicio0">
            <tr>
                <td class="auto-style15">
                    Nombre del Rutina:
                    <asp:TextBox ID="tbNombre0" runat="server" AutoPostBack="True" Width="270px"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    Modificar el Nombre de la Rutina:
                    &nbsp;
                      <asp:TextBox ID="tbNombreNuevo" runat="server" AutoPostBack="True" Width="270px"></asp:TextBox>
                </td>
            </tr>

        </table>


    <br />

        <table style="width: 633px; height: 154px;" id="tablaEjercicio">
            <tr>
                <td class="auto-style18">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ejercicios Existentes</td>
                <td class="auto-style19">
                    Modificar los ejercicios
                    <asp:DropDownList ID="DDLTEjercicios" runat="server"  AutoPostBack="True" Width="270px" OnSelectedIndexChanged="DDLTEjercicios_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>

            </tr>

            <tr>

                <td class="auto-style14">

                    Ejercicios:<asp:TextBox ID="tbDescripcion0" runat="server" Height="83px" Width="270px" TextMode="MultiLine" Font-Names="Arial" style="margin-top: 17px"></asp:TextBox>
                &nbsp;</td>
                <td class="auto-style7">
                    Nuevos ejercicios&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tbDescripcion1" runat="server" Height="83px" Width="284px" TextMode="MultiLine" Font-Names="Arial" style="margin-top: 0px"></asp:TextBox>
                </td>
            </tr>

             <tr>

                <td class="auto-style6">
                    Tiempo<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="LTiempo" runat="server" Text="Label"></asp:Label>
                 </td>
                <td class="auto-style9">
                Tiempo de la Rutina
             <asp:TextBox ID="TextBoxHora" runat="server" Height="16px" Width="31px"    onkeypress="CheckNumeric(event);" xmlns:asp="#unknown"></asp:TextBox>
&nbsp;:
            <asp:TextBox ID="TextBoxMin" runat="server" Height="17px" Width="33px"   onkeypress="CheckNumeric(event);"  xmlns:asp="#unknown"> </asp:TextBox>
&nbsp;:<asp:TextBox ID="TextBoxSeg" runat="server" Height="16px" Width="26px" onkeypress="CheckNumeric(event);" xmlns:asp="#unknown">  </asp:TextBox>
                    hh/mm/ss
                    </td>

            </tr>

            <tr>

                <td class="auto-style3">

                    Repeticiones:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="LRepeticiones" runat="server" Text="Repeticiones"></asp:Label>
                </td>

                <td class="auto-style17"> 

                    Modificicacion de la repeticiones:&nbsp;
                    <asp:TextBox ID="TextBoxRe" runat="server" Height="16px" Width="85px" onkeypress="CheckNumeric(event);"></asp:TextBox>
                      
                </td>

            </tr>

             <tr>

                <td class="auto-style10">

                    &nbsp;

                    <asp:HiddenField ID="hfEjercicio" runat="server" />

                </td>

                <td class="auto-style11"> 

                     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;

                    <asp:Button ID="bModificar" runat="server" Text="Modificar" OnClick="bModificar_Click" />

                    </td>

            </tr>

        </table>


</asp:Content>
