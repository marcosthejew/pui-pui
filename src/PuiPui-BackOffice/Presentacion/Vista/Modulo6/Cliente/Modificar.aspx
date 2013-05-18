<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
  AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo6.Cliente.Modificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<asp:GridView ID="GridModificar" runat="server" AllowPaging="True" AutoGenerateColumns="false"
                CellPadding="4" CssClass="nada" ForeColor="#333333" GridLines="None" HorizontalAlign="Center"
                OnPageIndexChanging="GridModificar_PageIndexChanging" OnSelectedIndexChanged="GridModificar_SelectedIndexChanged"
                PageSize="5" SelectedIndex="0" Width="600px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField AccessibleHeaderText="Seleccion" ButtonType="Image" HeaderText="Detalle"
                        SelectImageUrl="~/Presentacion/Imagenes/Editar.png" ShowSelectButton="True" />
                    <asp:BoundField DataField="Identificacion" HeaderText="Identificacion" Visible="False" />
                    <asp:BoundField DataField="PrimerNombre" HeaderText="PrimerNombre" />
                    <asp:BoundField DataField="PrimerApellido" HeaderText="PrimerApellido" />
                    <asp:BoundField DataField="FechaRegistro" HeaderText="FechaRegistro" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" HorizontalAlign="Center" VerticalAlign="Middle" />
                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerSettings PageButtonCount="4" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" VerticalAlign="Middle" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:GridView>
    </asp:Content>