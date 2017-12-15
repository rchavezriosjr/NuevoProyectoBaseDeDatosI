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

namespace ProyectoBDI___SisVent.vista
{
    public partial class compraForm : Form
    {
        int count, index, idproveedor=0, idproducto;
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

        private void txtProveedor_Leave(object sender, EventArgs e)
        {
            if(!resultadoProveedor.ContainsFocus)
                Transition.run(panelDatosCompra, "Height", 28, new TransitionType_EaseInEaseOut(1000));
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtProveedor.Text == "")
            {
                panelDatosCompra.Height = 28;
            }
            else
            {
                Transition.run(panelDatosCompra, "Height", 114, new TransitionType_EaseInEaseOut(1000));
                resultadoProveedor.DataSource = new Proveedor().Buscar(txtProveedor.Text, 0);
            }

            idproveedor = -1;
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text == "")
            {
                panelDatosDetalleCompra.Height = 28;
            }
            else
            {
                Transition.run(panelDatosDetalleCompra, "Height", 91, new TransitionType_EaseInEaseOut(1000));
                vistaProducto.DataSource = new Producto().Buscar(txtProducto.Text, 0);
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
                setDataView(txtCodigoCompra.Text);
            }
        }

        private void crearProducto_Click(object sender, EventArgs e)
        {
            new productoForm().ShowDialog();
        }

        private void compraForm_Load(object sender, EventArgs e)
        {
            
            borrarDetalle.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 30, 30, 30, 30));
            borrarDetalle.Visible = false;

            if (accionformulario == "crear")
            {
                txtCodigoCompra.Text = generaCodFactura();
                editarButton.Visible = false;
                guardarButton.ButtonText = "Guardar";
                fechaCompra.Value = DateTime.Now;
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
                fechaCompra.Enabled = false;
                Transition.run(panelDDC, "Height", 0, new TransitionType_EaseInEaseOut(1000));
            }
            else
            {
                accionformulario = "editar";
                txtProveedor.Enabled = true;
                tipoPago.Enabled = true;
                fechaCompra.Enabled = true;
                crearProducto.Visible = false;
                Transition.run(panelDDC, "Height", 100, new TransitionType_EaseInEaseOut(1000));
                panelDDC.SendToBack();

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
                        "select * from Compra where ID = '" + id+"'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtCodigoCompra.Text = row["ID"].ToString();
                    txtProveedor.Text = obtenerProveedor(row["ProveedorID"].ToString());
                    tipoPago.SelectedIndex = int.Parse(row["TipoPago"].ToString());
                    fechaCompra.Value = DateTime.Parse(row["FechaCompra"].ToString());
                    txtTotalCompra.Text = row["Monto"].ToString();
                    
                    getDetalleCompra(txtCodigoCompra.Text);
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    this.Close();
                }
            }

        }

        private string obtenerProveedor(string id)
        {
            DataTable data = new DataTable("Cliente");
            string value;
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select ID, Nombre from Proveedor where ID = " + id,
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    idproveedor = int.Parse(row["ID"].ToString());
                    value = row["Nombre"].ToString();
                }
                catch (Exception ex)
                {
                    value = "";
                }

                return value;
            }
        }

        private void getDetalleCompra(string id)
        {
            DataTable data = new DataTable("Cliente");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "Mostrar_Detalle_Compra";
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
                        string pid, n, c, cu, t;
                        pid = Convert.ToString(row[0]);
                        n = Convert.ToString(row[1]);
                        c = Convert.ToString(row[2]);
                        cu = Convert.ToString(row[3]);
                        t = Convert.ToString(row[4]);
                        detalleCompra.Rows.Add(pid, n, c, cu, t);
                    }

                }
                catch (Exception ex)
                {
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
            try
            {
                txtProveedor.Text = setData(int.Parse(resultadoProveedor.Rows[e.RowIndex].Cells[0].Value.ToString()), "Proveedor");
                panelDatosCompra.Height = 28;
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
                    if (tabla == "Proveedor")
                        idproveedor = int.Parse(row["ID"].ToString());
                    else
                        idproducto = int.Parse(row["ID"].ToString());

                    return  row["Nombre"].ToString();
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
            try
            {
                txtProducto.Text = setData(int.Parse(vistaProducto.Rows[e.RowIndex].Cells[0].Value.ToString()), "Producto");
                panelDatosDetalleCompra.Height = 28;
            }
            catch (Exception ex) { new popup("Selección no valida", popup.AlertType.info); }

        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (!vistaProducto.ContainsFocus)
                Transition.run(panelDatosDetalleCompra, "Height", 28, new TransitionType_EaseInEaseOut(1000));
        }

        private void agregarProductoDetalle_Click(object sender, EventArgs e)
        {
            if (idproducto != -1)
            {
                if (count == -1)
                {
                    count = detalleCompra.Rows.Count - 1;
                    detalleCompra.Rows.Add(1);
                }
                //string[] value = txtProducto.Text.Split('-');
                costoUnitarioProducto.Text = costoUnitarioProducto.Text.Replace('.', ',');

                detalleCompra.Rows[count].Cells[0].Value = idproducto;
                detalleCompra.Rows[count].Cells[1].Value = txtProducto;
                detalleCompra.Rows[count].Cells[2].Value = cantidadCompraProducto.Text;
                detalleCompra.Rows[count].Cells[3].Value = costoUnitarioProducto.Text;
                detalleCompra.Rows[count].Cells[4].Value = int.Parse(cantidadCompraProducto.Text) * Convert.ToDecimal(costoUnitarioProducto.Text);

                count = -1;
                idproducto = -1;

                clearTextboxDetalle();
                txtTotalCompra.Text = calculoTotalCompra().ToString();
            }
            else
                new popup("Error al agregar", popup.AlertType.error);
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

                idproducto = int.Parse(detalleCompra.Rows[count].Cells[0].Value.ToString());
                txtProducto.Text = detalleCompra.Rows[count].Cells[1].Value.ToString();
                cantidadCompraProducto.Text = detalleCompra.Rows[count].Cells[2].Value.ToString();
                costoUnitarioProducto.Text = detalleCompra.Rows[count].Cells[3].Value.ToString();

                panelDatosDetalleCompra.Height = 28;
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
                if (idproveedor != -1)
                {
                    //string[] value = txtProveedor.Text.Split('-');
                    Compra c = new Compra();
                    c.ID = txtCodigoCompra.Text;
                    c.ProveedorID = idproveedor;
                    c.TipoPago = tipoPago.SelectedIndex;
                    c.FechaCompra = fechaCompra.Value;
                    c.Monto = decimal.Parse(txtTotalCompra.Text);

                    if (accionformulario == "crear")
                    {
                        try
                        {
                            c.Insertar();
                            saveDetalle(1);
                        }
                        catch (Exception ex) { MessageBox.Show("ERROR: Inserción fallida: " + ex.ToString()); }
                        this.Close();
                    }
                    else
                    {
                        try
                        {
                            c.Editar();
                            saveDetalle(0);
                        }
                        catch (Exception ex) { MessageBox.Show("ERROR: Actualización fallida: " + ex.ToString()); }
                        ReadStatus(true);
                    }
                }
                else
                    new popup("No se pudo guardar la compra", popup.AlertType.error);
            }
            else
                this.Close();
        }

        private void saveDetalle(int tipo)
        {
            DetalleCompra d = new DetalleCompra();
            for (int i = 0; i < detalleCompra.Rows.Count; i++)
            {
                d.ProdID = int.Parse(detalleCompra.Rows[i].Cells[0].Value.ToString());
                d.CompraID = int.Parse(txtCodigoCompra.Text);
                d.Cant = int.Parse(detalleCompra.Rows[i].Cells[2].Value.ToString());
                d.UnitPrice = decimal.Parse(detalleCompra.Rows[i].Cells[3].Value.ToString());
                d.Total = decimal.Parse(detalleCompra.Rows[i].Cells[4].Value.ToString());

                if (tipo == 1)
                    d.Insertar();
                else
                    d.Editar();
            }
        }

        private void cantidadCompraProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void costoUnitarioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == ',' && !costoUnitarioProducto.Text.Contains(e.KeyChar.ToString()))
            {
                if (costoUnitarioProducto.Text == "")
                {
                    costoUnitarioProducto.Text += "0,";
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
            panelDatosDetalleCompra.Height = 28;
        }

        private void resultadoProveedor_Leave(object sender, EventArgs e)
        {
            panelDatosCompra.Height = 28;
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            ReadStatus(false);
        }

        private void fechaCompra_onValueChanged(object sender, EventArgs e)
        {
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
