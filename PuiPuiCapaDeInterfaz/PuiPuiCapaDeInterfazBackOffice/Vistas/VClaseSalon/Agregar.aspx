<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VClaseSalon.Agregar" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div style="text-align:center;">
    <h1>CLASE - SALON - INSTRUCTOR</h1>
        
    </div>

    <div style="height:20px; text-align:left; font-family:Helvetica; font-size:16px;">
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False" ForeColor="#ffffff"></asp:Label>
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
    </div>

    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center;"><h2>Asignación de Clase - Salón - Instructor</h2></legend>
               
            
               
            <table style="margin:20px auto auto 30%; height: 140px; width: 288px;" border="0" cellspacing="0" cellpadding="0" >
            <tr>
                <td class="auto-style5" align="left">
                    <h3>Nombre de la Clase:</h3>              
                     
                </td>
                <td class="auto-style6" align="left">
                    <asp:DropDownList ID="ComboClase" runat="server" Height="18px" Width="120px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" align="left">
                    <h3>Ubicación del Salón:</h3>
                                        
                </td>
                <td class="auto-style6" colspan="0" align="left">
                    <asp:DropDownList ID="ComboSalon" runat="server" Height="18px" Width="120px">
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td class="auto-style5" align="left">
                    <h3>Instructor:</h3>            
                    
                    </td>
                <td class="auto-style6" colspan="0" align="left">
                    <asp:DropDownList ID="ComboInstructor" runat="server" Height="18px" Width="120px">
                    </asp:DropDownList>
                    </td>
            </tr>

            <tr>
                <td class="auto-style9">
                    </td>
                <td class="auto-style10">
                    </td>
            </tr>

            <tr>
                <td class="auto-style1">
                
                    Horario:</td>
                <td class="auto-style2">
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:TextBox ID="TextHorario" runat="server" Enabled="false" ></asp:TextBox>
                    <asp:CalendarExtender ID="TextHorario_CalendarExtender" runat="server" TargetControlID="TextHorario">
                    </asp:CalendarExtender>
                </td>
            </tr>

            <tr >
                <td>
                
                <asp:Button ID="Cancelar" runat="server" Text="Cancelar" Height="25px" Width="120px" Font-Names="Tomoha Plain" Font-Size="14px" OnClick="Cancelar_Click"/>
                </td>
                <td>
                    <asp:Button ID="defaultButton" runat="server" Text="Aceptar" CssClass="button" OnClick="defaultButton_Click" Font-Names="tomoha plain" Font-Size="14px" Height="25px" Width="120px" />
                </td>
            </tr>
            </table>          
        </fieldset>
    </div>
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 216px;
        }
        .auto-style2 {
            width: 164px;
        }
        .auto-style5 {
            width: 216px;
            height: 26px;
        }
        .auto-style6 {
            width: 164px;
            height: 26px;
        }
        #TextArea1 {
            height: 71px;
        }
        .auto-style9 {
            width: 216px;
            height: 18px;
        }
        .auto-style10 {
            width: 164px;
            height: 18px;
        }
        </style>
</asp:Content>


