<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="PuiPui_FrontOffice.Presentacion.Vista.Modulo5.Agregar" %>




<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    <style type="text/css">
        #Select1 {
            width: 162px;
        }
        .auto-style1 {
            text-align: left;
            width: 615px;
            height: 44px;
        }
        .auto-style21 {
            width: 245px;
            height: 3px;
            font-size: medium;
        }
        .auto-style22 {
            width: 258px;
            height: 3px;
            text-align: center;
        }
        .auto-style24 {
            width: 245px;
            height: 54px;
        }
        .auto-style25 {
            width: 258px;
            height: 54px;
        }
        .auto-style27 {
            width: 245px;
            height: 14px;
        }
        .auto-style28 {
            width: 258px;
            height: 14px;
        }
        .auto-style29 {
            width: 33px;
            height: 54px;
        }
        .auto-style30 {
            width: 33px;
            height: 3px;
        }
        .auto-style31 {
            width: 33px;
            height: 14px;
        }
        #TextArea1 {
            width: 339px;
        }
        .auto-style32 {
            width: 33px;
        }
        .auto-style33 {
            width: 245px;
        }
        .auto-style34 {
            width: 258px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <script language="javascript" type="text/javascript" src="../../../Scripts/ValidarText.js"></script>
    <script language="javascript" type="text/javascript" src="../../../Scripts/ActivarBoton.js" ></script> 


    <table style="width: 896px; height: 67px">
    <tr>
        <td class="auto-style1">
       
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
            GESTION DE RUTINAS</td>
            <tr>
            <td class="auto-style22">
                
                &nbsp;</td>
            </tr>
    
    </tr>
    
    <table style="width: 684px; height: 301px">
    <tr>
        <td class="auto-style32">
            Ejercicios:</td>
        <td class="auto-style33">
            <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="224px">
            </asp:DropDownList>
        </td>
        <td class="auto-style34">
            
            
            <asp:TextBox ID="ListaEjerText" runat="server" rows="10"  TextMode="MultiLine" ReadOnly="True" Width="260px"></asp:TextBox>
            
            &nbsp;Ejercicios De la Rutina</td>
        <td class="auto-style34">
            
            
            <asp:TextBox ID="TextBoxDescripcion" runat="server" rows="10"  TextMode="MultiLine" ReadOnly="false" Width="309px"></asp:TextBox>
            
            &nbsp;Descripcion de la rutina</td>


    </tr>
    
    <tr>
        <td class="auto-style30">
            Tiempo:</td>
        <td class="auto-style21">
            <asp:TextBox ID="TextBoxHora" runat="server" Height="16px" Width="31px"    onkeypress="CheckNumeric(event);" xmlns:asp="#unknown"></asp:TextBox>
&nbsp;:
            <asp:TextBox ID="TextBoxMin" runat="server" Height="17px" Width="33px"   onkeypress="CheckNumeric(event);"  xmlns:asp="#unknown"> </asp:TextBox>
&nbsp;:<asp:TextBox ID="TextBoxSeg" runat="server" Height="16px" Width="26px" onkeypress="CheckNumeric(event);" xmlns:asp="#unknown">  </asp:TextBox>
&nbsp;hh/mm/ss</td>
        <td class="auto-style22">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style31">
            Repeticiones:</td>
        <td class="auto-style27">
            
            <asp:Textbox ID="TextBoxRe" runat="server"  onkeypress="CheckNumeric(event);" 
             xmlns:asp="#unknown"></asp:Textbox>
        </td>
        <td class="auto-style28">
        </td>
    </tr>
   <tr>
        <td class="auto-style29">
            </td>
        <td class="auto-style24">
           
            &nbsp;</td>
        <td class="auto-style25">
            
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Enabled="true" />
           
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
        </td>
    </tr>



</table>
    

</asp:Content>
