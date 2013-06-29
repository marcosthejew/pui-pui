<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazFrontOffice.Master" AutoEventWireup="true" CodeBehind="ConsultarEvaluacionInstructor.aspx.cs" Inherits="PuiPuiCapaDeInterfazFrontOffice.Vistas.VEvaluacionInstructor.ConsultarEvaluacionInstructor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align: center; font-family: Helvetica; font-size: 16px;">
        <asp:Label ID="Label1" runat="server" Text="<h1>EVALUACION INSTRUCTOR</h1>"></asp:Label>
    </div>
    <div style="height: 30px; text-align: left; font-family: Helvetica; font-size: 14px;">
        <asp:Label ID="falla" runat="server" Text="Operación Fallida" CssClass="falla"
            Visible="False" ForeColor="Red"></asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Operación Exitosa" CssClass="Exito"
            Visible="False" ForeColor="#ffffff"></asp:Label>
    </div>

    <div style="float: left;">
        <fieldset style="width: 775px; height: auto; margin-left: 7.5%; fit-position: center;">
            <legend style="text-align: center; font-family: Helvetica; font-size: 14px;"></legend>
            <h2 style="text-align: center">Consultar Clase</h2>
            <table border="0" cellspacing="0" cellpadding="0" style="width: 799px; height: 26px;">
                <tr>
                    <td rowspan="0">
                        <h3 style="height: 10px; width: 110px">Buscar por:</h3>
                    </td>
                    <td rowspan="0" style="width: 110px; font-family: Arial,Helvetica, sans-serif; font-size: 14px; font-weight: bold; color: #fff; margin-top: 0px;">
                        <asp:RadioButton ID="RadioButtonConsultaCompleta" runat="server"
                            GroupName="ConsultarEvaluacion" Text="Todos:" />


                    </td>
                    <td rowspan="0" style="width: 110px; font-family: Arial,Helvetica, sans-serif; font-size: 14px; font-weight: bold; color: #fff; margin-top: 0px;">
                        <asp:RadioButton ID="consultaClasePorNombres" runat="server"
                            GroupName="ConsultarEvaluacion" Text="Instructor:" />

                    </td>

                    <td rowspan="0" class="auto-style19">

                        <asp:TextBox ID="nombreInstructor" runat="server" Width="163px" Style="margin-left: 0px" ValidationGroup="check"></asp:TextBox>
                    </td>
                    <td rowspan="0" style="text-align: left">
                        <asp:Button ID="botonBuscarClase" runat="server" Text="Buscar" Width="98px" Height="20px" CssClass="button" OnClick="botonBuscarClase_Click" Font-Names="tomoha plain" Font-Size="14px" />
                    </td>
                </tr>
            </table>

            &nbsp;      
    &nbsp;

    <asp:GridView ID="GridConsulta" runat="server"
        CellPadding="4" ForeColor="#333333"
        GridLines="None" Height="16px" Width="687px"
        AllowPaging="True" PageSize="10"
        OnRowCommand="GridConsultar_RowCommand"
        HorizontalAlign="Center">

        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" HorizontalAlign="Center" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerSettings PageButtonCount="4" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
        <Columns>
            <asp:ButtonField HeaderText="Ver Detalle" CommandName="Consultar"
                ButtonType="image" ImageUrl="~/Imagenes/Buscar.png" />
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
