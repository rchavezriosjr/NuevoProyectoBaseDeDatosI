<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditCompra.aspx.cs" Inherits="SistemaVC.EditCompra" %>


<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %>
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<%@ Register Assembly="eWorld.UI, Version=1.9.0.0, Culture=neutral, PublicKeyToken=24d65337282035f2" Namespace="eWorld.UI" TagPrefix="ew" %> 
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
    <title>| Sistema SIVECOMP| Compras</title>
	
     <link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
    <link rel="Stylesheet" href="Imagenes/favicon.ico" type="image/x-icon"/>

    <script src="js/jquery.js"></script>
    <script src="js/jquery-ui-1.8rc3.custom.min.js"></script>
    
    <link href="Styles/jquery-ui-1.8rc3.custom.css" rel="stylesheet" />
    <link href="Styles/simpleAutoComplete.css" rel="stylesheet" />
    
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
</style>
    
    <script>
        $(function () {

            //Array para dar formato en espa�ol
            $.datepicker.regional['es'] =
            {
                closeText: 'Cerrar',
                prevText: 'Previo',
                nextText: 'Pr�ximo',

                monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio',
                'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
                monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun',
                'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
                monthStatus: 'Ver otro mes', yearStatus: 'Ver otro a�o',
                dayNames: ['Domingo', 'Lunes', 'Martes', 'Mi�rcoles', 'Jueves', 'Viernes', 'S�bado'],
                dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mie', 'Jue', 'Vie', 'S�b'],
                dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sa'],
                dateFormat: 'dd/mm/yy', firstDay: 0,
                initStatus: 'Selecciona la fecha', isRTL: false
            };
            $.datepicker.setDefaults($.datepicker.regional['es']);

            $("#txtFecha").datepicker({
                dateFormat: 'dd/mm/yy', showOn: 'button', buttonImage: 'Imagenes/Calendario.png', buttonImageOnly: true, changeMonth: true,
                changeYear: true, gotoCurrent: true
            });
        });


        $(function () {
            $('#txtProveedor').simpleAutoComplete('Autocomplete.aspx', {
                autoCompleteClassName: 'autocomplete',
                selectedClassName: 'sel',
                attrCallBack: 'rel',
                identifier: 'Proveedor'
            }, fnProveedorCallback);

        });

        function fnProveedorCallback(par) {
            //par[0] id
            //par[1] descripcion
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
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> &nbsp;&nbsp; Alta de Compras</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">
          <!--Contenido aqui-->
          <table>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Id Compra" ID="labelClienteId" Visible="false"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtId" Visible="false"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Descripcion" ID="label1"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" Rows="3"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="rfvValidarNombre" runat="server" errormessage="La descripcion es obligatoria" width="132px" controltovalidate="txtDescripcion" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Fecha Compra" ID="label2"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtFecha"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" errormessage="La fecha de compra es olbigatoria" width="132px" controltovalidate="txtFecha" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Monto" ID="label4"></asp:Label>
                       
                  </td>
                  <td>
                      
                      <ew:NumericBox runat="server" ID="txtMonto" DecimalPlaces="2" PlacesBeforeDecimal="6"  />
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" errormessage="El monto de la compra es olbigatoria" width="132px" controltovalidate="txtMonto" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>
                <tr>
                  <td>
                      <asp:Label runat="server" Text="Proveedor" ID="label5"></asp:Label>
                       
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtProveedor" onkeypress="return event.keyCode!=13;"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" errormessage="El proveedor es olbigatorio" width="132px" controltovalidate="txtProveedor" display="Dynamic"></ASP:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td>
                      <asp:Label runat="server" Text="Numero Ticket" ID="label3"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtNumeroTicket"></asp:TextBox>
                  </td>
              </tr>
              
                  <tr>
                  <td>
                      &nbsp;</td>
                  <td>
                      
                      <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="boton_formulario" OnClick="btnGuardar_Click" />
                      
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