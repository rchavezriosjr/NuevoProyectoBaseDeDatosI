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

namespace ProyectoBDI___SisVent.vista
{
    public partial class ventaForm : Form
    {
        int count, index;
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
            //setDataView(id);
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

        private void txtProveedor_Leave(object sender, EventArgs e)
        {
            Transition.run(panelDatosVenta, "Height", 160, new TransitionType_EaseInEaseOut(1000));
            panelDatosVenta.SendToBack();
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                Transition.run(panelDatosVenta, "Height", 323, new TransitionType_EaseInEaseOut(1000));
                panelDatosVenta.BringToFront();
            }
            else
            {
                Transition.run(panelDatosVenta, "Height", 160, new TransitionType_EaseInEaseOut(1000));
                panelDatosVenta.SendToBack();
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                Transition.run(panelDatosDetalleVenta, "Height", 260, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleVenta.BringToFront();
            }
            else
            {
                Transition.run(panelDatosDetalleVenta, "Height", 100, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleVenta.SendToBack();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear")
                this.Close();
            else
                ReadStatus(true);
        }

        private void ventaForm_Load(object sender, EventArgs e)
        {
            borrarDetalle.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 30, 30, 30, 30));
            borrarDetalle.Visible = false;
            fechaVenta.Value = DateTime.Now;
            labelSubtotal.Text = "00,00";
            labelImpuesto.Text = "00,00";
            labelTotal.Text = "00,00";
            txtStock.Text = "5";
            txtPrecioVenta.Text = "10";

            if (accionformulario == "crear")
            {
                txtCodigoVenta.Text = generaCodFactura();
                editarButton.Visible = false;
                guardarButton.ButtonText = "Guardar";
                fechaVenta.BringToFront();
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
                        "select * from Venta where ID = " + id,
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    this.Close();
                }
            }

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

                txtProducto.Text = detalleVenta.Rows[count].Cells[0].Value.ToString() + "-" + detalleVenta.Rows[count].Cells[1].Value.ToString();
                cantidadVentaProducto.Text = detalleVenta.Rows[count].Cells[2].Value.ToString();
                txtPrecioVenta.Text = detalleVenta.Rows[count].Cells[3].Value.ToString();
                descuentoProducto.Text = detalleVenta.Rows[count].Cells[4].Value.ToString();
                //txtStock.Text = setStock(int.Parse(detalleVenta.Rows[count].Cells[0].Value.ToString()));
                if (Convert.ToDecimal(detalleVenta.Rows[count].Cells[5].Value.ToString()) != 0)
                    impuestoValue.Checked = true;
                else
                    impuestoValue.Checked = false;

                Transition.run(panelDatosDetalleVenta, "Height", 100, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleVenta.SendToBack();
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
                fechaVentaLectura.BringToFront();
                fechaVenta.Visible = false;
                ventaCredito.Enabled = false;
                Transition.run(panelDatosDetalleVenta, "Height", 0, new TransitionType_EaseInEaseOut(1000));
            }
            else
            {
                accionformulario = "editar";
                txtCliente.Enabled = true;
                tipoPago.Enabled = true;
                ventaCredito.Enabled = true;
                fechaVenta.BringToFront();
                fechaVenta.Visible = true;
                Transition.run(panelDatosDetalleVenta, "Height", 100, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleVenta.SendToBack();

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
            txtCliente.Text = setData(int.Parse(vistaClientes.Rows[e.RowIndex].Cells[0].Value.ToString()), "Cliente");
            panelDatosVenta.Height = 160;
            panelDatosVenta.SendToBack();
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
                        "select ID, Nombre from " + tabla + " where ID = " + id,
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    return row["ID"].ToString() + "-" + row["Nombre"].ToString();
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
            txtProducto.Text = setData(int.Parse(vistaProducto.Rows[e.RowIndex].Cells[0].Value.ToString()), "Producto");
            panelDatosDetalleVenta.Height = 100;
            panelDatosDetalleVenta.SendToBack();
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            Transition.run(panelDatosDetalleVenta, "Height", 100, new TransitionType_EaseInEaseOut(1000));
            panelDatosDetalleVenta.SendToBack();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear" || accionformulario == "editar")
            {

                if (accionformulario == "crear")
                {
                    try { }
                    catch (Exception ex) { MessageBox.Show("ERROR: Inserción fallida: " + ex.ToString()); }
                    this.Close();
                }
                else
                {
                    try { }
                    catch (Exception ex) { MessageBox.Show("ERROR: Actualización fallida: " + ex.ToString()); }
                    ReadStatus(true);
                }

            }
            else
                this.Close();
        }

        private void clearTextboxDetalle()
        {
            txtProducto.Text = "";
            cantidadVentaProducto.Text = "";
            //txtStock.Text = "";
            //txtPrecioVenta.Text = "";
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

        private void agregarProductoDetalle_Click(object sender, EventArgs e)
        {
            if (count == -1)
            {
                count = detalleVenta.Rows.Count - 1;
                detalleVenta.Rows.Add(1);
            }
            string[] value = txtProducto.Text.Split('-');
            txtPrecioVenta.Text = txtPrecioVenta.Text.Replace('.', ',');
            descuentoProducto.Text = descuentoProducto.Text.Replace('.', ',');
            decimal totalvalue = Convert.ToDecimal(int.Parse(cantidadVentaProducto.Text) * decimal.Parse(txtPrecioVenta.Text));
            decimal descuentovalue = Convert.ToDecimal(descuentoProducto.Text);

            detalleVenta.Rows[count].Cells[0].Value = value[0];
            detalleVenta.Rows[count].Cells[1].Value = value[1];
            detalleVenta.Rows[count].Cells[2].Value = cantidadVentaProducto.Text;
            detalleVenta.Rows[count].Cells[3].Value = txtPrecioVenta.Text;
            detalleVenta.Rows[count].Cells[4].Value = descuentovalue;
            if (impuestoValue.Checked)
                detalleVenta.Rows[count].Cells[5].Value = (totalvalue - descuentovalue) * decimal.Parse("0,15");
            else
                detalleVenta.Rows[count].Cells[5].Value = 0;
            detalleVenta.Rows[count].Cells[6].Value = totalvalue - descuentovalue + decimal.Parse(detalleVenta.Rows[count].Cells[5].Value.ToString());

            count = -1;

            clearTextboxDetalle();
            calculoTotales();
        }

        private void fechaVenta_onValueChanged(object sender, EventArgs e)
        {
            fechaVentaLectura.Text = fechaVenta.Value.ToString();
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

                    SqlCommand cmd = new SqlCommand("select Stock from Producto where ID = " + id, cn);

                    contador = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex) { contador = 0; }
                finally { cn.Close(); }
            }

            return contador.ToString();
        }
    }
}
