<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
 AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo2.Geestion_de_Salones.Consultar" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <div style="text-align:center; font-family:Helvetica; font-size:16px;">
    <asp:Label ID="Label1" runat="server" Text="Salón"></asp:Label>
    </div>

    <div style="height:30px; text-align:left; font-family:Helvetica; font-size:14px;">
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False"></asp:Label>
    </div>

    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center; font-family:Helvetica; font-size:14px;">Consultar Salón</legend>
               
            <table border="0" cellspacing="0" cellpadding="0" style="width: 596px; margin-left:100px" align="center">
            <tr>
                <td rowspan="0" nowrap="nowrap" class="auto-style3" style="text-align:center">
                    Buscar por:</td>
              
                <td align="left" rowspan="1" nowrap="nowrap" class="auto-style4">
                     <asp:RadioButton ID="consultaCompleta" runat="server" 
                        GroupName="ConsultarSalon" Text="Todos los parámetros" OnCheckedChanged="consultaCompleta_CheckedChanged1" /> 
                </td>              
                <td class="auto-style10">&nbsp;</td>              
                <td class="auto-style7">&nbsp;</td>
            </tr>
                <tr>
                <td></td>                
                <td class="auto-style9">
                    <asp:RadioButton ID="consultarSalonPorUbicacion" runat="server" 
                        GroupName="ConsultarSalon" Text="Ubicación:" OnCheckedChanged="consultarSalonPorUbicacion_CheckedChanged"/>
                    </td>  
                <td class="auto-style10">
                    <asp:TextBox ID="salon" runat="server" Height="22px" Width="172px"></asp:TextBox>
                    </td>  
                <td class="auto-style7">&nbsp;</td>  
            </tr>

            <tr>
                <td class="auto-style3"></td>
                
                <td align="left" rowspan="1" nowrap="nowrap" class="auto-style4" >
                     <asp:RadioButton ID="consultarSalonPorCapacidad" runat="server" 
                        GroupName="ConsultarSalon" Text="Capacidad:" OnCheckedChanged="consultaCapacidad_CheckedChanged1" />
                    </td>

                <td rowspan="0" nowrap="nowrap" class="auto-style11" >
                    <asp:DropDownList ID="DropDownListCapacidadSalon" runat="server" Width="100px" Height="22px" >
                        <asp:ListItem Value="0">Mayor a</asp:ListItem>
                        <asp:ListItem Value="1">Menor a</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="TextBoxCapacidad" runat="server" Height="22px" Width="69px"></asp:TextBox>
                </td>
                <td>
                    (cantidad de personas)</td>
            </tr>
            <tr>
                <td></td>                
                <td class="auto-style9">
                    <asp:RadioButton ID="consultaSalonPorStatus" runat="server" 
                        GroupName="ConsultarSalon" Text="Status:" OnCheckedChanged="consultaSalonPorStatus_CheckedChanged"/>
                       
                    
                    </td>  
                <td class="auto-style10">
                    <asp:DropDownList ID="DropDownListStatusSalon" runat="server" Width="100px">
                        <asp:ListItem Value="0">Activo</asp:ListItem>
                        <asp:ListItem Value="1">Inactivo</asp:ListItem>
                    </asp:DropDownList>


                </td>  
                <td class="auto-style7">&nbsp;</td>  
            </tr>
                 <tr>
                <td></td>                
                <td class="auto-style9">&nbsp;</td>  
                <td class="auto-style10">&nbsp;</td>  
                <td class="auto-style7"><asp:Button ID="Button1" runat="server" Height="25px" Width="120px" Text="Buscar" CssClass="button" OnClick="botonBuscarSalon_Click"/>
                </td>  
            </tr>
            </table>
            &nbsp;
            &nbsp;            
            
            <asp:GridView ID="GridConsultar" runat="server" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" align="center" Height="16px" Width="687px" 
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
        .auto-style3 {
            height: 31px;
        }
        .auto-style4 {
            width: 152px;
            height: 31px;
        }
        .auto-style7 {
            width: 140px;
        }
        .auto-style9 {
            width: 152px;
        }
        .auto-style10 {
            width: 187px;
        }
        .auto-style11 {
            height: 31px;
            width: 187px;
        }
    </style>
</asp:Content>
