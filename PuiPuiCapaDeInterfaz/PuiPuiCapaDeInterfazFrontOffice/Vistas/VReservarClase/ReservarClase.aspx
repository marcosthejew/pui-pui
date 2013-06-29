<%@ Page Language="C#" MasterPageFile="~/MasterPages/PuiPuiCapaDeInterfazFrontOfficeSesion.Master" AutoEventWireup="true" CodeBehind="ReservarClase.aspx.cs" Inherits="PuiPuiCapaDeInterfazFrontOffice.Vistas.VReservarClases.ReservarClase" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContent">
<link href="../../Scripts/fullcalendar/fullcalendar.css" rel="stylesheet" />
<script src="../../Scripts/fullcalendar/jquery-1.7.js" type="text/javascript"></script>
<script src="../../Scripts/fullcalendar/jquery-ui.js" type="text/javascript"></script>
<link href="../../Estilos/jquery-ui.css" rel="stylesheet" />
<script src="../../Scripts/fullcalendar/jquery.qtip-1.0.0-rc3.min.js"></script>
<script src="../../Scripts/fullcalendar/fullcalendar.min.js"></script>
<script src="../../Scripts/gym2.js" type="text/javascript"></script>
<asp:Label ID="nombreClase" runat="server" Text="Label"></asp:Label>
     <div style="float: left;">
       <table style="margin:auto;" border="0" cellspacing="10" cellpadding="10">
             <tr>
                     <td class="auto-style6"><asp:Panel ID="PanelClases" runat="server" align="top"></asp:Panel></td>
                     <td class="auto-style6"><div id='calendar2'style="width:700px";></div></td>
            </tr>
           
           

     </table>
</div>
 <div id="myDiv" style="text-align: left;display: none;">
</div>
</asp:Content>