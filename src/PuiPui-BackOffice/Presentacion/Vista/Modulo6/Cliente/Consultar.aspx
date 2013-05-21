﻿<%@ Page Title="" Language="C#" MasterPageFile="../../../MasterPage/Site.master"
 AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo6.Cliente.Consultar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <fieldset style="width:740px; height:100px; margin-left:0px auto 0px auto;">
            <legend>Buscar Empleados</legend>
            <table align="center" border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        <asp:RadioButton ID="cedulaRadioButton" GroupName="Grupo1" runat="server" 
                            Checked="True" oncheckedchanged="cedulaRadioButton_CheckedChanged" AutoPostBack="true"/>
                        Cedula:</td>
                    <td>
                        <asp:TextBox ID="CiConsTextBox" runat="server" Height="20px" Width="130px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RadioButton ID="cargoRadioButton" GroupName="Grupo1" runat="server" 
                            oncheckedchanged="cargoRadioButton_CheckedChanged" AutoPostBack="true"/>
                        Cargo:</td>
                    <td><asp:TextBox ID="NombreTextBox" runat="server" Height="20px" Width="130px"></asp:TextBox>
                    
                    </td>
              
                </tr>
                                    <tr>
                         <td colspan="4" style="text-align:center; padding-top:10px">
                        <asp:Button ID="buscarCiCargoButton" runat="server" CssClass="button" 
                            onclick="buscarCiCargoButton_Click" Text="Buscar" />
                    </td>
                    </tr>
                
            
            </table> 
                    </fieldset><br />

<asp:GridView ID="GridConsultar" runat="server" AllowPaging="True" AutoGenerateColumns="false"
                Height="35px" GridLines="None" style="text-align: center" 
                CellPadding="4" CssClass="nada" ForeColor="#333333" HorizontalAlign="Center"
                OnPageIndexChanging="GridConsultar_PageIndexChanging" 
                OnSelectedIndexChanged="GridConsultar_SelectedIndexChanged"
                PageSize="5" SelectedIndex="0" Width="600px" DataKeyNames="cedulaPersona" >
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField AccessibleHeaderText="Seleccion" ButtonType="Image" HeaderText="Detalle"
                        SelectImageUrl="~/Presentacion/Imagenes/Buscar.png" ShowSelectButton="True" />
                    <asp:BoundField DataField="idPersona" HeaderText="idPersona" Visible="false"/>
                    <asp:BoundField DataField="cedulaPersona" HeaderText="cedulaPersona"/>
                    <asp:BoundField DataField="nombrePersona1" HeaderText="nombrePersona1" />
                    <asp:BoundField DataField="apellidoPersona1" HeaderText="apellidoPersona1" />
                    <asp:BoundField DataField="fechaIngresoPersona" HeaderText="fechaIngresoPersona" />
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