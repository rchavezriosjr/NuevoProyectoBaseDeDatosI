
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace SistemaVC
{
    public partial class EditCliente : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Id"] != null)
                {
                    int ClienteId = Convert.ToInt32(Request.QueryString["Id"]);
                    CargarDatos(ClienteId);
                }
                txtId.Attributes.Add("readonly", "true");
            }
        }

        private void CargarDatos(int ClienteId)
        {
            Cliente cliente = new Cliente();
            cliente.C_Id = ClienteId;
            DataSet ds = EditCliente.GetCliente(cliente);
            DataRow dr = ds.Tables[0].Rows[0];

            txtId.Text = ClienteId.ToString();
            txtNombre.Text = dr["Nombre"].ToString();
            txtDomicilio.Text = dr["Domicilio"].ToString();
            txtTelefono.Text = dr["Telefono"].ToString();
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

                    Cliente cliente = new Cliente();
                    cliente.C_Nombre = txtNombre.Text;
                    cliente.C_Domicilio = txtDomicilio.Text;
                    cliente.C_Telefono = txtTelefono.Text;
                    cliente.C_Email = txtEmail.Text;
                    LimpiadorControles(this.Controls);


                    if (EditCliente.InsertarCliente(cliente) > 0)
                    {
                        messageBox.ShowMessage("El Cliente se Guardo correctamente!!");

                    }

                }
                else
                {
                    Cliente cliente = new Cliente();
                    cliente.C_Id = Convert.ToInt32(txtId.Text);
                    cliente.C_Nombre = txtNombre.Text;
                    cliente.C_Domicilio = txtDomicilio.Text;
                    cliente.C_Telefono = txtTelefono.Text;
                    cliente.C_Email = txtEmail.Text;

                    if (EditCliente.Actualizar(cliente) > 0)
                    {
                        Response.Redirect("ListCliente.aspx");
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