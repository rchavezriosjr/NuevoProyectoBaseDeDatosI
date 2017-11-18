<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListCompra.aspx.cs" Inherits="SistemaVC.ListCompra" %>

<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %>
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
   <title>| Sistema SIVECOMP | Compras |</title>
    <link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
	<link rel="shortcut icon"href="Imagenes/favicon.ico" type="image/x-icon"  />
	
     <link href="Styles/jquery-ui-1.8rc3.custom.css" rel="stylesheet" />
    <link href="Styles/simpleAutoComplete.css" rel="stylesheet" />
	
   
    
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

            return confirm("¿Realmente desea eliminar esta compra?");
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
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> Listado de Compras</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">

      <!--Contenido aqui-->

       <asp:GridView ID="gridCompras" runat="server" CssClass="subtitulo" EmptyDataText="No existen Registros" AutoGenerateColumns="False" OnRowCommand="gridCompras_RowCommand" CellPadding="4" ForeColor="Black" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle CssClass ="registroTitulo" Font-Size="10px" BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle CssClass ="registroNormal" Font-Size="10px" />
                  <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                  <RowStyle CssClass ="registroAlternado" Font-Size="10px" />
              <Columns>
                  <asp:TemplateField HeaderText="Id" HeaderStyle-Width="30px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblId" Text='<%# Eval("Id") %>'></asp:Label>
                      </ItemTemplate>

<HeaderStyle Width="30px"></HeaderStyle>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Descripcion" HeaderStyle-Width="200px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblDescripcion" Text='<%# Eval("Descripcion") %>'></asp:Label>
                      </ItemTemplate>

<HeaderStyle Width="200px"></HeaderStyle>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Fecha de Compra" HeaderStyle-Width="150px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblFechaCompra" Text='<%# Eval("FechaCompra") %>'></asp:Label>
                      </ItemTemplate>

<HeaderStyle Width="150px"></HeaderStyle>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Proveedor" HeaderStyle-Width="150px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblProveedor" Text='<%# Eval("ProveedorDescripcion") %>'></asp:Label>
                      </ItemTemplate>

<HeaderStyle Width="150px"></HeaderStyle>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Monto" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblMonto" Text='<%# Eval("Monto") %>'></asp:Label>
                      </ItemTemplate>

<HeaderStyle Width="100px"></HeaderStyle>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Numero Ticket" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblNumeroTicket" Text='<%# Eval("NumeroTicket") %>'></asp:Label>
                      </ItemTemplate>

<HeaderStyle Width="100px"></HeaderStyle>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Acciones" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:ImageButton runat="server" ID="btnEditar" AlternateText="Editar Compra" ToolTip="Editar Compra" CssClass="cBotones" ImageUrl="~/Imagenes/edit.png" CommandName="EditarCompra" CommandArgument='<%# Eval("Id") %>'/>
                          <asp:ImageButton runat="server" ID="btnEliminar" AlternateText="Eliminar Compra" OnClientClick="return Confirmacion();" ToolTip="Eliminar Compra" CssClass="cBotones" ImageUrl="~/Imagenes/eliminar.png"  CommandName="EliminarCompra" CommandArgument='<%# Eval("Id") %>'/>
                      </ItemTemplate>

<HeaderStyle Width="100px"></HeaderStyle>
                  </asp:TemplateField>
              </Columns>
                <SelectedRowStyle BackColor="White" Font-Bold="True" ForeColor="#663399" BorderStyle="Solid" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
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

