<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarDetalleReservacionClase.aspx.cs" Inherits="PuiPuiCapaDeInterfazFrontOffice.Vistas.VReservarClase.ConsultarDetalleReservacionClase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        //<table style="margin:auto;" border="0">
            <tr>
                <td style="font-weight:bold">Informacion Clase</td>
                <td><asp:Label ID="lbDescripcionClase" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="font-weight:bold">Cliente</td>
                <td><asp:TextBox ID="tbCliente" runat="server" Enabled="false"></asp:TextBox></td>
            </tr>
             <tr>
                 <td style="font-weight:bold">Fecha :</td>
                 <td><asp:Label ID="lbDia" runat="server" Text="Label"></asp:Label>
                     <asp:Label ID="lbFecha" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="font-weight:bold">Inicio :</td>
                <td><asp:Label ID="lbHoraInicio" runat="server" Text="Label"></asp:Label></td>
           </tr>
           <tr>
                <td style="font-weight:bold"> Finaliza :</td>
                <td><asp:Label ID="lbHoraFin" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="font-weight:bold">Instructor :</td>
                <td><asp:Label ID="lbInstructorNombre" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="font-weight:bold">Contacto:</td>
                <td><asp:Label ID="lbInstructorCorreo" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="font-weight:bold" >Capacidad #</td>
                <td><asp:Label ID="lbSalonCapacidad" runat="server" Text="Label"></asp:Label></td>
           </tr>
            <tr>
                <td style="font-weight:bold">Ubicacion :</td>
                <td><asp:Label ID="lbSalonUbicacion" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="font-weight:bold">Estatus Reservacion</td>
                <td>
                        <asp:RadioButton
                            id="rbActivada"
                            Text="Activada"
                            GroupName="Source"
                            Runat="server" />
                      
                        <asp:RadioButton
                            id="rbDesctivada"
                            Text="Desactivada"
                            GroupName="Source"
                            Runat="server" />
                    <asp:Label ID="lbEstatusReservacion" runat="server" Text="Label"></asp:Label>
                 </td>
                </tr>
            <tr>
                <td valign="middle" colspan="2" >
                    <asp:Button ID="btnGuardar" runat="server" Text="Reservar" onclick="btnGuardar_Click" />
                </td>
                 <td valign="middle" colspan="2">
                     <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" onclick="btnCancelar_Click" />
                </td>
            </tr>
        </table>
      </div>
    </form>
</body>
</html>