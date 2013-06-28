<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="ModificarInstructor.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VInstructor.ModificarInstructor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
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
            width: 83px;
            height: 24px;
        }
        .auto-style9 {
            width: 83px;
            height: 26px;
        }
        .auto-style10 {
            width: 183px;
            height: 26px;
        }
        .auto-style13 {
            width: 277px;
            margin-left: 80px;
        }
        .auto-style14 {
            height: 29px;
        }
        .auto-style15 {
            width: 277px;
            height: 29px;
        }
        .auto-style18 {
            width: 183px;
            height: 24px;
        }
        .auto-style19 {
            width: 183px;
        }
        .auto-style20 {
            width: 83px;
        }
        .auto-style21 {
            width: 72px;
        }
        .auto-style22 {
            width: 72px;
            height: 26px;
        }
        .auto-style23 {
            width: 190px;
        }
        .auto-style24 {
            width: 190px;
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        MODIFICAR INSTRUCTOR
    </h2>
    <br />
    <asp:Label ID="lexito" runat="server" Text="El instructor se ha modificado correctamente." Visible="False"></asp:Label>
    <p>
        &nbsp;&nbsp;
        INSTRUCTOR:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlInstructores" runat="server" Height="26px" Width="260px" AutoPostBack="True" style="margin-left: 0px" OnSelectedIndexChanged="ddlInstructores_SelectedIndexChanged" >
</asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="CIinicio" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="estadoini" runat="server" Visible="False"></asp:Label>
    </p>
    <h3>
        Datos Personales:
    </h3>    
    <hr />
        <table style="width: 894px">
            <tr>
                <td class="style2">
                  Cedula: 
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="cedula" runat="server" Width="269px" Height="25px"></asp:TextBox>
                </td>
                 <td class="style2">
                   Genero: 
                 </td>
                <td class="style1">
                    &nbsp;&nbsp;
                    <asp:Label ID="genero" runat="server" ForeColor="Black"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="masculino" runat="server" BorderColor="#0000CC" CausesValidation="True" Text="Masculino" OnCheckedChanged="masculino_CheckedChanged" AutoPostBack="True" />
&nbsp;&nbsp;
                    <asp:CheckBox ID="femenino" runat="server" BorderColor="#0000CC" CausesValidation="True" Text="Femenino" OnCheckedChanged="femenino_CheckedChanged" AutoPostBack="True" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                   Primer Nombre: 
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="nombre1" runat="server" Width="269px"></asp:TextBox>
                </td>
                 <td class="style2">
                   Segundo Nombre: 
                 </td>
                <td class="style1">
                    <asp:TextBox ID="nombre2" runat="server" Width="269px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="style2">
                   Primer Apellido: 
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="apellido1" runat="server" Width="269px"></asp:TextBox>
                </td>
                 <td class="style2">
                   Segundo Apellido: 
                 </td>
                <td class="style1">
                    <asp:TextBox ID="apellido2" runat="server" Width="269px"></asp:TextBox>
                </td>
           </tr>
           <tr>
                <td class="auto-style14">
                   Telefono Local:
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="tlflocal" runat="server" Width="269px"></asp:TextBox>
                </td>
                 <td class="auto-style14">
                   Telefono Celular: 
                 </td>
                <td class="auto-style14">
                    <asp:TextBox ID="tlfcel" runat="server" Width="269px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                  Ciudad:
                </td>
                <td class="auto-style13">
                    <asp:TextBox ID="ciudad" runat="server" Width="269px"></asp:TextBox>
                </td>
                 <td class="style2">
                   Direccion:
                 </td>
                <td class="style1">
                    <asp:TextBox ID="direccion" runat="server" Width="269px"></asp:TextBox>
                </td>
            </tr>
            <tr>
              <td class="style2">
                  Fecha nacimiento:
                </td>                
                <td>
                    <asp:Label ID="fechanac" runat="server" ForeColor="Black"></asp:Label>
                </td>
                <td class="style2">
                   E-mail:
                 </td>
                <td class="style1">
                    <asp:TextBox ID="mail" runat="server" Width="269px"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td class="style2">
                  Fecha nacimiento:
                </td>
                <td class="auto-style13">
                    <asp:Calendar ID="Calendar" runat="server" OnSelectionChanged="Calendar_SelectionChanged"></asp:Calendar>
                </td>
                <td>

                    Estatus:

                </td>
                 <td>

                     <asp:Label ID="estado" runat="server" ForeColor="Black"></asp:Label>
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:CheckBox ID="activar" runat="server" AutoPostBack="True" OnCheckedChanged="activar_CheckedChanged" Text="Activar" />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="inactivar" runat="server" OnCheckedChanged="inactivar_CheckedChanged" Text="Volver a Inactivar" AutoPostBack="True" />
                     &nbsp;

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
                    <asp:TextBox ID="contacto" runat="server" Width="269px"></asp:TextBox>
                </td>
                 <td class="auto-style7">
                   Telefono:
                 </td>
                <td class="style1">
                    <asp:TextBox ID="tlfcontacto" runat="server" Width="269px"></asp:TextBox>
                </td>
            </tr>
        </table>
         <br />
        <h3>
             Horario:
         </h3> 
        <hr />
        <table style="width: 918px">
          <tr>
                <td class="auto-style8">
                    
                    Lunes</td>
               <td class="auto-style18">
                    
                    <asp:Label ID="lunes1" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lunes2" runat="server"></asp:Label>
                </td>
              <td class="auto-style21"></td>   <td class="auto-style23">
                <asp:Label ID="lunes3" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lunes4" runat="server"></asp:Label>
                </td>
          </tr>
          <tr>
                <td class="auto-style20">
                    &nbsp;&nbsp;<asp:CheckBox ID="cb6" runat="server" AutoPostBack="True" Text="Turno A" OnCheckedChanged="cb6_CheckedChanged" />
                </td>
                <td class="auto-style19">
                    <asp:DropDownList ID="dp1" runat="server" Height="17px" Width="74px" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp2" runat="server" Height="17px" Width="74px" AutoPostBack="True" OnSelectedIndexChanged="dp2_SelectedIndexChanged">
                        
                    </asp:DropDownList>
                </td>
                 <td class="auto-style21">
                   &nbsp;<asp:CheckBox ID="cb11" runat="server" AutoPostBack="True" Text="Turno B" OnCheckedChanged="cb11_CheckedChanged" />
                 </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="dp3" runat="server" Height="17px" Width="74px" AutoPostBack="True" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp4" runat="server" Height="17px" Width="74px" AutoPostBack="True">
                        
                    </asp:DropDownList>
                 </td>
           </tr> 
           <tr>
                  <td class="auto-style20">
                      Martes</td>
               <td class="auto-style19">
                   <asp:Label ID="martes1" runat="server"></asp:Label>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Label ID="martes2" runat="server"></asp:Label>
                  </td>
               <td class="auto-style21"></td>
               <td class="auto-style23">
                   <asp:Label ID="martes3" runat="server"></asp:Label>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Label ID="martes4" runat="server"></asp:Label>
                  </td>
                </tr>
                 <tr>
                <td class="auto-style9">
                    &nbsp;&nbsp;<asp:CheckBox ID="cb7" runat="server" AutoPostBack="True" Text="Turno A" OnCheckedChanged="cb7_CheckedChanged" />
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="dp5" runat="server" Height="17px" Width="74px" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp6" runat="server" Height="17px" Width="74px" AutoPostBack="True" OnSelectedIndexChanged="dp6_SelectedIndexChanged">
                       
                    </asp:DropDownList>
                </td>
                <td class="auto-style22">
                    <asp:CheckBox ID="cb12" runat="server" AutoPostBack="True" Text="Turno B" OnCheckedChanged="cb12_CheckedChanged" />
                 </td>
                <td class="auto-style24">
                    <asp:DropDownList ID="dp7" runat="server" Height="17px" Width="74px" AutoPostBack="True" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp8" runat="server" Height="17px" Width="74px" AutoPostBack="True">
                        
                    </asp:DropDownList> 
                </td>
            </tr>
            <tr>
                  <td class="auto-style20">
                      Miercoles</td>
                               <td class="auto-style19">
                                   <asp:Label ID="miercoles1" runat="server"></asp:Label>
                                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                   <asp:Label ID="miercoles2" runat="server"></asp:Label>
                  </td>
               <td class="auto-style21"></td>
               <td class="auto-style23">
                   <asp:Label ID="miercoles3" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Label ID="miercoles4" runat="server"></asp:Label>
                  </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    &nbsp;&nbsp;<asp:CheckBox ID="cb8" runat="server" AutoPostBack="True" Text="Turno A" OnCheckedChanged="cb8_CheckedChanged" />
                </td>
                <td class="auto-style19">
                    <asp:DropDownList ID="dp9" runat="server" Height="17px" Width="74px" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp10" runat="server" Height="17px" Width="74px" AutoPostBack="True" OnSelectedIndexChanged="dp10_SelectedIndexChanged">
                       
                    </asp:DropDownList>
                </td>
                <td class="auto-style21">
                    <asp:CheckBox ID="cb13" runat="server" AutoPostBack="True" Text="Turno B" OnCheckedChanged="cb13_CheckedChanged" />
                 </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="dp11" runat="server" Height="17px" Width="74px" AutoPostBack="True" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp12" runat="server" Height="17px" Width="74px" AutoPostBack="True">
                        
                    </asp:DropDownList> 
                </td>
            </tr> 
                 <tr>
                  <td class="auto-style20">
                      Jueves</td>
                                    <td class="auto-style19">
                                        <asp:Label ID="jueves1" runat="server"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Label ID="jueves2" runat="server"></asp:Label>
                     </td>
               <td class="auto-style21"></td><td class="auto-style23">
                     <asp:Label ID="jueves3" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="jueves4" runat="server"></asp:Label>
                     </td>
                </tr>
                 <tr>
                <td class="auto-style20">
                    &nbsp;&nbsp;<asp:CheckBox ID="cb9" runat="server" AutoPostBack="True" Text="Turno A" OnCheckedChanged="cb9_CheckedChanged" />
                </td>
                <td class="auto-style19">
                    <asp:DropDownList ID="dp13" runat="server" Height="17px" Width="74px" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp14" runat="server" Height="17px" Width="74px" AutoPostBack="True" OnSelectedIndexChanged="dp14_SelectedIndexChanged">
                        
                    </asp:DropDownList>
                </td>
                <td class="auto-style21">
                    <asp:CheckBox ID="cb14" runat="server" AutoPostBack="True" Text="Turno B" OnCheckedChanged="cb14_CheckedChanged" />
                 </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="dp15" runat="server" Height="17px" Width="74px" AutoPostBack="True" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp16" runat="server" Height="17px" Width="74px" AutoPostBack="True">
                        
                    </asp:DropDownList>
                </td>
            </tr>   
            <tr>
                  <td class="auto-style20">
                      Viernes</td>
                               <td class="auto-style19">
                                   <asp:Label ID="viernes1" runat="server"></asp:Label>
                                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                   <asp:Label ID="viernes2" runat="server"></asp:Label>
                  </td>
               <td class="auto-style21"></td><td class="auto-style23">
                  <asp:Label ID="viernes3" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Label ID="viernes4" runat="server"></asp:Label>
                  </td>
            </tr>
                 <tr>
                <td class="auto-style20">
                    &nbsp;&nbsp;<asp:CheckBox ID="cb10" runat="server" AutoPostBack="True" Text="Turno A" OnCheckedChanged="cb10_CheckedChanged" />
                    &nbsp;</td>
                <td class="auto-style19">
                    <asp:DropDownList ID="dp17" runat="server" Height="17px" Width="74px" >
                        
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="dp18" runat="server" Height="17px" Width="74px" AutoPostBack="True" OnSelectedIndexChanged="dp18_SelectedIndexChanged">
                        
                    </asp:DropDownList>
                </td>
                <td class="auto-style21">
                    <asp:CheckBox ID="cb15" runat="server" AutoPostBack="True" Text="Turno B" OnCheckedChanged="cb15_CheckedChanged" />
                 </td>
                <td class="auto-style23">
                    <asp:DropDownList ID="dp19" runat="server" Height="17px" Width="74px">
                        
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
        <asp:Button ID="Button1" runat="server" Text="Modificar" OnClick="Button1_Click"/>

        <br />

</asp:Content>