<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" AutoEventWireup="true" 
    CodeBehind="ConsultarClasesSalon.aspx.cs" 
    Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_Clase_Salon_Instructor.ConsultarClasesSalon" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="superior">
    <h2 style="margin-left:350px">Consultar clases con Salon</h2>
    </div>
    
    <div style="margin-left:100px; margin-top:40px">
             <table border="0" cellspacing="0" cellpadding="0" style="width: 707px">
            <tr>
                <td rowspan="0" nowrap="nowrap" class="auto-style3">
                    Buscar por:</td>
                <td rowspan="0" class="auto-style6" nowrap="nowrap">
                     <asp:RadioButton ID="RadioButtonConsultaCompleta" runat="server" 
                        GroupName="ConsultarClases" Text="Clase" OnCheckedChanged="RadioButtonConsultaCompleta_CheckedChanged1" /> 
                              

                    </td>
                <td align="left" rowspan="0" class="auto-style10" nowrap="nowrap">
                    <asp:RadioButton ID="consultaClasePorNombres" runat="server" 
                        GroupName="ConsultarClases" Text="Salon:" OnCheckedChanged="consultaClasePorNombres_CheckedChanged"  
                       />

                    </td>
              
                <td align="left" rowspan="1" nowrap="nowrap" class="auto-style11">
                    <asp:RadioButton ID="consultaClasePorInstructor" runat="server" 
                        GroupName="ConsultarClases" Text="Instructor:" OnCheckedChanged="consultaClasePorInstructor_CheckedChanged" />
                       
                    
                    </td>
              
                <td rowspan="0" class="auto-style12" nowrap="nowrap">
                   

                    <asp:RadioButton ID="consultaClasePorEstatus" runat="server" 
                        GroupName="ConsultarClases" Text="Estatus:" OnCheckedChanged="consultaClasePorEstatus_CheckedChanged1"/>
                       
                    
                    </td>
              
                <td rowspan="0" nowrap="nowrap">
                   

                    <asp:DropDownList ID="DropDownListEstatusClase" runat="server" Width="75px" OnSelectedIndexChanged="DropDownListEstatusClase_SelectedIndexChanged" Height="18px" style="margin-left: 0px">
                        <asp:ListItem Value="0">Activa</asp:ListItem>
                        <asp:ListItem Value="1">Inactiva</asp:ListItem>
                        
                    </asp:DropDownList>


                    </td>
              
                <td rowspan="0" nowrap="nowrap" class="auto-style8">
                   

                    <asp:TextBox ID="nombreClase" runat="server" Width="111px"></asp:TextBox>


                </td>
                <td class="auto-style3">


                <asp:Button ID="botonBuscarClase" runat="server" Text="Buscar" CssClass="button" OnClick="botonBuscarClase_Click"/>


                </td>
              
            </tr>
            </table> 
     </div>
          
        <div style="margin-top:60px">
                        <asp:GridView ID="GridConsultar" runat="server" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" Height="16px" Width="687px" 
                        OnRowCommand="GridConsultar_RowCommand" AllowPaging="True" PageSize="10" 
                        OnPageIndexChanging="GridConsultar_PageIndexChanging" 
                        OnSelectedIndexChanged="GridConsultar_SelectedIndexChanged" HorizontalAlign="Center">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" HorizontalAlign="Center" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerSettings PageButtonCount="4" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
                         <Columns>                         
                         <asp:ButtonField HeaderText ="Ver Detalle" CommandName="Consultar" 
                             ButtonType="image" ImageUrl="~/Presentacion/Imagenes/Buscar.png"  />                         
                        </Columns>
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" HorizontalAlign="Center" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" HorizontalAlign="Center" />
                    </asp:GridView>      

    </div>
  
</asp:Content>


<asp:Content ID="Content3" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style3 {
            width: 86px;
        }
        .auto-style6 {
            width: 65px;
        }
        .auto-style8 {
            width: 125px;
        }
        .auto-style10 {
            width: 68px;
        }
        .auto-style11 {
            width: 92px;
        }
        .auto-style12 {
            width: 80px;
        }
        </style>
    </asp:Content>



