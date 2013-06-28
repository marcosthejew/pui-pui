<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="ConsultarSalon.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VSalon.ConsultarSalon" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
     <div style="text-align:center;">
    <h1>SALON</h1>
    </div>

    <div style="height:30px; text-align:left; font-family:Helvetica; font-size:14px;">
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False" ForeColor="#ffffff"></asp:Label>
    </div>

    <div  style="float:left; width: 874px;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
       <legend style="text-align:center;"><h2>Agregar Salón</h2></legend>
               
            <table border="0" cellspacing="0" cellpadding="0" style="width: 654px; margin-left:86px; height: 177px;" >
            <tr>
                <td rowspan="0" nowrap="nowrap" class="auto-style3" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    Buscar por:</td>
              
                <td rowspan="1" nowrap="nowrap" class="auto-style12" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                     <asp:RadioButton ID="consultaCompleta" runat="server" 
                        GroupName="ConsultarSalon" Text="Todos los parámetros" /> 
                </td>              
                <td class="auto-style18">&nbsp;</td>              
                <td class="auto-style7">&nbsp;</td>
            </tr>
                <tr>
                <td class="auto-style14"></td>                
                <td class="auto-style15" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:RadioButton ID="consultarSalonPorUbicacion" runat="server" 
                        GroupName="ConsultarSalon" Text="Ubicación:" />
                    </td>  
                <td class="auto-style19">
                    <asp:TextBox ID="salon" runat="server" Height="22px" Width="172px" ValidationGroup="check"></asp:TextBox>
                    </td>  
                <td class="auto-style17">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="salon" runat="server" ErrorMessage="No se aceptan numero ni caracteres especiales" ForeColor="Red" ValidationGroup="check" ValidationExpression="^[a-zA-Z''-'''.'\s]{1,45}$" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>  
            </tr>

            <tr>
                <td class="auto-style3"></td>
                
                <td rowspan="1" nowrap="nowrap" class="auto-style12" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;" >
                     <asp:RadioButton ID="consultarSalonPorCapacidad" runat="server" 
                        GroupName="ConsultarSalon" Text="Capacidad:" />
                    </td>

                <td rowspan="0" nowrap="nowrap" class="auto-style20" >
                    <asp:DropDownList ID="DropDownListCapacidadSalon" runat="server" Width="100px" Height="22px" >
                        <asp:ListItem Value="0">Mayor a</asp:ListItem>
                        <asp:ListItem Value="1">Menor a</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="TextBoxCapacidad" runat="server" Height="16px" Width="30px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td></td>                
                <td class="auto-style13" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:RadioButton ID="consultaSalonPorStatus" runat="server" 
                        GroupName="ConsultarSalon" Text="Status:" />
                       
                    
                    </td>  
                <td class="auto-style18">
                    <asp:DropDownList ID="DropDownListStatusSalon" runat="server" Width="100px">
                        <asp:ListItem Value="0">Activo</asp:ListItem>
                        <asp:ListItem Value="1">Inactivo</asp:ListItem>
                    </asp:DropDownList>


                </td>  
                <td class="auto-style7"><asp:Button ID="Button1" runat="server" Height="25px" Width="120px" Text="Buscar" CssClass="button" OnClick="botonBuscarSalon_Click" ValidationGroup="check"/>
                </td>  
            </tr>
                 <tr>
                <td></td>                
                <td class="auto-style13">
                    &nbsp;</td>  
                <td class="auto-style18">
                    &nbsp;</td>  
                <td class="auto-style7">&nbsp; </td>  
                
            </tr>
            </table>
            &nbsp;
            &nbsp;            
            
            <asp:GridView ID="GridConsultar" runat="server" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" align="center" Height="16px" Width="734px" 
                        OnRowCommand="GridConsultar_RowCommand"
                       AllowPaging="True" PageSize="10" 
                        HorizontalAlign="Center">
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
        .auto-style7 {
            width: 254px;
        }
        .auto-style12
        {
            height: 31px;
            width: 196px;
        }
        .auto-style13
        {
            width: 196px;
        }
        .auto-style14
        {
            height: 50px;
        }
        .auto-style15
        {
            width: 196px;
            height: 50px;
        }
        .auto-style17
        {
            width: 254px;
            height: 50px;
        }
        .auto-style18
        {
            width: 194px;
        }
        .auto-style19
        {
            width: 194px;
            height: 50px;
        }
        .auto-style20
        {
            height: 31px;
            width: 194px;
        }
    </style>
</asp:Content>
