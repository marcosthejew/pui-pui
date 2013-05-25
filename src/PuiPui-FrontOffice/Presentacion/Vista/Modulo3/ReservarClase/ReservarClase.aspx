<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" AutoEventWireup="true" 
    CodeBehind="ReservarClase.aspx.cs" Inherits="PuiPui_FrontOffice.Presentacion.Vista.Modulo3.ReservarClase.ReservarClase" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 <link rel='stylesheet' type='text/css' href='http://arshaw.com/js/fullcalendar/fullcalendar.css' />
  <link href="../../../../Scripts/fullcalendar/fullcalendar.css" rel="stylesheet" type="text/css" />
 <script src="../../../../Scripts/jquery/jquery-1.9.1.min.js" type="text/javascript"></script>
 <script src="../../../../Scripts/jquery/jquery-ui-1.10.2.custom.min.js" type="text/javascript"></script>
 <script src="../../../../Scripts/fullcalendar/fullcalendar.min.js" type="text/javascript"></script>
 <script src="../../../../Scripts/gym2.js" type="text/javascript"></script>
    
 <div>
     <br /><br /><br /><br /><br />
        <table>
              <tr>
                 <td>
                    <table>
                          <tr>    
                              <td>Clase</td>
                         </tr>    
                         <tr>
                            <td class="auto-style2">
                                <asp:DropDownList ID="ddlClasesDisponibles" runat="server"  AutoPostBack="True" Height="21px" Width="184px" 
                                    onselectedindexchanged="ddlClasesDisponibles_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                         </tr>
                         <tr>    
                              <td>Horario</td>
                         </tr>    
                         <tr>
                            <td class="auto-style2">
                                <asp:DropDownList ID="ddlHorariosReservaDisponibles" runat="server"  AutoPostBack="True" Height="21px" Width="184px" 
                                    onselectedindexchanged="ddlHorariosReservaDisponibles_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                         </tr>
                         <tr>    
                              <td class="auto-style6">Instructor</td>
                         </tr>    
                         <tr>
                            <td class="auto-style2">
                                <asp:DropDownList ID="ddlInstructoresDisponibles" runat="server" AutoPostBack="True" Height="18px" Width="182px" 
                                    Enabled="false" onselectedindexchanged="ddlInstructor_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                         </tr> 
                        <tr>
                            <td colspan="4" align="center">
                                <asp:Button ID="BRegistrar" runat="server" CssClass="button" onclick="BtnReservarClase_Click" Text="Reservar" />
                            </td> 
                        </tr> 
                        </table>
              </td>
              <td style="position:absolute";><div id='calendar'></div></td>
              </tr>
     </table>
</div>
  
</asp:Content>
