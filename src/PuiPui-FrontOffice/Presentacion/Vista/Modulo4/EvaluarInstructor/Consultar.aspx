<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.Master"
 AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="PuiPui_FrontOffice.Presentacion.Vista.Modulo4.EvaluarInstructor.Consultar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:GridView ID="EvaluacionesTodasGrid" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="text-align: center" Width="605px" AllowPaging="True" AutoGenerateColumns="False" OnSelectedIndexChanged="EvaluacionesTodasGrid_SelectedIndexChanged" DataKeyNames="idEvaluacion">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Instructor.NombrePersona1" HeaderText="Nombre"/>  
                <asp:BoundField DataField="Instructor.ApellidoPersona1" HeaderText="Apellido"/>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha Evaluacion"/>
                <asp:BoundField DataField="Calificacion" HeaderText="Puntaje"/>
                <asp:CommandField HeaderText="Modificar Evaluacion" ShowSelectButton="True" SelectText="..."/>    
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </p>
</asp:Content>
