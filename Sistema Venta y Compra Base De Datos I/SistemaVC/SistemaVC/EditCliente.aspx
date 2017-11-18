<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditCliente.aspx.cs" Inherits="SistemaVC.EditCliente" %>

<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %>
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
    <title>| Sistema SIVECOMP | Cliente |</title>
	
	<link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
      <link  rel ="shortcut icon" href="Imagenes/favicon.ico" type="image/x-icon" />  
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
</style></head>
  
  <body>
 <MsgBox:UCMessageBox ID="messageBox" runat="server" ></MsgBox:UCMessageBox>
  <form id="form1" runat="server">
<table width="1000" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#ffffff">
    <tr>
      <td colspan="4"><img src="Imagenes/sistema.jpg" width="1000" height="143"></td>
    </tr>
    <tr>
      <td width="200" rowspan="2" align="left" valign="top" bgcolor="#37703e"><uc1:UCNavigation id="UserControl2" runat="server"></uc1:UCNavigation></td>
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> &nbsp;&nbsp;&nbsp; Alta de Cliente </h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">

      <!--Contenido aqui-->


           <table>
                 <tr>
                  <td>
                      <asp:Label runat="server" Text="Id Cliente" ID="labelClienteId" Visible="False" Font-Names="Times New Roman" Font-Size="Medium"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtId" Visible="False"></asp:TextBox>
                  </td>
              </tr>
             <tr>
                 <td class="auto-style2">
                      <asp:Label runat="server" Text="Nombre Cliente" ID="label1" Font-Names="Times New Roman" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False"></asp:Label>
                 </td>
                 <td class="auto-style3">
                     <asp:TextBox runat="server" ID="txtNombre" Width="211px" Font-Names="Baskerville Old Face" Height="24px" Font-Size="Small"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="rfvValidarNombre" runat="server" errormessage="El nombre es obligatorio" width="167px" controltovalidate="txtNombre" display="Dynamic" BorderColor="#006600" Height="23px"></ASP:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                  <td class="auto-style4">
                      <asp:Label runat="server" Text="Domicilio" ID="label2" Font-Names="Times New Roman" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox ID="txtDomicilio" runat="server" Font-Names="Baskerville Old Face" Height="40px" TextMode="MultiLine" Width="208px" Font-Size="Small"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="auto-style5">
                      <asp:Label runat="server" Text="Telefono" ID="label4" Font-Names="Times New Roman" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False"></asp:Label>
                  </td>
                  <td class="auto-style6">
                      <asp:TextBox runat="server" ID="txtTelefono" Font-Names="Baskerville Old Face" Font-Size="Small"></asp:TextBox>
                  </td>
              </tr>

              <tr>
                  <td class="auto-style7">
                      <asp:Label runat="server" Text="Email" ID="label3" Font-Names="Times New Roman" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False"></asp:Label>
                  </td>
                  <td class="auto-style8">
                      <asp:TextBox runat="server" ID="txtEmail" Width="209px" Font-Names="Baskerville Old Face" Font-Size="Small"></asp:TextBox>
                  </td>
              </tr>
              
                  <tr>
                  <td class="auto-style4">
                  
                      &nbsp;</td>
                  <td>
                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="boton_formulario" OnClick="btnGuardar_Click" Height="22px" Width="101px"/>
                    
                  </td>
              </tr>
         </table>


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
