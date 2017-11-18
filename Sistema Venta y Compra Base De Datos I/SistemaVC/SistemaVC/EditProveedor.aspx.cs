
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace SistemaVC
{
    public partial class EditProveedor : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Id"] != null)
                {
                    int ProveedorId = Convert.ToInt32(Request.QueryString["Id"]);
                    CargarDatos(ProveedorId);
                }
                txtId.Attributes.Add("readonly", "true");
            }
        }

        private void CargarDatos(int ProveedorId)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.P_Id = ProveedorId;
            DataSet ds = EditProveedor.GetProveedor(proveedor);
            DataRow dr = ds.Tables[0].Rows[0];

            txtId.Text = ProveedorId.ToString();
            txtNombre.Text = dr["Nombre"].ToString();
            txtDomicilio.Text = dr["Domicilio"].ToString();
            txtTelefono.Text = dr["Tel"].ToString();
            txtEmail.Text = dr["Email"].ToString();

        }

        public void LimpiadorControles(ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is DropDownList)
                    ((DropDownList)control).ClearSelection();
                else if (control is RadioButtonList)
                    ((RadioButtonList)control).ClearSelection();
                else if (control is CheckBoxList)
                    ((CheckBoxList)control).ClearSelection();
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control.HasControls())
                    //Esta linea detécta un Control que contenga otros Controles
                    //Así ningún control se quedará sin ser limpiado.
                    LimpiadorControles(control.Controls);
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {

                    Proveedor proveedor = new Proveedor();
                    proveedor.P_Nombre = txtNombre.Text;
                    proveedor.P_Domicilio = txtDomicilio.Text;
                    proveedor.P_Telefono = txtTelefono.Text;
                    proveedor.P_Email = txtEmail.Text;
                    LimpiadorControles(this.Controls);


                    if (EditProveedor.InsertarProveedor(proveedor) > 0)
                    {
                        messageBox.ShowMessage("El Cliente se Guardo correctamente!!");

                    }

                }
                else
                {
                  Proveedor proveedor = new Proveedor();
                  proveedor.P_Id = Convert.ToInt32(txtId.Text);
                    proveedor.P_Nombre = txtNombre.Text;
                    proveedor.P_Domicilio = txtDomicilio.Text;
                    proveedor.P_Telefono = txtTelefono.Text;
                    proveedor.P_Email = txtEmail.Text;

                    if (EditProveedor.Actualizar(proveedor) > 0)
                    {
                        Response.Redirect("ListProveedor.aspx");
                    }
                }
            }
            catch (Exception ex)
            {

                messageBox.ShowMessage(ex.Message + ex.StackTrace);
            }
        }
    }
}