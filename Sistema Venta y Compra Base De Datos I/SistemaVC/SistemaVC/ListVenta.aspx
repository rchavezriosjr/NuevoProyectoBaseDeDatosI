<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListVenta.aspx.cs" Inherits="SistemaVC.ListVenta" %>

<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %>
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
   <title>| Sistema SIVECOMP| Ventas</title>
	
     <link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
    <link rel="Stylesheet" href="Imagenes/favicon.ico" type="image/x-icon"/>
    <script src="js/jquery.js"></script>
    <script src="js/jquery-ui-1.8rc3.custom.min.js"></script>
    
	<script src="Util.js" type="text/javascript"></script>

  <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"><style type="text/css">BODY {
	FONT-SIZE: 8.5pt
}
TD {
	FONT-SIZE: 8.5pt
}
TH {
	FONT-SIZE: 8.5pt
}
BODY {
	BACKGROUND-IMAGE: url(Imagenes/fondo.jpg); BACKGROUND-COLOR: #ffffff
}
                                                                              .subtitulo {}
                                                                          </style>
    
    <script>
        function Confirmacion() {

            return confirm("�Realmente desea eliminar esta Venta?");
        }
    </script>

</head>
  
  <body>
 <MsgBox:UCMessageBox ID="messageBox" runat="server" ></MsgBox:UCMessageBox>
  <form id="form1" runat="server">
<table width="1000" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#ffffff">
    <tr>
      <td colspan="4"><img src="Imagenes/sistema.jpg" width="1000" height="143"></td>
    </tr>
    <tr>
      <td width="200" rowspan="2" align="left" valign="top" bgcolor="#37703e"><uc1:UCNavigation id="UserControl2" runat="server"></uc1:UCNavigation></td>
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> Listado de Ventas</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">

      <!--Contenido aqui-->

         <asp:GridView ID="gridVentas" runat="server" CssClass="subtitulo" EmptyDataText="No existen Registros" AutoGenerateColumns="False" OnRowCommand="gridVentas_RowCommand" CellPadding="4" ForeColor="Black" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle CssClass ="registroTitulo" Font-Size="10px" BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle CssClass ="registroNormal" Font-Size="10px" />
                  <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                  <RowStyle CssClass ="registroAlternado" Font-Size="10px" />
              <Columns>
                  <asp:TemplateField HeaderText="Id" HeaderStyle-Width="30px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblVentaId" Text='<%# Eval("Id") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Cliente" HeaderStyle-Width="200px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblNombre" Text='<%# Eval("Nombre") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Fecha Venta" HeaderStyle-Width="150px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblFechaVenta" Text='<%# Eval("FechaVenta") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Monto" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblMonto" Text='<%# Eval("Monto") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  
                   <asp:TemplateField HeaderText="Acciones" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:ImageButton runat="server"  ID="btnEditarDetalles" AlternateText="Editar Detalles" ToolTip="Editar Detalles" CssClass="cBotones" ImageUrl="~/Imagenes/edit.png" CommandName="EditarDetalles" CommandArgument='<%# Eval("Id") %>'/>
                          <asp:ImageButton runat="server" ID="btnEliminar" AlternateText="Eliminar Venta"  OnClientClick="return Confirmacion();" ToolTip="Eliminar Venta" CssClass="cBotones" ImageUrl="~/Imagenes/eliminar.png"  CommandName="EliminarVenta" CommandArgument='<%# Eval("Id") %>'/>
                      </ItemTemplate>
                  </asp:TemplateField>
              </Columns>
          </asp:GridView>

        </td>
      
    </tr>
    <tr>
      <td width="200" height="30" bgcolor="#d2d2c6">&nbsp;</td>
      <td width="10" bgcolor="#d2d2c6">&nbsp;</td>
      <td width="770" bgcolor="#d2d2c6">&nbsp;</td>
      <td width="20" bgcolor="#d2d2c6">&nbsp;</td>
    </tr>
  </table>
   
  
    </form>
</body>
</html>