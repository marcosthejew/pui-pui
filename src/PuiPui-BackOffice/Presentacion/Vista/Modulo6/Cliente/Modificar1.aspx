<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/MasterPage/Site.Master" AutoEventWireup="true" CodeBehind="Modificar1.aspx.cs" Inherits="PuiPui_BackOffice.Presentacion.Vista.Modulo6.Cliente.Modificar1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div style="height: 30px; text-align: center; font-family: Verdana; font-size: 1.5em;">
        <asp:Label ID="falla" runat="server" Text="Label" Visible="False" CssClass="falla">Operación Fallida</asp:Label>
        <asp:Label ID="Exito" runat="server" Text="Label" Visible="False" CssClass="Exito">Operación Realizada Exitosame</asp:Label>
    </div>
    <div style="float: left;">
        
        
         <table style="margin:auto;" border="0" cellspacing="10" cellpadding="10" >
        
                <tr>
                    <td class="auto-style6">Identificador</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LIdentificador" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Fecha de Ingreso</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LFechaIngreso" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                </tr>
                     <tr>
                    <td class="auto-style6">Cedula</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LCedula" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Tipo Persona</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ComboTipo" runat="server" Height="21px" Width="120px">
                            <asp:ListItem Value="Cliente">Cliente</asp:ListItem>
                            <asp:ListItem Value="Administrador">Administrador</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Fecha Nacimiento</td>
                    <td class="auto-style2">
                        <asp:Calendar ID="LFechaNacimiento" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                    </td>
                    <td class="auto-style6">Genero</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ComboGenero" runat="server" Height="21px" Width="120px">
                            <asp:ListItem Value="Femenino">Femenino</asp:ListItem>
                            <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Primer Nombre</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LPrimerNombre" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Segundo Nombre</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LSegundoNombre" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Primer Apellido</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LPrimerApellido" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Segundo Apellido</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LSegundoApellido" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="auto-style6">Telefono Celular</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LTelefonoCelular" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Telefono Local</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LTelefonoLocal" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Nombre contacto emergencia</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LNombreContactoEmergencia" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Telefono contacto emergencia</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LTelefonoContactoEmergencia" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                    <td class="auto-style6">Correo Electronico</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LCorreo" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Ciudad</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LCiudad" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" >Direccion</td>
                    <td class="auto-style2"colspan="3">
                        <asp:TextBox ID="LDireccion" runat="server" Height="20px" Width="690px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Usuario</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LUsuario" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">Contrasena</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="LContrasena" runat="server" Height="20px" Width="190px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Status</td>
                    <td class="auto-style2"colspan="3">
                        <asp:DropDownList ID="ComboStatus" runat="server" Height="20px" Width="90px">
                            <asp:ListItem Value="Activo">Activo</asp:ListItem>
                            <asp:ListItem Value="Inactivo">Inactivo</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                  <tr>
                    <td colspan="4" align="center">
                        <asp:Button ID="BRegistrar" runat="server" CssClass="button" onclick="BRegistrar_Click" Text="Aceptar" />
                    </td>
                </tr>
             </table>

    </div>

        <div id="validaciones">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        
        <!--Validacion: NO pueden estar vacio los campos  -->
        <asp:RequiredFieldValidator ID="cedula" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>cedula</strong> es requerido. Verifique"
            ControlToValidate="LCedula" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarCedula" runat="server" TargetControlID="cedula"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <asp:RequiredFieldValidator ID="primerNombre" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>primer nombre</strong> es requerido. Verifique"
            ControlToValidate="LPrimerNombre" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
                <cc1:validatorcalloutextender ID="validarPrimerNombre" runat="server" TargetControlID="primerNombre"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <asp:RequiredFieldValidator ID="segundoNombre" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>segundo nombre</strong> es requerido. Verifique"
            ControlToValidate="LSegundoNombre" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarSegundoNombre" runat="server" TargetControlID="segundoNombre"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <asp:RequiredFieldValidator ID="primerApellido" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>primer apellido</strong> es requerido. Verifique"
            ControlToValidate="LPrimerApellido" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarPrimerApellido" runat="server" TargetControlID="primerApellido"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <asp:RequiredFieldValidator ID="segundoApellido" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>segundo apellido</strong> es requerido. Verifique"
            ControlToValidate="LSegundoApellido" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarSegundoApellido" runat="server" TargetControlID="segundoApellido"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <asp:RequiredFieldValidator ID="telefonoCelular" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>telefono celular</strong> es requerido. Verifique"
            ControlToValidate="LTelefonoCelular" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarTelefonoCelular" runat="server" TargetControlID="telefonoCelular"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <asp:RequiredFieldValidator ID="telefonoLocal" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>telefono local</strong> es requerido. Verifique"
            ControlToValidate="LTelefonoLocal" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarTelefonoLocal" runat="server" TargetControlID="telefonoLocal"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <asp:RequiredFieldValidator ID="nombreContactoEmergencia" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>nombre contacto de emergencia</strong> es requerido. Verifique"
            ControlToValidate="LNombreContactoEmergencia" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarNombreContactoEmergencia" runat="server" TargetControlID="nombreContactoEmergencia"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <asp:RequiredFieldValidator ID="telefonoContactoEmergencia" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>telefono contacto de emergencia</strong> es requerido. Verifique"
            ControlToValidate="LTelefonoContactoEmergencia" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarTelefonoContactoEmergencia" runat="server" TargetControlID="telefonoContactoEmergencia"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <asp:RequiredFieldValidator ID="correo" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>correo electronico</strong> es requerido. Verifique"
            ControlToValidate="LCorreo" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarCorreo" runat="server" TargetControlID="correo"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

         <asp:RequiredFieldValidator ID="ciudad" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>ciudad</strong> es requerido. Verifique"
            ControlToValidate="LCiudad" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarCiudad" runat="server" TargetControlID="ciudad"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <asp:RequiredFieldValidator ID="direccion" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>direccion</strong> es requerido. Verifique"
            ControlToValidate="LDireccion" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarDireccion" runat="server" TargetControlID="direccion"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <asp:RequiredFieldValidator ID="usuario" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>usuario</strong> es requerido. Verifique"
            ControlToValidate="LUsuario" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarUsuario" runat="server" TargetControlID="usuario"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender> 

        <asp:RequiredFieldValidator ID="contrasena" runat="server" Display="Dynamic"
            ErrorMessage="El campo &lt;strong>contrasena</strong> es requerido. Verifique"
            ControlToValidate="LContrasena" CssClass="itemError">&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:RequiredFieldValidator>
        <cc1:validatorcalloutextender ID="validarContrasena" runat="server" TargetControlID="contrasena"
            Width="200px" HighlightCssClass="highlight">
        </cc1:validatorcalloutextender>

        <!--Validacio: SOLO caracteres numericos campos: cedula, telefono celular, telefono local, telefono contacto emergencia -->
        <cc1:filteredtextboxextender ID="_cedula" runat="server" TargetControlID="LCedula"
            FilterType="Numbers" />
        <cc1:filteredtextboxextender ID="_telefonoCelular" runat="server" TargetControlID="LTelefonoCelular"
            FilterType="Numbers" />
        <cc1:filteredtextboxextender ID="_telefonoLocal" runat="server" TargetControlID="LTelefonoLocal"
            FilterType="Numbers" />
        <cc1:filteredtextboxextender ID="_telefonoContactoEmergencia" runat="server" TargetControlID="LTelefonoContactoEmergencia"
            FilterType="Numbers" />
    </div>

</asp:Content>
