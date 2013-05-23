<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Gestion_de_Clases.Consultar" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center; font-family:Helvetica; font-size:16px;">
    <asp:Label ID="Label1" runat="server" Text="CLASE"></asp:Label>
    </div>
    
    <div style="height:30px; text-align:center; font-family:Helvetica; font-size:14px;">
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False"></asp:Label>
    </div>
    
    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center; font-family:Helvetica; font-size:14px;">Consultar Clase</legend>
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
                        GroupName="ConsultarClases" Text="Nombre:" OnCheckedChanged="consultaClasePorNombres_CheckedChanged"  
                       />

                    </td>
              
                <td align="left" rowspan="1" nowrap="nowrap" class="auto-style2">
                    <asp:TextBox ID="nombreClase" runat="server" Width="111px"></asp:TextBox>

                    </td>
              
                <td rowspan="0" class="auto-style6" nowrap="nowrap">
                    <asp:RadioButton ID="consultaClasePorEstatus" runat="server" 
                        GroupName="ConsultarClases" Text="Estatus:" OnCheckedChanged="consultaClasePorEstatus_CheckedChanged1"/>
                       
                    
                    </td>
              
                <td rowspan="0" class="style47" nowrap="nowrap">
                   

                    <asp:DropDownList ID="DropDownListEstatusClase" runat="server" Width="87px" OnSelectedIndexChanged="DropDownListEstatusClase_SelectedIndexChanged">
                        <asp:ListItem Value="0">Activa</asp:ListItem>
                        <asp:ListItem Value="1">Inactiva</asp:ListItem>
                        
                    </asp:DropDownList>


                </td>
              
                <td rowspan="0" nowrap="nowrap" class="style48">
                <asp:Button ID="botonBuscarClase" runat="server" Text="Buscar" Width="120px" Height="25px" CssClass="button" OnClick="botonBuscarClase_Click" Font-Names="tomoha plain" Font-Size="14px"/>

                </td>
              
            </tr>
            </table> 
        
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
    </fieldset>
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



