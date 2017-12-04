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
    public partial class compraForm : Form
    {
        int count, index;
        decimal totalCompra = 0;
        string accionformulario;
        public compraForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public compraForm(string id)
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
            Transition.run(panelDatosCompra, "Height", 160, new TransitionType_EaseInEaseOut(1000));
            panelDatosCompra.SendToBack();
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtProveedor.Text != "")
            {
                Transition.run(panelDatosCompra, "Height", 323, new TransitionType_EaseInEaseOut(1000));
                panelDatosCompra.BringToFront();
            }
            else
            {
                Transition.run(panelDatosCompra, "Height", 160, new TransitionType_EaseInEaseOut(1000));
                panelDatosCompra.SendToBack();
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                Transition.run(panelDatosDetalleCompra, "Height", 260, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleCompra.BringToFront();
            }
            else
            {
                Transition.run(panelDatosDetalleCompra, "Height", 100, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleCompra.SendToBack();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear")
                this.Close();
            else
                ReadStatus(true);
        }

        private void crearProducto_Click(object sender, EventArgs e)
        {
            new productoForm().ShowDialog();
        }

        private void compraForm_Load(object sender, EventArgs e)
        {
            
            borrarDetalle.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 30, 30, 30, 30));
            borrarDetalle.Visible = false;
            fechaCompra.Value = DateTime.Now;

            if (accionformulario == "crear")
            {
                txtCodigoCompra.Text = generaCodFactura();
                editarButton.Visible = false;
                guardarButton.ButtonText = "Guardar";
                fechaCompra.BringToFront();
            }
            else if (accionformulario == "ver")
            {
                ReadStatus(true);
            }
        }

        private void ReadStatus(bool status)
        {
            if (status)
            {
                accionformulario = "ver";
                editarButton.Visible = true;
                cancelarButton.Visible = false;
                guardarButton.ButtonText = "Cerrar";

                txtProveedor.Enabled = false;
                tipoPago.Enabled = false;
                fechaCompraLectura.BringToFront();
                fechaCompra.Visible = false;
                Transition.run(panelDatosDetalleCompra, "Height", 0, new TransitionType_EaseInEaseOut(1000));
            }
            else
            {
                accionformulario = "editar";
                txtProveedor.Enabled = true;
                tipoPago.Enabled = true;
                fechaCompra.BringToFront();
                fechaCompra.Visible = true;
                crearProducto.Visible = false;
                Transition.run(panelDatosDetalleCompra, "Height", 100, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleCompra.SendToBack();

                editarButton.Visible = false;
                cancelarButton.Visible = true;
                guardarButton.ButtonText = "Guardar";
            }
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

        private string generaCodFactura()
        {
            string codigo;
            DateTime fa = DateTime.Now;

            codigo = "C" + fa.Day + fa.Month + fa.Year.ToString().Substring(2, 2);
            codigo += "-" + fa.ToShortTimeString().Replace(":", "-");

            return codigo;
        }

        private void resultadoProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProveedor.Text = setData(int.Parse(resultadoProveedor.Rows[e.RowIndex].Cells[0].Value.ToString()), "Proveedor");
            panelDatosCompra.Height = 160;
            panelDatosCompra.SendToBack();
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
            panelDatosDetalleCompra.Height = 100;
            panelDatosDetalleCompra.SendToBack();
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            Transition.run(panelDatosDetalleCompra, "Height", 100, new TransitionType_EaseInEaseOut(1000));
            panelDatosDetalleCompra.SendToBack();
        }

        private void agregarProductoDetalle_Click(object sender, EventArgs e)
        {
            if(count == -1){
                count = detalleCompra.Rows.Count - 1;
                detalleCompra.Rows.Add(1);
            }
            string[] value = txtProducto.Text.Split('-');
            costoUnitarioProducto.Text = costoUnitarioProducto.Text.Replace('.', ',');

            detalleCompra.Rows[count].Cells[0].Value = value[0];
            detalleCompra.Rows[count].Cells[1].Value = value[1];
            detalleCompra.Rows[count].Cells[2].Value = cantidadCompraProducto.Text;
            detalleCompra.Rows[count].Cells[3].Value = costoUnitarioProducto.Text;
            detalleCompra.Rows[count].Cells[4].Value = int.Parse(cantidadCompraProducto.Text) * Convert.ToDecimal(costoUnitarioProducto.Text);

            count = -1;

            clearTextboxDetalle();
            txtTotalCompra.Text = calculoTotalCompra().ToString();
        }

        private void clearTextboxDetalle()
        {
            txtProducto.Text = "";
            cantidadCompraProducto.Text = "";
            costoUnitarioProducto.Text = "";
        }

        private void detalleCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(accionformulario == "crear" || accionformulario == "editar")
            {
                count = e.RowIndex;

                txtProducto.Text = detalleCompra.Rows[count].Cells[0].Value.ToString() + "-" + detalleCompra.Rows[count].Cells[1].Value.ToString();
                cantidadCompraProducto.Text = detalleCompra.Rows[count].Cells[2].Value.ToString();
                costoUnitarioProducto.Text = detalleCompra.Rows[count].Cells[3].Value.ToString();

                Transition.run(panelDatosDetalleCompra, "Height", 100, new TransitionType_EaseInEaseOut(1000));
                panelDatosDetalleCompra.SendToBack();
            }
        }

        private decimal calculoTotalCompra()
        {
            decimal total = 0;
            for (int i = 0; i < detalleCompra.Rows.Count; i++)
                total += Convert.ToDecimal(detalleCompra.Rows[0].Cells[4].Value.ToString());

            return total;
        }

        private void borrarDetalle_Click(object sender, EventArgs e)
        {
            detalleCompra.Rows.RemoveAt(index);
            txtTotalCompra.Text = calculoTotalCompra().ToString();
            borrarDetalle.Visible = false;
        }

        private void detalleCompra_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            borrarDetalle.Visible = false;
        }

        private void detalleCompra_Leave(object sender, EventArgs e)
        {
            borrarDetalle.Visible = false;
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear" || accionformulario == "editar")
            {

                if (accionformulario == "crear")
                {
                    try {  }
                    catch (Exception ex) { MessageBox.Show("ERROR: Inserción fallida: " + ex.ToString()); }
                    this.Close();
                }
                else
                {
                    try {  }
                    catch (Exception ex) { MessageBox.Show("ERROR: Actualización fallida: " + ex.ToString()); }
                    ReadStatus(true);
                }

            }
            else
                this.Close();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            ReadStatus(false);
        }

        private void fechaCompra_onValueChanged(object sender, EventArgs e)
        {
            fechaCompraLectura.Text = fechaCompra.Value.ToString();
        }

        private void detalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(accionformulario == "crear")
            {
                borrarDetalle.Visible = true;
                index = e.RowIndex;
            }
        }
    }

}
