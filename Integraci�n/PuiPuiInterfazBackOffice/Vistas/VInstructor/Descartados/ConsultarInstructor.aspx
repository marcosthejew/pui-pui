<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="ConsultarInstructor.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VInstructor.ConsultarInstructor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .auto-style13 {
            width: 165px;
        }
        .auto-style14 {
            height: 29px;
        }
        .auto-style15 {
            width: 165px;
            height: 29px;
        }
        .auto-style2 {
            width: 118px;
        }
        .auto-style6 {
            width: 319px;
        }
        .auto-style7 {
            width: 125px;
        }
        .auto-style22 {
            width: 165px;
            height: 22px;
        }
        .auto-style24 {
            height: 22px;
        }
        .auto-style25 {
            width: 166px;
        }
        .auto-style26 {
            width: 166px;
            height: 22px;
        }
        .auto-style27 {
            width: 166px;
            height: 29px;
        }
        .auto-style28 {
            width: 172px;
            height: 21px;
        }
        .auto-style29 {
            height: 21px;
        }
        .auto-style30 {
            width: 166px;
            height: 21px;
        }
        .auto-style31 {
            width: 172px;
        }
        .auto-style32 {
            width: 172px;
            height: 22px;
        }
        .auto-style33 {
            width: 172px;
            height: 29px;
        }
        .auto-style34 {
            width: 65px;
        }
        .auto-style35 {
            width: 147px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        CONSULTAR INSTRUCTOR
    </h2>
    <p>
    <asp:Label ID="lExito" runat="server" Text="No hay instructores." Visible="False" Font-Bold="False" ForeColor="Red"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;
        INSTRUCTOR:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="ddlInstructores" runat="server" Height="21px" Width="233px" AutoPostBack="True" OnSelectedIndexChanged="ddlInstructores_SelectedIndexChanged" >
</asp:DropDownList>
    </p>
    <h3>Datos Personales:
    </h3>
    <hr />
    <table style="width: 899px">
        <tr>
            <td class="auto-style31">Cedula: 
                </td>
            <td class="auto-style13">
                <asp:Label ID="lbCedula" runat="server"  Text="Label"></asp:Label>
            </td>
            <td class="auto-style25">Genero: 
                 </td>
           <td class="style1"><asp:Label ID="lbGenero" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style32">Primer Nombre: 
                </td>
            <td class="auto-style22">
                <asp:Label ID="lbNombre1" runat="server"  Text="Label"></asp:Label>
            </td>
            <td class="auto-style26">Segundo Nombre: 
                 </td>
            <td class="auto-style24">
                <asp:Label ID="lbNombre2" runat="server" Text="Label"></asp:Label>
            </td>

            
        </tr>
        <tr>
            <td class="auto-style31">Primer Apellido: 
                </td>
          <h4>  <td class="auto-style13">
                <asp:Label ID="lbApellido1" runat="server"  Text="Label"></asp:Label>
            </td></h4>
            <td class="auto-style25">Segundo Apellido: 
                 </td>
           <h4> <td class="style1">
                <asp:Label ID="lbApellido2" runat="server"  Text="Label"></asp:Label>
            </td></h4>
        </tr>
        <tr>
            <td class="auto-style33">Telefono Local:
                </td>
          <h4>  <td class="auto-style15">
                <asp:Label ID="lbTlfLocal" runat="server" Text="Label"></asp:Label>
            </td></h4>
            <td class="auto-style27">Telefono Celular: 
                 </td>
           <h4> <td class="auto-style14">
                <asp:Label ID="lbTlfCel" runat="server" BText="Label"></asp:Label>
            </td></h4>
        </tr>
        <tr>
            <td class="auto-style31">Ciudad:
               </td>
           <h4> <td class="auto-style13">
                <asp:Label ID="lbCiudad" runat="server" Text="Label"></asp:Label>
            </td></h4>
            <td class="auto-style25">Direccion:
                 </td>
           <h4> <td class="style1">
                <asp:Label ID="lbDireccion" runat="server"  Text="Label"></asp:Label>
            </td></h4>
        </tr>
        <tr>
            <td class="auto-style31">Fecha nacimiento:
                </td>
            <h4><td class="auto-style13">
                <asp:Label ID="lbFechaNac" runat="server"  Text="Label"></asp:Label>
            </td></h4>
            <td class="auto-style25">E-mail:
                 </td>
           <h4> <td class="style1">
                <asp:Label ID="lbMail" runat="server"  Text="Label"></asp:Label>
            </td></h4>
        </tr>
        <tr>
            <td class="auto-style28">Fecha de Registro:
                </td>
           <h4> <td class="auto-style29">
                <asp:Label ID="lbFechaRes" runat="server"  Text="Label"></asp:Label>
            </td></h4>
             <td class="auto-style30">Estatus:
                 </td>
           <h4> <td class="auto-style29">
                <asp:Label ID="lbStatus" runat="server" B Text="Label"></asp:Label>
            </td></h4>
        </tr>

    </table>
    <br />
    <h2>Datos de Emergencia:
         </h2>
    <hr />
    <table style="width: 899px">
        <tr>
            <td class="auto-style2">Persona Contacto:
                </td>
           <h4> <td class="auto-style6">
                <asp:Label ID="lbNomContacto" runat="server"  Text="Label"></asp:Label>
            </td></h4>
            <td class="auto-style34">Telefono:
                 </td>
           <h4> <td class="style1">
                 <asp:Label ID="lbTLfContacto" runat="server"  Text="Label"></asp:Label>
            </td></h4>
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
                    
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
               <td class="auto-style35">
                    
                    &nbsp;</td>
          </tr>
          <tr>
                <td class="auto-style2">
                    &nbsp;&nbsp;</td>
                <td class="auto-style35">
                    &nbsp;<asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                 <td class="auto-style7">
                     <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="style1">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
           </tr> 
           <tr>
                  <td class="auto-style2">
                      <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
                  </td>
                </tr>
                 <tr>
                <td class="auto-style9">
                    &nbsp;&nbsp;</td>
                <td class="auto-style35">
                    &nbsp;<asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                <td class="auto-style11">
                    <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
                     </td>
                <td class="auto-style12">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
            <tr>
                  <td class="auto-style2">
                      <asp:Label ID="Label7" runat="server" Text="Label" Visible="False"></asp:Label>
                  </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;&nbsp;</td>
                <td class="auto-style35">
                    <asp:Label ID="Label8" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                <td class="auto-style7">
                    <asp:Label ID="Label9" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="style1">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr> 
                 <tr>
                  <td class="auto-style2">
                      <asp:Label ID="Label10" runat="server" Text="Label" Visible="False"></asp:Label>
                     </td>
                </tr>
                 <tr>
                <td class="auto-style2">
                    &nbsp;&nbsp;</td>
                <td class="auto-style35">
                    &nbsp;<asp:Label ID="Label11" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                <td class="auto-style7">
                    <asp:Label ID="Label12" runat="server" Text="Label" Visible="False"></asp:Label>
                     </td>
                <td class="style1">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>   
            <tr>
                  <td class="auto-style2">
                      <asp:Label ID="Label13" runat="server" Text="Label" Visible="False"></asp:Label>
                  </td>
            </tr>
                 <tr>
                <td class="auto-style2">
                    &nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style35">
                    <asp:Label ID="Label14" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                <td class="auto-style7">
                    <asp:Label ID="Label15" runat="server" Text="Label" Visible="False"></asp:Label>
                     </td>
                <td class="style1">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>    
        </table>
        <br />


    </asp:Content>