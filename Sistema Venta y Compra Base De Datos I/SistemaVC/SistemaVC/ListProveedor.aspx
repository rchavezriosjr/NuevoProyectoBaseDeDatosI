<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListProveedor.aspx.cs" Inherits="SistemaVC.ListProveedor" %>

<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %>
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
   <title>| Sistema SIVECOMP| Proveedor |</title>
    <link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
	<link rel="shortcut icon"href="Imagenes/favicon.ico" type="image/x-icon"  />
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
                                                                              .subtitulo {
                                                                                  margin-top: 0px;
                                                                              }
                                                                          </style></head>
  
  <body>
 <MsgBox:UCMessageBox ID="messageBox" runat="server" ></MsgBox:UCMessageBox>
  <form id="form1" runat="server">
<table width="1000" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr>
      <td colspan="4"><img src="Imagenes/sistema.jpg" width="1000" height="143"></td>
    </tr>
    <tr>
      <td width="200" rowspan="2" align="left" valign="top" bgcolor="#37703e"><uc1:UCNavigation id="UserControl2" runat="server"></uc1:UCNavigation></td>
	  <td height="20" colspan="3" valign="top" style="background-color: #FFFFFF"  >&nbsp; <h2> Listado de Proveedores</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top" style="background-color: #FFFFFF">&nbsp;</td>
      <td width="770" valign="top" colspan="3" style="background-color: #FFFFFF">

      <!--Contenido aqui-->

          <asp:GridView ID="gridProveedor" runat="server" CssClass="subtitulo" EmptyDataText="No existen Registros" AutoGenerateColumns="False" OnRowCommand="gridProveedor_RowCommand" CellPadding="4" ForeColor="Black" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle CssClass ="registroTitulo" Font-Size="10px" BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle CssClass ="registroNormal" Font-Size="10px" />
                  <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                  <RowStyle CssClass ="registroAlternado" Font-Size="10px" />
              <Columns>
                  <asp:TemplateField HeaderText="Id" HeaderStyle-Width="10px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblClienteId" Text='<%# Eval("Id") %>'></asp:Label>
                      </ItemTemplate>

<HeaderStyle Width="10px"></HeaderStyle>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Nombre Proveedor" HeaderStyle-Width="200px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblNombre" Text='<%# Eval("Nombre") %>'></asp:Label>
                      </ItemTemplate>

<HeaderStyle Width="200px"></HeaderStyle>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Domicilio" HeaderStyle-Width="150px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblDomicilio" Text='<%# Eval("Domicilio") %>'></asp:Label>
                      </ItemTemplate>

<HeaderStyle Width="150px"></HeaderStyle>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Telefono" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblTelefono" Text='<%# Eval("Tel") %>'></asp:Label>
                      </ItemTemplate>

<HeaderStyle Width="100px"></HeaderStyle>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Email" HeaderStyle-Width="100px">
                      <ItemTemplate>
                          <asp:Label runat="server" ID="lblEmail" Text='<%# Eval("Email") %>'></asp:Label>
                      </ItemTemplate>

<HeaderStyle Width="100px"></HeaderStyle>
                  </asp:TemplateField>
                   <asp:TemplateField HeaderText="Acciones" HeaderStyle-Width="50px">
                      <ItemTemplate>
                          <asp:ImageButton runat="server" ID="btnEditar" AlternateText="Editar Proveedor" ToolTip="Editar Proveedor" CssClass="cBotones" ImageUrl="~/Imagenes/edit.png" CommandName="EditarProveedor" CommandArgument='<%# Eval("Id") %>'/>
                          <asp:ImageButton runat="server" ID="btnEliminar" AlternateText="Eliminar Proveedor" ToolTip="Eliminar Proveedor" CssClass="cBotones" ImageUrl="~/Imagenes/eliminar.png"  CommandName="EliminarProveedor" CommandArgument='<%# Eval("Id") %>'/>
                      </ItemTemplate>

<HeaderStyle Width="50px"></HeaderStyle>
                  </asp:TemplateField>
              </Columns>
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
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