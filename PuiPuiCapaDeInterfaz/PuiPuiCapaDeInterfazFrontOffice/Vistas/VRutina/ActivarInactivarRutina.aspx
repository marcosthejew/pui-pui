<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazFrontOffice.Master" AutoEventWireup="true" CodeBehind="ActivarInactivarRutina.aspx.cs" Inherits="PuiPuiCapaDeInterfazFrontOffice.Vistas.ActivarInactivarRutina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div style="height: 30px; text-align: center; font-family: Verdana; font-size: 1.5em;">
        <h1> Activar-Inactivar Rutinas</h1>
        <asp:Label ID="Demostracion" runat="server"></asp:Label>
    </div>
    
        <asp:GridView ID="GridConsultar" runat="server" AllowPaging="True" AutoGenerateColumns="false"
                Height="35px" GridLines="None" style="text-align: center" 
                CellPadding="4" CssClass="line" ForeColor="Black" HorizontalAlign="Center"
               OnPageIndexChanging="GridConsultar_PageIndexChanging" 
                OnSelectedIndexChanged="GridConsultar_SelectedIndexChanged"
                PageSize="5" SelectedIndex="0" Width="600px" DataKeyNames="idRutina" >
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField AccessibleHeaderText="Seleccion" ButtonType="Image" HeaderText="Detalle"
                        SelectImageUrl="~/Presentacion/Imagenes/cambiar_estado.png" ShowSelectButton="True" />
                    <asp:BoundField DataField="idRutina" HeaderText="idRutina" Visible="false"/>
                    <asp:BoundField DataField="nombre" HeaderText="NOMBRE"/>
                    <asp:BoundField DataField="descripcion" HeaderText="DESCRIPCION" />
                    <asp:BoundField DataField="status" HeaderText="STATUS" />
                   
                </Columns>
                <EditRowStyle BackColor="Silver" HorizontalAlign="Center" VerticalAlign="Middle" />
                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <FooterStyle BackColor="Silver" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerSettings PageButtonCount="4" />
                <PagerStyle BackColor="#333333" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="Silver" HorizontalAlign="Center" VerticalAlign="Middle" />
                <SelectedRowStyle BackColor="Silver" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:GridView>

</asp:Content>
