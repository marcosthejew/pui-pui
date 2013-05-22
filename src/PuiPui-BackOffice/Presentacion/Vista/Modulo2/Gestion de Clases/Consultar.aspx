<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases.Consultar" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="superior">
    <h2 style="margin-left:350px">Consultar clases</h2>
    </div>
    
    <div style="margin-left:100px; margin-top:40px">
             <table border="0" cellspacing="0" cellpadding="0" style="width: 707px">
            <tr>
                <td rowspan="0" nowrap="nowrap" class="auto-style3">
                    Buscar por:</td>
                <td rowspan="0" class="auto-style6" nowrap="nowrap">
                     <asp:RadioButton ID="RadioButtonConsultaCompleta" runat="server" 
                        GroupName="ConsultarClases" Text="Todos" OnCheckedChanged="RadioButtonConsultaCompleta_CheckedChanged1" /> 
                              

                    </td>
                <td align="left" rowspan="0" class="auto-style5" nowrap="nowrap">
                    <asp:RadioButton ID="consultaClasePorNombres" runat="server" 
                        GroupName="ConsultarClases" Text="Nombre:"  
                       />

                    </td>
              
                <td align="left" rowspan="1" nowrap="nowrap" class="auto-style2">
                    <asp:TextBox ID="nombreClase" runat="server" Width="111px"></asp:TextBox>

                    </td>
              
                <td rowspan="0" class="auto-style6" nowrap="nowrap">
                    <asp:RadioButton ID="consultaClasePorEstatus" runat="server" 
                        GroupName="ConsultarClases" Text="Estatus:"/>
                       
                    
                    </td>
              
                <td rowspan="0" class="style47" nowrap="nowrap">
                   

                    <asp:DropDownList ID="DropDownListEstatusClase" runat="server" Width="87px">
                        <asp:ListItem Value="0">Activos</asp:ListItem>
                        <asp:ListItem Value="1">Inativos</asp:ListItem>
                    </asp:DropDownList>


                </td>
              
                <td rowspan="0" nowrap="nowrap" class="style48">
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
        .auto-style2 {
            width: 137px;
        }
        .auto-style3 {
            width: 86px;
        }
        .auto-style5 {
            width: 85px;
        }
        .auto-style6 {
            width: 72px;
        }
    </style>
    </asp:Content>



