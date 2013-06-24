<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VClaseSalon.Consular" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center;">
    <h1>CLASE - SALON - INSTRUCTOR</h1>        
    </div>
        
    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
       <legend style="text-align:center;"><h2>Asignación de Clase - Salón - Instructor</h2></legend>
               
             <table border="0" cellspacing="0" cellpadding="0" style="width: 782px; margin-left:0px">
            <tr>
                <td rowspan="0" nowrap="nowrap" class="auto-style14" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;" >
                    Buscar por:</td>
                <td rowspan="0" class="auto-style21" nowrap="nowrap" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                     <asp:RadioButton ID="RadioButtonConsultaCompleta" runat="server" 
                        GroupName="ConsultarClases" Text="Clase:" OnCheckedChanged="RadioButtonConsultaCompleta_CheckedChanged1" /> 
                              

                     </td>
                <td rowspan="0" class="auto-style22" nowrap="nowrap" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:RadioButton ID="consultaClasePorNombres" runat="server" 
                        GroupName="ConsultarClases" Text="Salón:" OnCheckedChanged="consultaClasePorNombres_CheckedChanged"  
                       />

                    </td>
              
                <td rowspan="1" nowrap="nowrap" class="auto-style24" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:RadioButton ID="consultaClasePorInstructor" runat="server" 
                        GroupName="ConsultarClases" Text="Instructor:" OnCheckedChanged="consultaClasePorInstructor_CheckedChanged" />
                       
                    
                    </td>
              
                <td rowspan="0" class="auto-style23" nowrap="nowrap">
                   

                    <asp:TextBox ID="nombreClase" runat="server" Width="111px" style="margin-left: 0px" ></asp:TextBox>


                    </td>
              
                <td rowspan="0" class="auto-style19" nowrap="nowrap" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                   

                    <asp:RadioButton ID="consultaClasePorEstatus" runat="server" 
                        GroupName="ConsultarClases" Text="Status:" OnCheckedChanged="consultaClasePorEstatus_CheckedChanged1"/>
                       
                    
                    </td>
              
                <td rowspan="0" nowrap="nowrap" class="auto-style17" align="left">
                   

                    <asp:DropDownList ID="DropDownListEstatusClase" runat="server" Width="75px" OnSelectedIndexChanged="DropDownListEstatusClase_SelectedIndexChanged" Height="18px" style="margin-left: 0px">
                        <asp:ListItem Value="0">Activa</asp:ListItem>
                        <asp:ListItem Value="1">Inactiva</asp:ListItem>
                        
                    </asp:DropDownList>


                </td>
                <td class="auto-style3">


                <asp:Button ID="botonBuscarClase" runat="server" Text="Buscar" CssClass="button" OnClick="botonBuscarClase_Click" Font-Names="tahoma plain" Font-Size="14px" Height="25px" Width="120px"/>


                </td>
              
            </tr>

            </table> 
           </br>
           
     
          
                        <asp:GridView ID="GridConsultar" runat="server" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" Height="16px" Width="687px" 
                        OnRowCommand="GridConsultar_RowCommand" AllowPaging="True" 
                        OnPageIndexChanging="GridConsultar_PageIndexChanging" 
                        OnSelectedIndexChanged="GridConsultar_SelectedIndexChanged" HorizontalAlign="Center" style="margin-right: 0px">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" HorizontalAlign="Center" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerSettings PageButtonCount="4" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
                         <Columns>                         
                         <asp:ButtonField HeaderText ="Ver Detalle" CommandName="Consultar" 
                             ButtonType="image" ImageUrl="~/Imagenes/Buscar.png"  />                         
                             <asp:BoundField />
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
        .auto-style3 {
            width: 86px;
        }
        .button {
            margin-left: 0px;
        }
        .auto-style14 {
            width: 64px;
        }
        .auto-style17 {
            width: 76px;
        }
        .auto-style19 {
            width: 65px;
        }
        .auto-style21 {
            width: 53px;
        }
        .auto-style22 {
            width: 54px;
        }
        .auto-style23 {
            width: 89px;
        }
        .auto-style24 {
            width: 92px;
        }
        </style>
    </asp:Content>