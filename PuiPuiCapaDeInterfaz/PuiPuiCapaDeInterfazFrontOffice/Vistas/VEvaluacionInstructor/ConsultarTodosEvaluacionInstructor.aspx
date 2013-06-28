<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazFrontOffice.Master" AutoEventWireup="true" CodeBehind="ConsultarTodosEvaluacionInstructor.aspx.cs" Inherits="PuiPuiCapaDeInterfazFrontOffice.Vistas.VEvaluacionInstructor.ConsultarTodosEvaluacionInstructor" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div style="text-align:center; font-family:Helvetica; font-size:16px;">
    <asp:Label ID="Label1" runat="server" Text="<h1>EVALUACION INSTRUCTOR</h1>"></asp:Label>
    </div>
    
    <div style="height:30px; text-align:left; font-family:Helvetica; font-size:14px;">
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla" 
            Visible="False" ForeColor="Red"></asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito" 
            Visible="False" ForeColor="#ffffff"></asp:Label>
    </div>
     <div  style="float:left;">
        <fieldset style="width:775px; height:auto; margin-left:7.5%; fit-position:center;">
        <legend style="text-align:center; font-family:Helvetica; font-size:14px;">
            </legend>
            <h2 style="text-align:center">Consultar Evaluacion Instructor</h2>
            <h2 style="text-align:center">
                    <asp:RegularExpressionValidator  ID="ValidacionExpresionRegular" ControlToValidate="nombreIntructor" runat="server" ForeColor="Red"
                        ErrorMessage="Solo se pueden introducir letras y numeros (sin caracteres especiales)" ValidationGroup="check" ValidationExpression="^[a-zA-Z 0-9''-'\s]{1,25}$"  Display="Dynamic" >

                    </asp:RegularExpressionValidator>
                    </h2>

        <table border="0" cellspacing="0" cellpadding="0" style="width: 750px; height: 30px;" >
            <tr>
                <td rowspan="0" style="height: 8px; width: 150px">
                    <h3 style="width: 110px">Buscar por:</h3></td>
                <td rowspan="0" style="font-family: Arial,Helvetica, sans-serif; width: 79px; font-size: 14px; font-weight: bold; color: #fff;">
                    <asp:RadioButton ID="RadioButtonConsultaCompleta" runat="server" Text="Todos:" GroupName="ConsultarEvaluacionInstructor"/>
                </td>
                 <td rowspan="0" class="auto-style15" style="font-family: Arial,Helvetica, sans-serif; font-size: 14px; font-weight: bold; color: #fff; margin-top: 0px;">
                    <asp:RadioButton ID="consultaClasePorNombres" runat="server"  GroupName="ConsultarEvaluacionInstructor" Text="Nombre:" />

                </td>
                <td rowspan="0" style="width: 114px; ">
                    <asp:TextBox ID="nombreIntructor" runat="server" Width="163px" style="margin-left: 0px" ValidationGroup="check"></asp:TextBox>
                </td>
                <td rowspan="0" style="width: 100px; ">
                </td>
                 <td rowspan="0" style="text-align:left">
                <asp:Button ID="botonBuscarClase" runat="server" Text="Buscar" Width="98px" Height="20px" CssClass="button" OnClick="botonBuscarClase_Click" Font-Names="tomoha plain" Font-Size="14px"/>

                </td>
            </tr>
            
       </table> 

            &nbsp;
            &nbsp;
                       
            <asp:GridView ID="GridConsultar" runat="server" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" Height="16px" Width="687px" AllowPaging="True" HorizontalAlign="Center" >

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
        .button {
            margin-left: 50px;
        }
        .auto-style15 {
            width: 81px;
        }
        .auto-style16 {
            width: 65px;
        }
        .auto-style18 {
            width: 77px;
        }
        .auto-style19 {
            width: 114px;
        }
        .auto-style21 {
            width: 95px;
        }
        .auto-style22 {
            width: 79px;
        }
    </style>
</asp:Content>