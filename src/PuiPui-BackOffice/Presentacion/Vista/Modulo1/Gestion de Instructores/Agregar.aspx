﻿<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
 AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo1.Gestion_de_Instructores.Agregar" %>

<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        AGREGAR INSTRUCTOR
    </h2>
    <br />
    <asp:Label ID="lexito" runat="server" Text="El instructor se ha agregado correctamente." Visible="False"></asp:Label>
    <br />
    <h3>
        Datos Personales:
    </h3>    
    <hr />
        <table style="width: 899px">
            <tr>
                <td class="style2">
                  Cedula: 
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="tb1" runat="server" Width="269px" Height="25px"></asp:TextBox>
                </td>
                 <td class="style2">
                   Genero: 
                 </td>
                <td class="style1">
                    <asp:CheckBox ID="cb1" runat="server" BorderColor="#0000CC" CausesValidation="True" OnCheckedChanged="cb1_CheckedChanged" Text="Masculino" />
&nbsp;&nbsp;
                    <asp:CheckBox ID="cb2" runat="server" BorderColor="#0000CC" OnCheckedChanged="cb1_CheckedChanged" Text="Femenino" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                   Primer Nombre: 
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="tb2" runat="server" Width="269px"></asp:TextBox>
                </td>
                 <td class="style2">
                   Segundo Nombre: 
                 </td>
                <td class="style1">
                    <asp:TextBox ID="tb6" runat="server" Width="269px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="style2">
                   Primer Apellido: 
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="tb3" runat="server" Width="269px"></asp:TextBox>
                </td>
                 <td class="style2">
                   Segundo Apellido: 
                 </td>
                <td class="style1">
                    <asp:TextBox ID="tb7" runat="server" Width="269px"></asp:TextBox>
                </td>
           </tr>
           <tr>
                <td class="auto-style14">
                   Telefono Local:
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="tb4" runat="server" Width="269px" OnTextChanged="tb4_TextChanged"></asp:TextBox>
                </td>
                 <td class="auto-style14">
                   Telefono Celular: 
                 </td>
                <td class="auto-style14">
                    <asp:TextBox ID="tb8" runat="server" Width="269px" OnTextChanged="tb8_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                  Ciudad:
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="tb5" runat="server" Width="269px"></asp:TextBox>
                </td>
                 <td class="style2">
                   Direccion:
                 </td>
                <td class="style1">
                    <asp:TextBox ID="tb9" runat="server" Width="269px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                  Fecha nacimiento:
                </td>
                <td class="auto-style13">
                    <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
                </td>
                 <td class="style2">
                   E-mail:
                 </td>
                <td class="style1">
                    <asp:TextBox ID="tb10" runat="server" Width="269px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <h3>
              Datos de Emergencia:
         </h3> 
        <hr />
        <table style="width: 899px">
            <tr>
                <td class="auto-style2">
                    Persona Contacto:
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="tb11" runat="server" Width="269px"></asp:TextBox>
                </td>
                 <td class="auto-style7">
                   Telefono:
                 </td>
                <td class="style1">
                    <asp:TextBox ID="tb12" runat="server" Width="269px" OnTextChanged="tb12_TextChanged"></asp:TextBox>
                </td>
            </tr>
        </table>
         <br />
        <h3>
             Horario:
         </h3> 
        <hr />
        <table style="width: 899px">
          <tr>
                <td class="auto-style8">
                    
                    Lunes</td>
               <td class="auto-style8">
                    
                    &nbsp;</td>
          </tr>
          <tr>
                <td class="auto-style2">
                    &nbsp;&nbsp;<asp:CheckBox ID="CheckBox6" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox6_CheckedChanged" Text="Turno A" />
                </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="dp1" runat="server" Height="17px" Width="74px" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp2" runat="server" Height="17px" Width="74px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList11_SelectedIndexChanged">
                        
                    </asp:DropDownList>
                </td>
                 <td class="auto-style7">
                   &nbsp;<asp:CheckBox ID="CheckBox7" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox7_CheckedChanged" Text="Turno B" />
                 </td>
                <td class="style1">
                    <asp:DropDownList ID="dp3" runat="server" Height="17px" Width="74px" AutoPostBack="True" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp4" runat="server" Height="17px" Width="74px" AutoPostBack="True">
                        
                    </asp:DropDownList>
                 </td>
           </tr> 
           <tr>
                  <td class="auto-style2">
                      Martes</td>
                </tr>
                 <tr>
                <td class="auto-style9">
                    &nbsp;&nbsp;<asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Turno A" />
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="dp5" runat="server" Height="17px" Width="74px" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp6" runat="server" Height="17px" Width="74px" OnSelectedIndexChanged="dp6_SelectedIndexChanged" AutoPostBack="True">
                       
                    </asp:DropDownList>
                </td>
                <td class="auto-style11">
                    <asp:CheckBox ID="CheckBox8" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox8_CheckedChanged" Text="Turno B" />
                 </td>
                <td class="auto-style12">
                    <asp:DropDownList ID="dp7" runat="server" Height="17px" Width="74px" AutoPostBack="True" OnSelectedIndexChanged="dp7_SelectedIndexChanged" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp8" runat="server" Height="17px" Width="74px" AutoPostBack="True">
                        
                    </asp:DropDownList> 
                </td>
            </tr>
            <tr>
                  <td class="auto-style2">
                      Miercoles</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;&nbsp;<asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Turno A" />
                </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="dp9" runat="server" Height="17px" Width="74px" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp10" runat="server" Height="17px" Width="74px" OnSelectedIndexChanged="dp10_SelectedIndexChanged" AutoPostBack="True">
                       
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">
                    <asp:CheckBox ID="CheckBox9" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox9_CheckedChanged" Text="Turno B" />
                 </td>
                <td class="style1">
                    <asp:DropDownList ID="dp11" runat="server" Height="17px" Width="74px" AutoPostBack="True" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp12" runat="server" Height="17px" Width="74px" OnSelectedIndexChanged="DropDownList12_SelectedIndexChanged" AutoPostBack="True">
                        
                    </asp:DropDownList> 
                </td>
            </tr> 
                 <tr>
                  <td class="auto-style2">
                      Jueves</td>
                </tr>
                 <tr>
                <td class="auto-style2">
                    &nbsp;&nbsp;<asp:CheckBox ID="CheckBox4" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox4_CheckedChanged" Text="Turno A" />
                </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="dp13" runat="server" Height="17px" Width="74px" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp14" runat="server" Height="17px" Width="74px" OnSelectedIndexChanged="dp14_SelectedIndexChanged" AutoPostBack="True">
                        
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">
                    <asp:CheckBox ID="CheckBox10" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox10_CheckedChanged" Text="Turno B" />
                 </td>
                <td class="style1">
                    <asp:DropDownList ID="dp15" runat="server" Height="17px" Width="74px" AutoPostBack="True" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp16" runat="server" Height="17px" Width="74px" AutoPostBack="True">
                        
                    </asp:DropDownList>
                </td>
            </tr>   
            <tr>
                  <td class="auto-style2">
                      Viernes</td>
            </tr>
                 <tr>
                <td class="auto-style2">
                    &nbsp;&nbsp;<asp:CheckBox ID="CheckBox5" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox5_CheckedChanged" Text="Turno A" />
                    &nbsp;</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="dp17" runat="server" Height="17px" Width="74px" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp18" runat="server" Height="17px" Width="74px" OnSelectedIndexChanged="dp18_SelectedIndexChanged" AutoPostBack="True">
                        
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">
                    <asp:CheckBox ID="CheckBox11" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox11_CheckedChanged" Text="Turno B" />
                 </td>
                <td class="style1">
                    <asp:DropDownList ID="dp19" runat="server" Height="17px" Width="74px" OnSelectedIndexChanged="DropDownList19_SelectedIndexChanged" AutoPostBack="True" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp20" runat="server" Height="17px" Width="74px" AutoPostBack="True">
                       
                    </asp:DropDownList>
                </td>
            </tr>    
        </table>
        <br />
<hr />
        <br />
         &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
         &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
         &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;  
        <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />

        <br />

</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style2 {
            width: 118px;
        }
        .auto-style6 {
            width: 319px;
        }
        .auto-style7 {
            width: 125px;
        }
        .auto-style8 {
            width: 118px;
            height: 24px;
        }
        .auto-style9 {
            width: 118px;
            height: 26px;
        }
        .auto-style10 {
            width: 319px;
            height: 26px;
        }
        .auto-style11 {
            width: 125px;
            height: 26px;
        }
        .auto-style12 {
            height: 26px;
        }
        .auto-style13 {
            width: 277px;
        }
        .auto-style14 {
            height: 29px;
        }
        .auto-style15 {
            width: 277px;
            height: 29px;
        }
    </style>
</asp:Content>


