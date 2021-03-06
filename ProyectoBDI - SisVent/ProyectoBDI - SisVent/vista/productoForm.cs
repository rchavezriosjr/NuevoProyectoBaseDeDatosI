﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBDI___SisVent.data;

namespace ProyectoBDI___SisVent.vista
{
    public partial class productoForm : Form
    {
        string accionformulario;
        public productoForm()
        {
            InitializeComponent();
            accionformulario = "crear";
        }

        public productoForm(int id)
        {
            InitializeComponent();
            accionformulario = "ver";
            setDataView(id);
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear")
                this.Close();
            else
            {
                ReadStatus(true);
                setDataView(int.Parse(txtID.Text));
            }
        }

        private void productoForm_Load(object sender, EventArgs e)
        {
            if (accionformulario == "crear")
            {
                editarButton.Visible = false;
                txtID.Visible = false;
                labelId.Visible = false;
                guardarButton.ButtonText = "Guardar";
            }
            else if (accionformulario == "ver")
            {
                ReadStatus(true);
            }
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (accionformulario == "crear" || accionformulario == "editar")
            {
                Producto p = new Producto();
                p.CategoriaID = int.Parse( txtIDCategoria.Text);
                p.Nombre = txtNombreProducto.Text;
                p.Descripcion = txtDescripcion.Text;
                p.Stock = int.Parse(txtStock.Text );
                p.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
                if(estadoValor.Checked)
                    p.Estado = 1;
                else
                    p.Estado = 0;
                
                if (accionformulario == "crear")
                {
                    try {
                        p.Insertar();
                    }
                    catch (Exception ex) { MessageBox.Show("ERROR: Inserción fallida: " + ex.ToString()); }
                    this.Close();
                }
                else
                {
                    try {
                        p.ID = int.Parse(txtID.Text);
                        p.Editar();
                    }
                    catch (Exception ex) { MessageBox.Show("ERROR: Actualización fallida: " + ex.ToString()); }
                    ReadStatus(true);
                    setDataView(int.Parse(txtID.Text));
                }

            }
            else
                this.Close();
        }

        private void ReadStatus(bool status)
        {
            if (status)
            {
                accionformulario = "ver";
                editarButton.Visible = true;
                cancelarButton.Visible = false;
                guardarButton.ButtonText = "Cerrar";

                txtNombreProducto.Enabled = false;
                txtPrecioVenta.Enabled = false;
                txtStock.Enabled = false;
                txtIDCategoria.Enabled = false;
                txtDescripcion.Enabled = false;
                estadoValor.Enabled = false;
            }
            else
            {
                accionformulario = "editar";
                txtNombreProducto.Enabled = true;
                txtPrecioVenta.Enabled = true;
                txtStock.Enabled = true;
                txtIDCategoria.Enabled = true;
                txtDescripcion.Enabled = true;
                estadoValor.Enabled = true;

                editarButton.Visible = false;
                cancelarButton.Visible = true;
                guardarButton.ButtonText = "Guardar";
            }
        }

        private void setDataView(int id)
        {
            Conexión conexion = new Conexión();
            DataTable data = new DataTable("Cliente");
            using (SqlConnection cn = new SqlConnection(Conexión.Cn))
            {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "select * from Producto where ID = '" + id+"'",
                        cn
                        );

                    SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                    SqlDat.Fill(data);

                    DataRow row = data.Rows[0];
                    txtID.Text = row["ID"].ToString();
                    txtNombreProducto.Text = row["Nombre"].ToString();
                    txtPrecioVenta.Text = row["PrecioVenta"].ToString();
                    txtStock.Text = row["Stock"].ToString();
                    txtIDCategoria.Text = row["CategoriaID"].ToString();
                    txtDescripcion.Text = row["Descripcion"].ToString();
                    if (int.Parse(row["Estado"].ToString()) == 0)
                        estadoValor.Checked = false;
                    else
                        estadoValor.Checked = true;
                }
                catch (Exception ex)
                {
                    new popup("Error al mostrar información", popup.AlertType.error);
                    this.Close();
                }
            }

        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            ReadStatus(false);
        }
    }
}
