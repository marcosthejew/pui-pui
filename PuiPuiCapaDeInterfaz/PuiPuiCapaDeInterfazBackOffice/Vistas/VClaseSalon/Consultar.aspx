<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazBackOffice.Master" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="PuiPuiCapaDeInterfazBackOffice.Vistas.VClaseSalon.Consular" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center;">
    <h1>CLASE - SALON - INSTRUCTOR</h1>        
    </div>
        
    <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
       <legend style="text-align:center;"><h2>Asignación de Clase - Salón - Instructor</h2></legend>
               
             <table border="0" cellspacing="0" cellpadding="0" style="width: 782px; margin-left:0px; height: 114px;">
            <tr>
                <td rowspan="0" nowrap="nowrap" class="auto-style25" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;" >
                    Buscar por:
                    <asp:RadioButton ID="Todos" runat="server" Text="Todos los campos" />
                </td>
                <td rowspan="0" class="auto-style21" nowrap="nowrap" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                     <asp:RadioButton ID="RadioButtonConsultaCompleta" runat="server" 
                        GroupName="ConsultarClases" Text="Clase:"  /> 
                              

                     <br />
                   

                    <asp:TextBox ID="nombreClase" runat="server" Width="70px" style="margin-left: 24px" Height="21px" ValidationGroup="check" ></asp:TextBox>
                    

                     <br />
                    
                     <br />
                   
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="nombreClase" ValidationGroup="check" ForeColor="Red" runat="server" ErrorMessage="Solo se pueden introducir letras y numeros" ValidationExpression="^[a-zA-Z 0-9''-'\s]{1,25}$"></asp:RegularExpressionValidator>
                    
                     </td>
                <td rowspan="0" class="auto-style26" nowrap="nowrap" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:RadioButton ID="consultaSalon" runat="server" 
                        GroupName="ConsultarClases" Text="Salón:" OnCheckedChanged="consultaClasePorNombres_CheckedChanged"   
                       />

                    <br />
                   

                    <asp:TextBox ID="nombreSalon" runat="server" Width="82px" style="margin-left: 11px" Height="20px" ValidationGroup="check" ></asp:TextBox>


                    <br />
                    <br />
                   
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="nombreSalon" ValidationGroup="check" ForeColor="Red" runat="server" ErrorMessage="Solo se pueden introducir letras y numeros" ValidationExpression="^[a-zA-Z 0-9''-'\s]{1,25}$"></asp:RegularExpressionValidator>
                    

                    </td>
              
                <td rowspan="1" nowrap="nowrap" class="auto-style24" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                    <asp:RadioButton ID="consultaClasePorInstructor" runat="server" 
                        GroupName="ConsultarClases" Text="Instructor:"  />
                       
                    
                    <br />
                   

                    <asp:TextBox ID="nombreInstructor" runat="server" Width="91px" style="margin-left: 30px" Height="19px"  ValidationGroup="check"></asp:TextBox>


                    <br />
                    <br />
                   
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="nombreInstructor" ValidationGroup="check" ForeColor="Red" runat="server" ErrorMessage="Solo se pueden introducir letras y numeros" ValidationExpression="^[a-zA-Z 0-9''-'\s]{1,25}$"></asp:RegularExpressionValidator>
                    

                    </td>
              
                <td rowspan="0" class="auto-style23" nowrap="nowrap">
                   

                    &nbsp;</td>
              
                <td rowspan="0" class="auto-style19" nowrap="nowrap" style="font-family: Arial,Helvetica, sans-serif;font-size: 14px;font-weight: bold;color: #fff;
margin-top: 0px;">
                   

                    &nbsp;</td>
              
                <td rowspan="0" nowrap="nowrap" class="auto-style17" align="left">
                   

                <asp:Button ID="botonBuscarClase" runat="server" Text="Buscar" CssClass="button" OnClick="botonBuscarClase_Click" Font-Names="tahoma plain" Font-Size="14px" Height="24px" Width="89px" ValidationGroup="check"/>


                </td>
                <td class="auto-style3">


                    &nbsp;</td>
              
            </tr>

            </table> 
           </br>
           
     
          
                        <asp:GridView ID="GridConsultar" runat="server" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" Height="16px" Width="687px" 
                         AllowPaging="True" 
                        HorizontalAlign="Center" style="margin-right: 0px">
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
            margin-left: 11px;
        }
        .auto-style17 {
            width: 83px;
        }
        .auto-style19 {
            width: 65px;
        }
        .auto-style21 {
            width: 124px;
        }
        .auto-style23 {
            width: 12px;
        }
        .auto-style24 {
            width: 150px;
        }
        .auto-style25
        {
            width: 233px;
        }
        .auto-style26
        {
            width: 117px;
        }
        </style>
    </asp:Content>