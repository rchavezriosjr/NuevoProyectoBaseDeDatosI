using ProyectoBDI___SisVent.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using System.Globalization;

namespace ProyectoBDI___SisVent.vista
{
    public partial class ventaForm : Form
    {
        int count, index, idcliente, idproducto;
        string accionformulario;
        public ventaForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public ventaForm(string id)
        {
            InitializeComponent();
            accionformulario = "ver";
            setDataView(id);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (!vistaClientes.ContainsFocus)
                Transition.run(panelDatosVenta, "Height", 28, new TransitionType_EaseInEaseOut(1000));

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                panelDatosVenta.Height = 28;
            }
            else
            {
                Transition.run(panelDatosVenta, "Height", 100, new TransitionType_EaseInEaseOut(1000));
                vistaClientes.DataSource = get(txtCliente.Text, "Cliente");
            }

            idcliente = -1;
        }

        private DataTable get(string value, string tabla)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Usuario");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select ID, Nombre from "+tabla+" where ID like '%" + value + "%' or Nombre like '%"+value+"%'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    data = null;
                }

                return data;
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text == "")
            {
                panelDatosDetalleVenta.Height = 28;
            }
            else
            {
                Transition.run(panelDatosDetalleVenta, "Height", 90, new TransitionType_EaseInEaseOut(1000));
                vistaProducto.DataSource = get(txtProducto.Text, "Producto");
            }

            idproducto = -1;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear")
                this.Close();
            else
            {
                ReadStatus(true);
                setDataView(txtCodigoVenta.Text);
            }
        }

        private void ventaForm_Load(object sender, EventArgs e)
        {
            borrarDetalle.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 30, 30, 30, 30));
            borrarDetalle.Visible = false;

            if (accionformulario == "crear")
            {
                txtCodigoVenta.Text = generaCodFactura();
                editarButton.Visible = false;
                guardarButton.ButtonText = "Guardar";
                fechaVenta.Value = DateTime.Now;
                labelSubtotal.Text = "00,00";
                labelImpuesto.Text = "00,00";
                labelTotal.Text = "00,00";
            }
            else if (accionformulario == "ver")
            {
                ReadStatus(true);
            }
        }

        private string generaCodFactura()
        {
            string codigo;
            DateTime fa = DateTime.Now;

            codigo = "V" + fa.Day + fa.Month + fa.Year.ToString().Substring(2, 2);
            codigo += "-" + fa.ToShortTimeString().Replace(":", "-");

            return codigo;
        }

        private void setDataView(string id)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Cliente");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select * from Venta where ID = '"+ id+"'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtCodigoVenta.Text = row["ID"].ToString();
                    txtCliente.Text = obtenerCliente(row["ClienteID"].ToString());
                    tipoPago.SelectedIndex = int.Parse(row["TipoPago"].ToString());
                    fechaVenta.Value = DateTime.Parse(row["FechaVenta"].ToString());
                    if (int.Parse(row["TipoVenta"].ToString()) == 0)
                        ventaCredito.Checked = false;
                    else
                        ventaCredito.Checked = true;

                    getDetalleVenta(txtCodigoVenta.Text);
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    this.Close();
                }
            }

        }

        private string obtenerCliente(string id)
        {
            DataTable data = new DataTable("Cliente");
            string value;
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select ID, Nombre from Cliente where ID = '"+id+"'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    idcliente = int.Parse(row["ID"].ToString());
                    value = row["Nombre"].ToString();
                }
                catch (Exception ex)
                {
                    value = "";
                }

                return value;
            }
        }

        private DataTable getDetalleVenta(string id)
        {
            DataTable data = new DataTable("Cliente");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "Mostrar_Detalle_Venta";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ID = new SqlParameter();
                    ID.ParameterName = "@id";
                    ID.SqlDbType = SqlDbType.VarChar;
                    ID.Size = 15;
                    ID.Value = id;
                    cmd.Parameters.Add(ID);

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    foreach (DataRow row in data.Rows)
                    {
                        string pid, n, c, pu, d, i, t;
                        pid = Convert.ToString(row[0]);
                        n = Convert.ToString(row[1]);
                        c = Convert.ToString(row[2]);
                        pu = Convert.ToString(row[3]);
                        d = Convert.ToString(row[4]);
                        i = Convert.ToString(row[5]);
                        t = Convert.ToString(row[6]);
                        detalleVenta.Rows.Add(pid, n, c, pu, d, i, t);
                    }

                }
                catch (Exception ex)
                {
                    data = null;
                }
            }

            return data;
        }

        private void detalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accionformulario == "crear")
            {
                borrarDetalle.Visible = true;
                index = e.RowIndex;
            }
        }

        private void detalleVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accionformulario == "crear" || accionformulario == "editar")
            {
                count = e.RowIndex;

                idproducto = int.Parse(detalleVenta.Rows[count].Cells[0].Value.ToString());
                txtProducto.Text = detalleVenta.Rows[count].Cells[1].Value.ToString();
                cantidadVentaProducto.Text = detalleVenta.Rows[count].Cells[2].Value.ToString();
                txtPrecioVenta.Text = detalleVenta.Rows[count].Cells[3].Value.ToString();
                descuentoProducto.Text = detalleVenta.Rows[count].Cells[4].Value.ToString();
                txtStock.Text = setStock(int.Parse(detalleVenta.Rows[count].Cells[0].Value.ToString()));
                if (Convert.ToDecimal(detalleVenta.Rows[count].Cells[5].Value.ToString()) != 0)
                    impuestoValue.Checked = true;
                else
                    impuestoValue.Checked = false;

                panelDatosDetalleVenta.Height = 28;
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            ReadStatus(false);
        }

        private void ReadStatus(bool status)
        {
            if (status)
            {
                accionformulario = "ver";
                editarButton.Visible = true;
                cancelarButton.Visible = false;
                guardarButton.ButtonText = "Cerrar";

                txtCliente.Enabled = false;
                tipoPago.Enabled = false;
                fechaVenta.Enabled = false;
                ventaCredito.Enabled = false;
                Transition.run(panelDatosDV, "Height", 0, new TransitionType_EaseInEaseOut(1000));
            }
            else
            {
                accionformulario = "editar";
                txtCliente.Enabled = true;
                tipoPago.Enabled = true;
                ventaCredito.Enabled = true;
                fechaVenta.Enabled = true;
                Transition.run(panelDatosDV, "Height", 100, new TransitionType_EaseInEaseOut(1000));
                panelDatosDV.SendToBack();

                editarButton.Visible = false;
                cancelarButton.Visible = true;
                guardarButton.ButtonText = "Guardar";
            }
        }

        private void calculoTotales()
        {
            decimal subtotal = 0, impuesto = 0;
            for (int i = 0; i < detalleVenta.Rows.Count; i++)
            {
                subtotal += (int.Parse(detalleVenta.Rows[i].Cells[2].Value.ToString()) * Convert.ToDecimal(detalleVenta.Rows[i].Cells[3].Value.ToString()) - Convert.ToDecimal(detalleVenta.Rows[i].Cells[4].Value.ToString()));
                impuesto += Convert.ToDecimal(detalleVenta.Rows[i].Cells[5].Value.ToString());
            }

            labelSubtotal.Text = subtotal.ToString();
            labelImpuesto.Text = impuesto.ToString();
            labelTotal.Text = Convert.ToString(subtotal+impuesto);
        }

        private void borrarDetalle_Click(object sender, EventArgs e)
        {
            detalleVenta.Rows.RemoveAt(index);
            calculoTotales();
            borrarDetalle.Visible = false;
        }

        private void vistaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                txtCliente.Text = setData(int.Parse(vistaClientes.Rows[e.RowIndex].Cells[0].Value.ToString()), "Cliente");
                panelDatosVenta.Height = 28;
            }
            catch (Exception ex) { new popup("Selección no valida", popup.AlertType.info); }
        }

        private String setData(int id, string tabla)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Data");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select ID, Nombre from " + tabla + " where ID = '" + id+"'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    if (tabla == "Cliente")
                        idcliente = int.Parse(row["ID"].ToString());
                    else
                        idproducto = int.Parse(row["ID"].ToString());

                    return row["Nombre"].ToString();
                }
                catch (Exception ex)
                {
                    return "";
                }
                finally { cn.Close(); }
            }
        }

        private void vistaProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                txtProducto.Text = setData(int.Parse(vistaProducto.Rows[e.RowIndex].Cells[0].Value.ToString()), "Producto");
                panelDatosDetalleVenta.Height = 28;

                setPrecioStock(idproducto);
            }
            catch (Exception ex) { new popup("Selección no valida", popup.AlertType.info); }
        }

        private void setPrecioStock(int id)
        {
            DataTable data = new DataTable("Data");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select PrecioVenta, Stock from Producto where ID = '" + id + "'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtPrecioVenta.Text = row["PrecioVenta"].ToString();
                    txtStock.Text = row["Stock"].ToString();

                }
                catch (Exception ex)
                {
                }
                finally { cn.Close(); }
            }
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if(!vistaProducto.ContainsFocus)
                Transition.run(panelDatosDetalleVenta, "Height", 28, new TransitionType_EaseInEaseOut(1000));
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear" || accionformulario == "editar")
            {
                if (idcliente != -1)
                {
                    //string[] valueid = txtCliente.Text.Split('-');
                    venta v = new venta();
                    v.Id = txtCodigoVenta.Text;
                    v.ClientId = idcliente;
                    v.TipoPago = tipoPago.SelectedIndex;
                    v.FechaVenta = fechaVenta.Value;
                    if (ventaCredito.Checked)
                        v.TipoVenta = 1;
                    else
                        v.TipoVenta = 0;
                    v.SubTotal = decimal.Parse(labelSubtotal.Text);
                    v.Tax = decimal.Parse(labelImpuesto.Text);
                    v.MontoTotal = decimal.Parse(labelTotal.Text);

                    if (accionformulario == "crear")
                    {
                        try
                        {

                            v.Insertar();
                            saveDetalle(1);
                        }
                        catch (Exception ex) { MessageBox.Show("ERROR: Inserción fallida: " + ex.ToString()); }
                        this.Close();
                    }
                    else
                    {
                        try
                        {
                            v.Editar();
                            saveDetalle(0);
                        }
                        catch (Exception ex) { MessageBox.Show("ERROR: Actualización fallida: " + ex.ToString()); }
                        ReadStatus(true);
                        setDataView(txtCodigoVenta.Text);
                    }
                }
                else
                    new popup("No se puede guardar la venta", popup.AlertType.error);

            }
            else
                this.Close();
        }

        private void saveDetalle(int tipo)
        {
            DetalleVenta d = new DetalleVenta();
            for (int i=0; i<detalleVenta.Rows.Count;i++)
            {
                d.ProductoID = int.Parse(detalleVenta.Rows[i].Cells[0].Value.ToString());
                d.VentaID = txtCodigoVenta.Text;
                d.Cantidad = int.Parse(detalleVenta.Rows[i].Cells[2].Value.ToString());
                d.PrecioUnitario = decimal.Parse(detalleVenta.Rows[i].Cells[3].Value.ToString());
                d.Descuento = decimal.Parse(detalleVenta.Rows[i].Cells[4].Value.ToString());
                d.Impuesto = decimal.Parse(detalleVenta.Rows[i].Cells[5].Value.ToString());
                d.Total = decimal.Parse(detalleVenta.Rows[i].Cells[6].Value.ToString());

                if (tipo == 1)
                    d.Insertar();
                else
                    d.Editar();
            }
        }

        private void clearTextboxDetalle()
        {
            txtProducto.Text = "";
            cantidadVentaProducto.Text = "";
            txtStock.Text = "";
            txtPrecioVenta.Text = "";
            descuentoProducto.Text = "";
            impuestoValue.Checked = true;
        }

        private void detalleVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            borrarDetalle.Visible = false;
        }

        private void detalleVenta_Leave(object sender, EventArgs e)
        {
            borrarDetalle.Visible = false;
        }

        private void cantidadVentaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == Convert.ToChar(Keys.Back))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void descuentoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == ',' && !descuentoProducto.Text.Contains(e.KeyChar.ToString()))
            {
                if (descuentoProducto.Text == "")
                {
                    descuentoProducto.Text += "0,";
                    e.Handled = true;
                }
                else
                    e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Back))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void vistaProducto_Leave(object sender, EventArgs e)
        {
            panelDatosDetalleVenta.Height = 28;
        }

        private void vistaClientes_Leave(object sender, EventArgs e)
        {
            panelDatosVenta.Height = 28;
        }

        private void agregarProductoDetalle_Click(object sender, EventArgs e)
        {
            if (idproducto != -1)
            {
                if (count == -1)
                {
                    count = detalleVenta.Rows.Count - 1;
                    detalleVenta.Rows.Add(1);
                }
                //string[] value = txtProducto.Text.Split('-');
                txtPrecioVenta.Text = txtPrecioVenta.Text.Replace('.', ',');
                descuentoProducto.Text = descuentoProducto.Text.Replace('.', ',');
                decimal totalvalue = Convert.ToDecimal(int.Parse(cantidadVentaProducto.Text) * decimal.Parse(txtPrecioVenta.Text));
                decimal descuentovalue = Convert.ToDecimal(descuentoProducto.Text);

                detalleVenta.Rows[count].Cells[0].Value = idproducto;
                detalleVenta.Rows[count].Cells[1].Value = txtProducto.Text;
                detalleVenta.Rows[count].Cells[2].Value = cantidadVentaProducto.Text;
                detalleVenta.Rows[count].Cells[3].Value = txtPrecioVenta.Text;
                detalleVenta.Rows[count].Cells[4].Value = descuentovalue;
                if (impuestoValue.Checked)
                    detalleVenta.Rows[count].Cells[5].Value = (totalvalue - descuentovalue) * decimal.Parse("0,15");
                else
                    detalleVenta.Rows[count].Cells[5].Value = 0;
                detalleVenta.Rows[count].Cells[6].Value = totalvalue - descuentovalue + decimal.Parse(detalleVenta.Rows[count].Cells[5].Value.ToString());

                count = -1;
                idproducto = -1;

                clearTextboxDetalle();
                calculoTotales();
            }
            else
                new popup("Error al agregar", popup.AlertType.error);
        }

        private void fechaVenta_onValueChanged(object sender, EventArgs e)
        {
            
        }

        private string setStock(int id)
        {
            Conexión conexion = new Conexión();
            int contador;

            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand("select Stock from Producto where ID = '"+id+"'", cn);

                    contador = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex) { contador = 0; }
                finally { cn.Close(); }
            }

            return contador.ToString();
        }
    }
}
